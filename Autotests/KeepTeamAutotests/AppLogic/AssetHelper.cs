using KeepTeamAutotests.Model;
using KeepTeamAutotests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepTeamAutotests.AppLogic
{
    public class AssetHelper
    {
        private AppManager app;
        private PageManager pages;
        public AssetHelper(AppManager app)
            
        {
            this.app = app;
            this.pages = app.Pages;
            
        }


        public void createAsset(Asset asset)
        {
            editAsset(asset);
        }
        public void editAsset(Asset asset)
        {
            //заполнение полей создания инвентаря
            pages.newAssetPopup.ensurePageLoaded();
            pages.newAssetPopup.setNameField(asset.ASName);
            pages.newAssetPopup.setID(asset.ASID);
            pages.newAssetPopup.setCategoryField(asset.ASCategory);
            pages.newAssetPopup.setDateField(asset.ASDate);
            //pages.newAssetPopup.setEmployeeField();
            pages.newAssetPopup.setDescriptionField(asset.ASDescription);
            pages.newAssetPopup.addClick();

            refreshpage();

        }

        public void refreshpage()
        {
            //перезагрузка страницы, для проверки введенных полей
            pages.newAssetPopup.waitSaveDone();
            pages.newAssetPopup.refreshPage();
        }



        public bool CompareAssets(Asset A1, Asset A2)
        {
            A1.WriteToConsole();
            A2.WriteToConsole();
            return A1.ASName == A2.ASName &&
                A1.ASCategory == A2.ASCategory &&
                A1.ASID == A2.ASID &&
                A1.ASDate == A2.ASDate &&
                A1.ASEmployee == A2.ASEmployee &&
                A1.ASDescription == A2.ASDescription ;
                 
                 

        
        }

        public Asset getAssetPopup()
        {
            openFirstAsset();
           
            //переход к первой записи
            pages.newAssetPopup.ensurePageLoaded();
            Asset asset = new Asset();
            asset.ASCategory = pages.newAssetPopup.getCategory();
            asset.ASDate = pages.newAssetPopup.getDate();
            asset.ASDescription = pages.newAssetPopup.getDescription();
            asset.ASEmployee = pages.newAssetPopup.getEmployee();
            asset.ASID = pages.newAssetPopup.getID();
            asset.ASName = pages.newAssetPopup.getName();

            pages.newAssetPopup.closePopup();

            return asset;

        }


        public void DeleteCurrentAsset()
        {
            //Удаление через троеточие
            openDeleteMessageFromThreeDots();
            pages.deleteMessagePage.yesButtonClick();
            pages.deleteMessagePage.waitSaveDone();
            
        }
        public void openDeleteMessageFromThreeDots()
        {
            //Открытие меню удаления
            pages.personalAssetPage.ensurePageLoaded();
            pages.personalAssetPage.deleteFromThreeDots();

            pages.contextMenuPage.ensurePageLoaded();
            //pages.contextMenuPage.byTextClick("Удалить");
            pages.contextMenuPage.byIndexClick(0);
            pages.deleteMessagePage.ensurePageLoaded();

        }



        public Asset getAssetFromTable()
        {
           /* pages.personalAssetPage.ensurePageLoaded();
            pages.personalAssetPage.ensureTableLoaded();
            */
            Asset asset = new Asset();
            asset.ASCategory = pages.personalAssetPage.getASCategory();
            asset.ASName = pages.personalAssetPage.getASName();
            asset.ASID = pages.personalAssetPage.getASID();
            asset.ASDate = pages.personalAssetPage.getASDate();
           
            return asset;
        }

        public void openFirstAsset()
        {
            //получение информации об инвентаре
            pages.personalAssetPage.ensurePageLoaded();
            pages.personalAssetPage.openAssetPopup();

        }

        public void clearAssetPopup()
        {
            //Очистка полей попапа инвентаря
            pages.newAssetPopup.ensurePageLoaded();
            pages.newAssetPopup.clearName();
            pages.newAssetPopup.clearCategory();
            pages.newAssetPopup.clearID();
            pages.newAssetPopup.clearDate();
            //pages.newAssetPopup.clearEmployee();
            pages.newAssetPopup.clearDescription();

        
        }
       
    }
}
