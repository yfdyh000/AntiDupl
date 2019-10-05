/*
* AntiDupl.NET Program (http://ermig1979.github.io/AntiDupl).
*
* Copyright (c) 2002-2018 Yermalayeu Ihar, 2013-2018 Borisov Dmitry.
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
#include "adIO.h"
#include "adImageInfo.h"

namespace ad
{
    void TImageInfo::Init()
    {
        type = AD_IMAGE_UNDEFINE;
        width = 0;
        height = 0;
		blockiness = -1.0;
		blurring = -1.0;
		imageExif;

        index = AD_UNDEFINED;
        group = AD_UNDEFINED;
        links = 0;
        removed = false;
		selected = false;
    }
    
    TImageInfo::~TImageInfo()
    {
    }

    TImageInfo& TImageInfo::operator = (const TImageInfo& imageInfo)
    {
        *(static_cast<TFileInfo*>(this)) = imageInfo;

        type = imageInfo.type;
        width = imageInfo.width;
        height = imageInfo.height;
		blockiness = imageInfo.blockiness;
		blurring = imageInfo.blurring;
		imageExif = imageInfo.imageExif;

        index = imageInfo.index;
        group = imageInfo.group;
        links = imageInfo.links;
        removed = imageInfo.removed;

        return *this;
    }

	// Экспортируем информацию об изображение в переданный указатель.
    bool TImageInfo::Export(adImageInfoPtrA pImageInfo) const
    {
        if(pImageInfo == NULL)
            return false;

        pImageInfo->id = (size_t)this;
        path.Original().CopyTo(pImageInfo->path, MAX_PATH);
        pImageInfo->size = size;
        pImageInfo->time = time;
        pImageInfo->type = type;
        pImageInfo->width = width;
        pImageInfo->height = height;
		pImageInfo->blockiness = blockiness;
		pImageInfo->blurring = blurring;
		imageExif.Export(&pImageInfo->exifInfo);

        return true;
    }

    bool TImageInfo::Export(adImageInfoPtrW pImageInfo) const
    {
        if(pImageInfo == NULL)
            return false;

        pImageInfo->id = (size_t)this;
        path.Original().CopyTo(pImageInfo->path, MAX_PATH_EX);
        pImageInfo->size = size;
        pImageInfo->time = time;
        pImageInfo->type = type;
        pImageInfo->width = width;
        pImageInfo->height = height;
		pImageInfo->blockiness = blockiness;
		pImageInfo->blurring = blurring;
		imageExif.Export(&pImageInfo->exifInfo);

        return true;
    }
}

