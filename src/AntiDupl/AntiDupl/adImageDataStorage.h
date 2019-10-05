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
#ifndef __adImageDataStorage_h__
#define __adImageDataStorage_h__

#include "adImageData.h"

namespace ad
{
    class TEngine;
    //-------------------------------------------------------------------------
	// Хранение информации об изображениях в т.ч. эскизов
	class TImageDataStorage
	{
	public:
		TImageDataStorage(TEngine *pEngine);
		~TImageDataStorage() {ClearMemory();}

		TImageDataPtr Get(const TFileInfo& fileInfo);

		adError Load(const TChar *path, bool allLoad = false);
		adError Save(const TChar *path);

		adError ClearDatabase(const TChar *path);

		void Check();
		void ClearMemory();
		void SetSaveState(const bool needToSave);

	private:
		typedef std::multimap<TUInt32, TImageDataPtr> TStorage;
		typedef std::vector<TImageDataPtr> TVector;

		TStorage::iterator Find(const TFileInfo& fileInfo);
		TStorage::iterator Insert(TImageData* pImageData);

		// Информация которую будем записывать. Словарь TImageData
		TStorage m_storage;
		TStatus *m_pStatus;
		TOptions *m_pOptions;

		bool m_needToSave;

		struct TData
		{
			enum Type
			{
				Skip, //не загружаем, так как их нет в путях поиска, но сохраняем
				Old, // удаляется при сохранение, и они только и загружаются (если есть в путях поиска)
				New,
			} type;
			short key;
			size_t size;
			TPath first;
			TPath last;
			TVector data;

			TData(short key_ = 0) : key(key_), size(0), type(Skip) {}
		};
		typedef std::map<short, TData> TIndex;
		
		void CreateSorted(TVector & sorted) const;
		void SetOld(TIndex & index, bool allLoad) const;
		void UpdateIndex(TIndex & index) const;
		void DeleteOldIndex(TIndex & index, const TChar *path) const;

		TString GetDataFileName(short key) const;

		bool SaveIndex(const TIndex & index, const TChar *path) const;
		bool SaveData(const TData & data, const TChar *path) const;

		bool LoadIndex(TIndex & index, const TChar *fileName, bool allLoad = false) const;
		bool LoadData(TData & data, const TChar *path, short key);
	};
    //-------------------------------------------------------------------------
}
#endif //__adImageDataStorage_h__
