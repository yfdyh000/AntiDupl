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
using System;
using System.Collections.Generic;
using System.Text;

namespace AntiDupl.NET
{
    static public class StringsDefaultRussian
    {
        static public void CopyTo(Strings s)
        {
            s.Name = "Russian";
            s.OriginalLanguageName = "Русский";
            
            s.OkButton_Text = "OK";
            s.CancelButton_Text = "Отмена";
            s.StopButton_Text = "Стоп";
            s.SetDefaultButton_Text = "По умолчанию";

            s.ErrorMessage_FileAlreadyExists = "Невозможно переименовать файл, так как файл с таким именем уже существует!";

            s.WarningMessage_ChangeFileExtension = "Вы действительно хотите изменить расширение файла?";

            s.AboutProgramPanel_CopyrightLabel0_Text = "Copyright (c) 2002-2018 Ермолаев Игорь,";
            s.AboutProgramPanel_CopyrightLabel1_Text = "2013-2018 Борисов Дмитрий.";
            s.AboutProgramPanel_ComponentLabel_Text = "Компонент";
            s.AboutProgramPanel_VersionLabel_Text = "Версия";

            s.AboutProgramForm_Text = "О программе...";

            s.StartFinishForm_LoadImages_Text = "Загрузка файла картинок";
            s.StartFinishForm_LoadMistakes_Text = "Загрузка файла ошибок";
            s.StartFinishForm_LoadResults_Text = "Загрузка файла результатов";
            s.StartFinishForm_SaveImages_Text = "Сохранение файла картинок";
            s.StartFinishForm_SaveMistakes_Text = "Сохранение файла ошибок";
            s.StartFinishForm_SaveResults_Text = "Сохранение файла результатов";
            s.StartFinishForm_ClearTemporary_Text = "Удаление временных файлов";

            s.CoreOptionsForm_Text = "Опции";

            s.CoreOptionsForm_SearchTabPage_Text = "Поиск";
            s.CoreOptionsForm_SearchFileTypeGroupBox_Text = "Искать типы:";
            s.CoreOptionsForm_BmpCheckBox_Text = "BMP";
            s.CoreOptionsForm_GifCheckBox_Text = "GIF";
            s.CoreOptionsForm_JpegCheckBox_Text = "JPEG";
            s.CoreOptionsForm_PngCheckBox_Text = "PNG";
            s.CoreOptionsForm_TiffCheckBox_Text = "TIFF";
            s.CoreOptionsForm_EmfCheckBox_Text = "EMF";
            s.CoreOptionsForm_WmfCheckBox_Text = "WMF";
            s.CoreOptionsForm_ExifCheckBox_Text = "EXIF";
            s.CoreOptionsForm_IconCheckBox_Text = "ICON";
            s.CoreOptionsForm_Jp2CheckBox_Text = "JP2";
            s.CoreOptionsForm_PsdCheckBox_Text = "PSD";
            s.CoreOptionsForm_DdsCheckBox_Text = "DDS";
            s.CoreOptionsForm_TgaCheckBox_Text = "TGA";
            s.CoreOptionsForm_WebpCheckBox_Text = "WEBP";
            s.CoreOptionsForm_SearchSystemCheckBox_Text = "Искать системные каталоги/файлы";
            s.CoreOptionsForm_SearchHiddenCheckBox_Text = "Искать скрытые каталоги/файлы";

            s.CoreOptionsForm_CompareTabPage_Text = "Сравнение";
            s.CoreOptionsForm_CheckOnEqualityCheckBox_Text = "Искать дублирующие картинки";
            s.CoreOptionsForm_TransformedImageCheckBox_Text = "Искать повернутые и зеркальные дубликаты";
            s.CoreOptionsForm_SizeControlCheckBox_Text = "Учитывать размер картинок";
            s.CoreOptionsForm_TypeControlCheckBox_Text = "Учитывать тип картинок";
            s.CoreOptionsForm_RatioControlCheckBox_Text = "Учитывать соотношение ширины/высоты картинок";
            s.CoreOptionsForm_AlgorithmComparingLabeledComboBox_Text = "Алгоритм сравнения изображений";
            s.CoreOptionsForm_AlgorithmComparingLabeledComboBox_SquaredSum = "Среднеквадратичная разность";
            s.CoreOptionsForm_ThresholdDifferenceLabeledComboBox_Text = "Пороговая разность";
            s.CoreOptionsForm_MinimalImageSizeLabeledIntegerEdit_Text = "Минимальная ширина/высота картинок";
            s.CoreOptionsForm_MaximalImageSizeLabeledIntegerEdit_Text = "Максимальная ширина/высота картинок";
            s.CoreOptionsForm_CompareInsideOneSearchPathCheckBox_Text = "Сравнивать картинки из одного пути поиска друг с другом";
            s.CoreOptionsForm_CompareInsideOneFolderCheckBox_Text = "Сравнивать картинки внутри одного каталога";

            s.CoreOptionsForm_DefectTabPage_Text = "Дефекты";
            s.CoreOptionsForm_CheckOnDefectCheckBox_Text = "Проверять на дефекты";
            s.CoreOptionsForm_CheckOnBlockinessCheckBox_Text = "Проверять на блочность";
            s.CoreOptionsForm_BlockinessThresholdLabeledComboBox_Text = "Порог блочности";
            s.CoreOptionsForm_CheckOnBlockinessOnlyNotJpegCheckBox_Text = "Проверять на блочность только для не Jpeg";
            s.CoreOptionsForm_CheckOnBlurringCheckBox_Text = "Проверять на размытость";
            s.CoreOptionsForm_BlurringThresholdLabeledComboBox_Text = "Порог размытости";

            s.CoreOptionsForm_AdvancedTabPage_Text = "Дополнительные";
            s.CoreOptionsForm_DeleteToRecycleBinCheckBox_Text = "Удалять в корзину";
            s.CoreOptionsForm_MistakeDataBaseCheckBox_Text = "Запоминать ложные срабатывания";
            s.CoreOptionsForm_RatioResolutionLabeledComboBox_Text = "Точность соотношения ширины/высоты картинок";
            s.CoreOptionsForm_CompareThreadCountLabeledComboBox_Text = "Количество потоков сравнения";
            s.CoreOptionsForm_CompareThreadCountLabeledComboBox_Description_0 = "Авто";
            s.CoreOptionsForm_CollectThreadCountLabeledComboBox_Text = "Количество потоков загрузки";
            s.CoreOptionsForm_CollectThreadCountLabeledComboBox_Description_0 = "Авто";
            s.CoreOptionsForm_ReducedImageSizeLabeledComboBox_Text = "Отнормированный размер картинок";
            s.CoreOptionsForm_UndoQueueSizeLabeledIntegerEdit_Text = "Размер очереди отмены";
            s.CoreOptionsForm_ResultCountMaxLabeledIntegerEdit_Text = "Максимальное количество результатов";
            s.CoreOptionsForm_IgnoreFrameWidthLabeledComboBox_Text = "Ширина игнорируемой рамки картинки";

            s.CoreOptionsForm_HighlightTabPage_Text = "Подсветка";
            s.CoreOptionsForm_HighlightDifferenceCheckBox_Text = "Подсветка различий";
            s.CoreOptionsForm_DifrentValue_Text = "Величина различия";
            s.CoreOptionsForm_NotHighlightIfFragmentsMoreThemCheckBox_Text = "Не подсвечивать различия, если фрагментов больше чем:";
            s.CoreOptionsForm_MaxFragmentsForDisableHighlightLabeledIntegerEdit_Text = "Максимально количество фрагментов для отключения подсветки";
            s.CoreOptionsForm_HighlightAllDifferencesCheckBox_Text = "Подсвечивать все различия";
            s.CoreOptionsForm_MaxFragmentsForHighlightLabeledIntegerEdit_Text = "Максимально количество фрагментов для подсветки";
            s.CoreOptionsForm_AmountOfFragmentsOnXLabeledIntegerEdit_Text = "Количество фрагментов по X";
            s.CoreOptionsForm_AmountOfFragmentsOnYLabeledIntegerEdit_Text = "Количество фрагментов по Y";
            s.CoreOptionsForm_NormalizedSizeOfImageLabeledIntegerEdit_Text = "Нормированный размер изображения";
            s.CoreOptionsForm_PenThicknessLabeledIntegerEdit_Text = "Толшина рамки выделения";

            s.CorePathsForm_Text = "Пути";
            s.CorePathsForm_SearchTabPage_Text = "Искать";
            s.CorePathsForm_IgnoreTabPage_Text = "Пропускать";
            s.CorePathsForm_ValidTabPage_Text = "Проверено";
            s.CorePathsForm_DeleteTabPage_Text = "Удалять";
            s.CorePathsForm_AddFolderButton_Text = "Добавить каталог";
            s.CorePathsForm_AddFilesButton_Text = "Добавить файлы";
            s.CorePathsForm_ChangeButton_Text = "Изменить";
            s.CorePathsForm_RemoveButton_Text = "Убрать";
            s.CorePathsForm_SearchCheckedListBox_ToolTip_Text = "Установленный флажок означает поиск внутри поддиректорий указанной директории.";

            s.ProgressUtils_Completed = "завершено {0}%";
            s.ProgressUtils_5HoursRemaining = "осталось {0} часов";
            s.ProgressUtils_2HoursRemaining = "осталось {0} часа";
            s.ProgressUtils_5MinutesRemaining = "осталось {0} минут";
            s.ProgressUtils_2MinutesRemaining = "осталось {0} минуты";
            s.ProgressUtils_5SecondsRemaining = "осталось {0} секунд";

            s.ProgressForm_DeleteDefect = "Удаление испорченных картинок в выделенных результатах";
            s.ProgressForm_DeleteFirst = "Удаление первых картинок в выделенных результатах";
            s.ProgressForm_DeleteSecond = "Удаление вторых картинок в выделенных результатах";
            s.ProgressForm_DeleteBoth = "Удаление всех парных картинок в выделенных результатах";
            s.ProgressForm_PerformHint = "Автоматическая обработка выделенных результатов";
            s.ProgressForm_Mistake = "Пометка выделенных результатов как ошибочных";
            s.ProgressForm_RenameCurrent = "Переименование/перемещение изображений";
            s.ProgressForm_RefreshResults = "Обновление результатов";
            s.ProgressForm_Undo = "Отмена действия";
            s.ProgressForm_Redo = "Повторение действия";

            s.SearchExecuterForm_Result = "Обработка результатов";
            s.SearchExecuterForm_Search = "Поиск";
            s.SearchExecuterForm_Stopped = "Остановка поиска";
            s.SearchExecuterForm_MinimizeToTaskbarButton_Text = "Свернуть";
            s.SearchExecuterForm_MinimizeToSystrayButton_Text = "Фоновый режим";

            s.ResultsPreviewBase_NextButton_ToolTip_Text = "Перейти к следующему результату";
            s.ResultsPreviewBase_PreviousButton_ToolTip_Text = "Перейти к предыдущему результату";

            s.ResultsPreviewDuplPair_DeleteFirstButton_ToolTip_Text = "Удалить первую картинку";
            s.ResultsPreviewDuplPair_DeleteSecondButton_ToolTip_Text = "Удалить вторую картинку";
            s.ResultsPreviewDuplPair_DeleteBothButton_ToolTip_Text = "Удалить обе картинки";
            s.ResultsPreviewDuplPair_RenameFirstToSecondButton_ToolTip_Text = "Заместить вторую картинку первой";
            s.ResultsPreviewDuplPair_RenameSecondToFirstButton_ToolTip_Text = "Заместить первую картинку второй";
            s.ResultsPreviewDuplPair_MistakeButton_ToolTip_Text = "Пометить текущий результат как ошибочный";

            s.ResultsPreviewDefect_DeleteButton_ToolTip_Text = "Удалить картинку";
            s.ResultsPreviewDefect_MistakeButton_ToolTip_Text = "Пометить текущий результат как ошибочный";

            s.ResultRowSetter_DefectIcon_ToolTip_Text = "Дефектная картинка";
            s.ResultRowSetter_DuplPairIcon_ToolTip_Text = "Дублирующая пара картинок";

            s.ResultRowSetter_UnknownDefectIcon_ToolTip_Text = "Неизвестный дефект";
            s.ResultRowSetter_JpegEndMarkerIsAbsentIcon_ToolTip_Text = "Отсутствует маркер конца JPEG файла";
            s.ResultRowSetter_blockinessIcon_ToolTip_Text = "Блочное изображение";
            s.ResultRowSetter_blurringIcon_ToolTip_Text = "Размытое изображение";

            s.ResultRowSetter_DeleteDefectIcon_ToolTip_Text = "Удалить картинку";
            s.ResultRowSetter_DeleteFirstIcon_ToolTip_Text = "Удалить первую картинку";
            s.ResultRowSetter_DeleteSecondIcon_ToolTip_Text = "Удалить вторую картинку";
            s.ResultRowSetter_RenameFirstToSecondIcon_ToolTip_Text = "Заместить вторую картинку первой";
            s.ResultRowSetter_RenameSecondToFirstIcon_ToolTip_Text = "Заместить первую картинку второй";

            s.ResultRowSetter_Turn_0_Icon_ToolTip_Text = "Оригинал";
            s.ResultRowSetter_Turn_90_Icon_ToolTip_Text = "Повернутый на 90°";
            s.ResultRowSetter_Turn_180_Icon_ToolTip_Text = "Повернутый на 180°";
            s.ResultRowSetter_Turn_270_Icon_ToolTip_Text = "Повернутый на 270°";
            s.ResultRowSetter_MirrorTurn_0_Icon_ToolTip_Text = "Горизонтально отраженный";
            s.ResultRowSetter_MirrorTurn_90_Icon_ToolTip_Text = "Горизонтально отраженный и повернутый на 90°";
            s.ResultRowSetter_MirrorTurn_180_Icon_ToolTip_Text = "Горизонтально отраженный и повернутый на 180°";
            s.ResultRowSetter_MirrorTurn_270_Icon_ToolTip_Text = "Горизонтально отраженный и повернутый на 270°";

            s.ResultsListView_Type_Column_Text = "Тип";
            s.ResultsListView_Group_Column_Text = "Группа";
            s.ResultsListView_GroupSize_Column_Text = "Размер группы";
            s.ResultsListView_Difference_Column_Text = "Различие";
            s.ResultsListView_Defect_Column_Text = "Тип дефекта";
            s.ResultsListView_Transform_Column_Text = "Трансформация";
            s.ResultsListView_Hint_Column_Text = "Рекомендация";
            
            s.ResultsListView_FileName_Column_Text = "Имя";
            s.ResultsListView_FileDirectory_Column_Text = "В каталоге";
            s.ResultsListView_ImageSize_Column_Text = "Размеры";
            s.ResultsListView_ImageType_Column_Text = "Тип картинки";
            s.ResultsListView_Blockiness_Column_Text = "Блочность";
            s.ResultsListView_Blurring_Column_Text = "Размытие";
            s.ResultsListView_FileSize_Column_Text = "Размер";
            s.ResultsListView_FileTime_Column_Text = "Дата изменения";

            s.ResultsListView_FirstFileName_Column_Text = "1: Имя";
            s.ResultsListView_FirstFileDirectory_Column_Text = "1: В каталоге";
            s.ResultsListView_FirstImageSize_Column_Text = "1: Размеры";
            s.ResultsListView_FirstImageType_Column_Text = "1: Тип картинки";
            s.ResultsListView_FirstBlockiness_Column_Text = "1: Блочность";
            s.ResultsListView_FirstBlurring_Column_Text = "1: Размытие";
            s.ResultsListView_FirstFileSize_Column_Text = "1: Размер";
            s.ResultsListView_FirstFileTime_Column_Text = "1: Дата изменения";
            s.ResultsListView_SecondFileName_Column_Text = "2: Имя";
            s.ResultsListView_SecondFileDirectory_Column_Text = "2: В каталоге";
            s.ResultsListView_SecondImageSize_Column_Text = "2: Размеры";
            s.ResultsListView_SecondImageType_Column_Text = "2: Тип картинки";
            s.ResultsListView_SecondBlockiness_Column_Text = "2: Блочность";
            s.ResultsListView_SecondBlurring_Column_Text = "2: Размытие";
            s.ResultsListView_SecondFileSize_Column_Text = "2: Размер";
            s.ResultsListView_SecondFileTime_Column_Text = "2: Дата изменения";

            s.ResultsListViewContextMenu_DeleteDefectItem_Text = "Удалить испорченные картинки в выделенных результатах";
            s.ResultsListViewContextMenu_DeleteFirstItem_Text = "Удалить первые картинки в выделенных результатах";
            s.ResultsListViewContextMenu_DeleteSecondItem_Text = "Удалить вторые картинки в выделенных результатах";
            s.ResultsListViewContextMenu_DeleteBothItem_Text = "Удалить все парные картинки в выделенных результатах";
            s.ResultsListViewContextMenu_RenameFirstToSecondIcon_ToolTip_Text = "Заместить вторые картинки первыми в выделенных результатах";
            s.ResultsListViewContextMenu_RenameSecondToFirstIcon_ToolTip_Text = "Заместить первые картинки вторыми в выделенных результатах";
            s.ResultsListViewContextMenu_RenameFirstLikeSecondButton_ToolTip_Text = "Переименовать первые картинки как вторые в выделенных результатах";
            s.ResultsListViewContextMenu_RenameSecondLikeFirstButton_ToolTipText = "Переименовать вторые картинки как первые в выделенных результатах";
            s.ResultsListViewContextMenu_MoveFirstToSecondButton_ToolTipText = "Переместить первые картинки ко вторым в выделенных результатах";
            s.ResultsListViewContextMenu_MoveSecondToFirstButton_ToolTipText = "Переместить вторые картинки к первыми в выделенных результатах";
            s.ResultsListViewContextMenu_MistakeItem_Text = "Пометить выделенные результаты как ошибочные";
            s.ResultsListViewContextMenu_PerformHintItem_Text = "Автоматически обработать выделенные результаты";

            s.MainStatusStrip_TotalLabel_Text = "Всего: ";
            s.MainStatusStrip_CurrentLabel_Text = "Текущий: ";
            s.MainStatusStrip_SelectedLabel_Text = "Выделено: ";

            s.MainMenu_FileMenuItem_Text = "Файл";
            s.MainMenu_File_OpenProfileMenuItem_Text = "Открыть профиль поиска";
            s.MainMenu_File_SaveProfileAsMenuItem_Text = "Сохранить профиль поиска как";
            s.MainMenu_File_LoadProfileOnLoadingMenuItem_Text = "Загружать профиль при загрузке";
            s.MainMenu_File_SaveProfileOnClosingMenuItem_Text = "Сохранять профиль при закрытие";
            s.MainMenu_File_ExitMenuItem_Text = "Выход";

            s.MainMenu_EditMenuItem_Text = "Правка";
            s.MainMenu_Edit_UndoMenuItem_Text = "Отменить (Ctrl-Z)";
            s.MainMenu_Edit_RedoMenuItem_Text = "Повторить (Ctrl-Y)";
            s.MainMenu_Edit_SelectAllMenuItem_Text = "Выделить все (Ctrl-A)";

            s.MainMenu_ViewMenuItem_Text = "Вид";
            s.MainMenu_View_ToolMenuItem_Text = "Панель инструментов";
            s.MainMenu_View_StatusMenuItem_Text = "Строка состояния";
            s.MainMenu_View_SelectColumnsMenuItem_Text = "Выбор столбцов";
            s.MainMenu_View_HotKeysMenuItem_Text = "Горячие клавиши";
            s.MainMenu_View_StretchSmallImagesMenuItem_Text = "Растягивать небольшие изображения";
            s.MainMenu_View_ProportionalImageSizeMenuItem_Text = "Пропорциональный размер картинок";
            s.MainMenu_View_ShowNeighbourImageMenuItem_Text = "Показывать соседние изображения";

            s.MainMenu_SearchMenuItem_Text = "Поиск";
            s.MainMenu_Search_StartMenuItem_Text = "Начать поиск";
            s.MainMenu_Search_RefreshResultsMenuItem_Text = "Обновить результаты";
            s.MainMenu_Search_RefreshImagesMenuItem_Text = "Удалить неактуальные записи из базы данных о картинках";
            s.MainMenu_Search_PathsMenuItem_Text = "Пути";
            s.MainMenu_Search_OptionsMenuItem_Text = "Опции";
            s.MainMenu_Search_OnePathMenuItem_Text = "Один путь поиска";
            s.MainMenu_Search_UseImageDataBaseMenuItem_Text = "Использовать базу данных о картинках";
            s.MainMenu_Search_CheckResultsAtLoadingMenuItem_Text = "Проверять результаты при загрузке";
            s.MainMenu_Search_CheckMistakesAtLoadingMenuItem_Text = "Проверять базу данных об ошибках при загрузке";

            s.MainMenu_HelpMenuItem_Text = "Справка";
            s.MainMenu_Help_HelpMenuItem_Text = "Справка";
            s.MainMenu_Help_AboutProgramMenuItem_Text = "О программе...";
            s.MainMenu_Help_CheckingForUpdatesMenuItem_Text = "Проверять наличие обновлений";

            s.MainMenu_NewVersionMenuItem_Text = "Новая версия";
            s.MainMenu_NewVersionMenuItem_Tooltip = "AntiDupl.NET-{0} доступна на сайте!";

            s.SelectHotKeysForm_InvalidHotKeyToolTipText = "Эта комбинация клавиш уже используется для других целей.";
            
            s.LanguageMenuItem_Text = "Язык";

            s.ViewModeMenuItem_Text = "Режим просмотра результатов";
            s.ViewModeMenuItem_VerticalPairTableMenuItem_Text = "Таблица вертикальных пар";
            s.ViewModeMenuItem_HorizontalPairTableMenuItem_Text = "Таблица горизонтальных пар";
            s.ViewModeMenuItem_GroupedThumbnailsMenuItem_Text = "Сгруппированные миниатюры";

            s.ImagePreviewContextMenu_CopyPathItem_Text = "Скопировать путь";
            s.ImagePreviewContextMenu_CopyFileNameItem_Text = "Скопировать имя картинки";
            s.ImagePreviewContextMenu_OpenImageItem_Text = "Открыть картинку";
            s.ImagePreviewContextMenu_OpenFolderItem_Text = "Открыть каталог с картинкой";
            s.ImagePreviewContextMenu_AddToIgnore_Text = "Добавить в игнорируемые";
            s.ImagePreviewContextMenu_AddToIgnoreDirectory_Text = "Добавить директорию в игнорируемые";
            s.ImagePreviewContextMenu_RenameImageItem_Text = "Переименовать картинку";
            s.ImagePreviewContextMenu_RenameImageLikeNeighbour_Text = "Переименовать картинку как соседнию";
            s.ImagePreviewContextMenu_MoveImageToNeighbourItem_Text = "Переместить картинку к соседней";
            s.ImagePreviewContextMenu_MoveAndRenameImageToNeighbourItem_Text = "Переместить и переименовать к соседней";
            s.ImagePreviewContextMenu_MoveGroupToNeighbourItem_Text = "Перенести группу в папку к соседней";
            s.ImagePreviewContextMenu_RenameGroupAsNeighbourItem_Text = "Переименовать файлы в группе как соседней файл";

            s.ImagePreviewPanel_EXIF_Text = "EXIF";
            s.ImagePreviewPanel_EXIF_Tooltip_ImageDescription = "Описание: ";
            s.ImagePreviewPanel_EXIF_Tooltip_EquipMake = "Изготовитель камеры: ";
            s.ImagePreviewPanel_EXIF_Tooltip_EquipModel = "Модель камеры: ";
            s.ImagePreviewPanel_EXIF_Tooltip_SoftwareUsed = "Программное обеспечение: ";
            s.ImagePreviewPanel_EXIF_Tooltip_DateTime = "Дата/Время: ";
            s.ImagePreviewPanel_EXIF_Tooltip_Artist = "Автор: ";
            s.ImagePreviewPanel_EXIF_Tooltip_UserComment = "Комментарий: ";
        }

        static private Strings Create()
        {
            Strings strings = new Strings();
            CopyTo(strings);
            return strings;
        }

        static public Strings Get()
        {
            return m_strings;
        }

        static private Strings m_strings = Create();
    }
}
