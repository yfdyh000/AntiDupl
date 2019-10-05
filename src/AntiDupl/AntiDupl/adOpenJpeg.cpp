/*
* AntiDupl.NET Program (http://ermig1979.github.io/AntiDupl).
*
* Copyright (c) 2002-2018 Yermalayeu Ihar.
*
* Permission is hereby granted, free of charge, to any person obtaining a copy 
* of this software and associated documentation files (the "Software"), to deal
* in the Software without restriction, including without limitation the rights
* to use, copy, modify, merge, publish, distribute, sublicense, and/or sell 
* copies of the Software, and to permit persons to whom the Software is 
* furnished to do so, subject to the following conditions:
*
* The above copyright notice and this permission notice shall be included in 
* all copies or substantial portions of the Software.
*
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
* FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE 
* AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
* LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
* SOFTWARE.
*/
#define OPJ_STATIC
#include "LibOpenJpeg/openjpeg.h"

#include "adPerformance.h"
#include "adOpenJpeg.h"

namespace ad
{
    void InterleaveBgra(
        uint8_t *bgra, size_t size, 
        const int *blue, int bluePrecision, bool blueSigned, 
        const int *green, int greenPrecision, bool greenSigned,
        const int *red, int redPrecision, bool redSigned,
        uint8_t alpha)
    {
        assert(bluePrecision > 0 && greenPrecision > 0 && redPrecision > 0 && 
            bluePrecision < 32 && greenPrecision < 32 && redPrecision < 32);
        assert((bluePrecision >= 8 && greenPrecision >= 8 && redPrecision >= 8) || 
            (bluePrecision <= 8 && greenPrecision <= 8 && redPrecision <= 8)); 

        int blueAdjust = blueSigned ? 1 << (bluePrecision - 1) : 0;
        int greenAdjust = greenSigned ? 1 << (greenPrecision - 1) : 0;
        int redAdjust = redSigned ? 1 << (redPrecision - 1) : 0;
        if(bluePrecision >= 8 && greenPrecision >= 8 && redPrecision >= 8)
        {
            int blueShift = bluePrecision - 8;
            int greenShift = greenPrecision - 8;
            int redShift = redPrecision - 8;
            for(size_t i = 0; i < size; ++i, bgra += 4)
            {
                bgra[0] = (blue[i] + blueAdjust) >> blueShift;
                bgra[1] = (green[i] + greenAdjust) >> greenShift;
                bgra[2] = (red[i] + redAdjust) >> redShift;
                bgra[3] = alpha;
            }
        }
        else
        {
            int blueShift = 8 - bluePrecision;
            int greenShift = 8 - greenPrecision;
            int redShift = 8 - redPrecision;
            for(size_t i = 0; i < size; ++i, bgra += 4)
            {
                bgra[0] = (blue[i] + blueAdjust) << blueShift;
                bgra[1] = (green[i] + greenAdjust) << greenShift;
                bgra[2] = (red[i] + redAdjust) << redShift;
                bgra[3] = alpha;
            }
        }
    }

    void InterleaveBgra(uint8_t *bgra, size_t size, 
        const int *gray, int grayPrecision, bool graySigned, 
        uint8_t alpha)
    {
        assert(grayPrecision > 0 && grayPrecision < 32);

        int grayAdjust = graySigned ? 1 << (grayPrecision - 1) : 0;
        if(grayPrecision >= 8)
        {
            int grayShift = grayPrecision - 8;
            for(size_t i = 0; i < size; ++i, bgra += 4)
            {
                int value = (gray[i] + grayAdjust) >> grayShift;
                bgra[0] = value;
                bgra[1] = value;
                bgra[2] = value;
                bgra[3] = alpha;
            }
        }
        else
        {
            int grayShift = 8 - grayPrecision;
            for(size_t i = 0; i < size; ++i, bgra += 4)
            {
                int value = (gray[i] + grayAdjust) << grayShift;
                bgra[0] = value;
                bgra[1] = value;
                bgra[2] = value;
                bgra[3] = alpha;
            }
        }
    }

    void RowYuv444ToBgra(unsigned char *bgra, size_t width, const int *y, const int *u, const int *v, int shift, unsigned char alpha)
    {
        const int *end = y + width;
        for(;y < end; y += 1, u += 1, v += 1, bgra += 4)
        {
            int y0 = y[0] << shift;
            int u0 = u[0] << shift;
            int v0 = v[0] << shift;
            bgra[0] = Simd::Base::YuvToBlue(y0, u0);
            bgra[1] = Simd::Base::YuvToGreen(y0, u0, v0);
            bgra[2] = Simd::Base::YuvToRed(y0, v0);
            bgra[3] = alpha;
        }
    }

    void Yuv444ToBgra(unsigned char *bgra, size_t width, size_t height, size_t stride,
        const int *y, const int *u, const int *v, int shift, unsigned char alpha)
    {
        for(size_t row  = 0; row < height; ++row)
        {
            RowYuv444ToBgra(bgra, width, y, u, v, shift, alpha);
            bgra += stride;
            y += width;
            u += width;
            v += width;
        }
    }

    void Yuv422ToBgra(unsigned char *bgra, size_t width, size_t height, size_t stride,
        const int *y, const int *u, const int *v, int shift, unsigned char alpha)
    {
        assert(height%2 == 0);

        size_t uv_height = height/2;
        for(size_t row  = 0; row < uv_height; ++row)
        {
            RowYuv444ToBgra(bgra, width, y, u, v, shift, alpha);
            bgra += stride;
            y += width;
            RowYuv444ToBgra(bgra, width, y, u, v, shift, alpha);
            bgra += stride;
            y += width;
            u += width;
            v += width;
        }
    }

    void RowYuv420ToBgra(unsigned char *bgra, size_t width, const int *y, const int *u, const int *v, int shift, unsigned char alpha)
    {
        const int *end = y + width;
        for(;y < end; y += 2, u += 1, v += 1, bgra += 8)
        {
            int y0 = y[0] << shift;
            int u0 = u[0] << shift;
            int v0 = v[0] << shift;
            bgra[0] = Simd::Base::YuvToBlue(y0, u0);
            bgra[1] = Simd::Base::YuvToGreen(y0, u0, v0);
            bgra[2] = Simd::Base::YuvToRed(y0, v0);
            bgra[3] = alpha;
            int y1 = y[1] << shift;
            bgra[4] = Simd::Base::YuvToBlue(y1, u0);
            bgra[5] = Simd::Base::YuvToGreen(y1, u0, v0);
            bgra[6] = Simd::Base::YuvToRed(y1, v0);
            bgra[7] = alpha;
        }
    }

    void Yuv420ToBgra(unsigned char *bgra, size_t width, size_t height, size_t stride,
        const int *y, const int *u, const int *v, int shift, unsigned char alpha)
    {
        assert(width%2 == 0 && height%2 == 0);

        size_t uv_width = width/2; 
        size_t uv_height = height/2;
        for(size_t row = 0; row < uv_height; ++row)
        {
            RowYuv420ToBgra(bgra, width, y, u, v, shift, alpha);
            bgra += stride;
            y += width;
            RowYuv420ToBgra(bgra, width, y, u, v, shift, alpha);
            bgra += stride;
            y += width;
            u += uv_width;
            v += uv_width;
        }
    }

    void YuvToBgra(unsigned char *bgra, size_t width, size_t height, size_t stride,
        const int *y, const int *u, const int *v, int dx, int dy, int precision, unsigned char alpha)
    {
        assert(precision >= 8 && (dx == 1 || dx == 2) && (dy == 1 || dy == 2) && (dy != 1 || dx != 2));

        if(dy == 2)
        {
            if(dx == 2)
                Yuv420ToBgra(bgra, width, height, stride, y, u, v, precision - 8, alpha);
            else
                Yuv422ToBgra(bgra, width, height, stride, y, u, v, precision - 8, alpha);
        }
        else
            Yuv444ToBgra(bgra, width, height, stride, y, u, v, precision - 8, alpha);
    }

    TOpenJpeg* TOpenJpeg::Load(HGLOBAL hGlobal)
    {
        if(hGlobal)
        {
            TView *pView = Load((unsigned char*)::GlobalLock(hGlobal), ::GlobalSize(hGlobal));
            ::GlobalUnlock(hGlobal);
            if(pView)
            {
                TOpenJpeg* pOpenJpeg = new TOpenJpeg();
                pOpenJpeg->m_pView = pView;
                pOpenJpeg->m_format = TImage::Jp2;
                return pOpenJpeg;
            }
        }
        return NULL;
    }

    static CODEC_FORMAT OpenJpegCodecFormat(unsigned char *data, size_t size)
    {
        unsigned char j2k[2] = {0xff, 0x4f};
        unsigned char jp2[4] = {0x6a, 0x50, 0x20, 0x20};
        if(size >= 2 && memcmp(data, j2k, sizeof(j2k)) == 0)
            return OPJ_CODEC_J2K;
        if(size >= 8 && memcmp(data + 4, jp2, sizeof(jp2)) == 0)
            return OPJ_CODEC_JP2;
        return OPJ_CODEC_UNKNOWN;
    }

    bool TOpenJpeg::Supported(HGLOBAL hGlobal)
    {
        if(hGlobal)
        {
            CODEC_FORMAT codecFormat = OpenJpegCodecFormat((unsigned char*)::GlobalLock(hGlobal), ::GlobalSize(hGlobal));
            ::GlobalUnlock(hGlobal);
            return codecFormat != OPJ_CODEC_UNKNOWN;
        }
        return false;
    }

    struct Blob
    {
        unsigned char * data;
        OPJ_SIZE_T size, pos;
    };

    static OPJ_SIZE_T ReadFromBlob(void * buffer, OPJ_SIZE_T size, Blob * blob)
    {
        OPJ_SIZE_T read = std::min(blob->pos + size, blob->size) - blob->pos;
        memcpy(buffer, blob->data + blob->pos, read);
        blob->pos += read;
        return read ? read : (OPJ_SIZE_T)-1;
    }

    static OPJ_UINT64 GetBlobLength(Blob * blob)
    {
        return (OPJ_UINT64)blob->size;
    }

    static OPJ_SIZE_T WriteToBlob(void * buffer, OPJ_SIZE_T size, Blob * blob)
    {
        assert(0);
        return (OPJ_SIZE_T)-1;
    }

    static OPJ_OFF_T SkipFromBlob(OPJ_OFF_T skip, Blob * blob)
    {
        OPJ_SIZE_T pos = blob->pos + (OPJ_SIZE_T)skip;
        if (pos >= blob->size)
            return -1;
        blob->pos += (OPJ_SIZE_T)skip;
        return skip;
    }

    static OPJ_BOOL SeekInBlob(OPJ_OFF_T offset, Blob * blob)
    {
        OPJ_SIZE_T pos = (OPJ_SIZE_T)offset;
        if (pos >= blob->size)
            return OPJ_FALSE;
        blob->pos = (OPJ_SIZE_T)offset;
        return OPJ_TRUE;
    }

    opj_stream_t * OPJ_CALLCONV СreateBlobStream(unsigned char * data, OPJ_SIZE_T size)
    {
        opj_stream_t * stream = opj_stream_default_create(OPJ_TRUE);
        if (!stream)
            return NULL;
        Blob * blob = (Blob*)malloc(sizeof(Blob));
        if (!blob)
        {
            opj_stream_destroy(stream);
            return NULL;
        }
        blob->data = data;
        blob->size = size;
        blob->pos = 0;
        opj_stream_set_user_data(stream, blob, (opj_stream_free_user_data_fn)free);
        opj_stream_set_user_data_length(stream, size);
        opj_stream_set_read_function(stream, (opj_stream_read_fn)ReadFromBlob);
        opj_stream_set_write_function(stream, (opj_stream_write_fn)WriteToBlob);
        opj_stream_set_skip_function(stream, (opj_stream_skip_fn)SkipFromBlob);
        opj_stream_set_seek_function(stream, (opj_stream_seek_fn)SeekInBlob);
        return stream;
    }

    TView* TOpenJpeg::Load(unsigned char * data, size_t size)
    {
        AD_FUNCTION_PERFORMANCE_TEST
        TView *pView = NULL;
        opj_codec_t * codec = opj_create_decompress(OpenJpegCodecFormat(data, size));
        if(codec)
        {
            opj_dparameters_t parameters;
            opj_set_default_decoder_parameters(&parameters);
            opj_setup_decoder(codec, &parameters);
            opj_stream_t * stream = СreateBlobStream(data, size);
            if(stream)
            {
                opj_image_t  * image; 
                if (opj_read_header(stream, codec, &image))
                {
                    if(opj_decode(codec, stream, image))
                    {
                        size_t width = image->x1 - image->x0;
                        size_t height = image->y1 - image->y0;
                        if(image->color_space != OPJ_CLRSPC_UNKNOWN && width > 0 && width <= SHRT_MAX &&
                            height > 0 && height <= SHRT_MAX && image->numcomps > 0)
                        {
                            opj_image_comp_t &c0 = image->comps[0];
                            if(image->numcomps >= 3)
                            {
                                opj_image_comp_t &c1 = image->comps[1];
                                opj_image_comp_t &c2 = image->comps[2];
                                if(image->color_space == OPJ_CLRSPC_SRGB || image->color_space == OPJ_CLRSPC_UNSPECIFIED)
                                {
                                    if(c0.prec >= 8 && c0.dx == 1 && c1.dx == 1 && c2.dx == 1 && c0.dy == 1 && c1.dy == 1 && c2.dy == 1)
                                    {
                                        pView = new TView(width, height, width*TView::PixelSize(TView::Bgra32), TView::Bgra32, NULL);
                                        InterleaveBgra(pView->data, width*height, 
                                            c2.data, c2.prec, c2.sgnd != 0, c1.data, c1.prec, c1.sgnd != 0, c0.data, c0.prec, c0.sgnd != 0, 0xFF);
                                    }
                                }
                                else if (image->color_space == OPJ_CLRSPC_SYCC)
                                { 
                                    if(c0.prec >= 8 && (c1.dx == 1 || c1.dx == 2) && (c1.dy == 1 || c1.dy == 2) 
                                        && (c1.dy != 1 || c1.dx != 2) && width%c1.dx == 0 && height%c1.dy == 0)
                                    {
                                        pView = new TView(width, height, width*TView::PixelSize(TView::Bgra32), TView::Bgra32, NULL);
                                        YuvToBgra(pView->data, width, height, pView->stride,
                                            c0.data, c1.data, c2.data, c1.dx, c1.dy, c0.prec, 0xFF);
                                    }
                                }
                            }
                            else
                            {
                                if(image->color_space == OPJ_CLRSPC_GRAY || image->color_space == OPJ_CLRSPC_UNSPECIFIED)
                                {
                                    if(c0.prec >= 8 && c0.dx == 1 && c0.dy == 1)
                                    {
                                        pView = new TView(width, height, width*TView::PixelSize(TView::Bgra32), TView::Bgra32, NULL);
                                        InterleaveBgra(pView->data, width*height, c0.data, c0.prec, c0.sgnd != 0, 0xFF);
                                    }
                                }
                            }
                            AD_PERFORMANCE_TEST_SET_SIZE(width*height)
                        }
                    }
                    opj_image_destroy(image);
                }
                opj_stream_destroy(stream);
            }
            opj_destroy_codec(codec);
        }
        return pView;
    }
}
