using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using ImageMagick;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Interactions;
using System.IO;
using System.Reflection;
using System.Drawing;
using KeepTeamAutotests.Model;

namespace KeepTeamAutotests.Pages
{

    public class Page
    {
        [FindsBy(How = How.XPath, Using = "//header")]
        private IWebElement header;
        protected string pagename = "DefaultPage";


        protected PageManager pageManager;


        public Page(PageManager pageManager)
        {
            this.pageManager = pageManager;


        }

        public string getTitle()
        {
            return pageManager.driver.Title;
        }

        public virtual void ensurePageLoaded()
        {

        }

        public Boolean waitPageLoaded()
        {
            try
            {
                ensurePageLoaded();
                return true;
            }
            catch (TimeoutException)
            {
                return false;
            }
        }

        public Page refreshPage()
        {
            try
            {
                pageManager.driver.Navigate().Refresh();
                return this;
            }
            catch (TimeoutException)
            {
                Console.Out.WriteLine("Ошибка при обновлении страницы");
                return null;
            }
            catch 
            {
                Console.Out.WriteLine("Ошибка при обновлении страницы второй кетч");
                return null;
            }

            
        }

        public MagickImage readImage(string FilePath)
        {
            try
            {
                MagickImage image = new MagickImage(FilePath);
                return image;
            }
            catch
            {
                Console.Out.WriteLine(FilePath + " не найден");
                return null;
            }
        }

        public double saveResult(MagickImage StandartIM, MagickImage CurrentIM, string outFilePath, string outCurFilePath)
        {
            MagickImage resultImage = new MagickImage();
            var compareResult = StandartIM.Compare(CurrentIM, ErrorMetric.Absolute, resultImage);

            if (compareResult != 0)
            {
                CreateScreenDirectory(Path.GetDirectoryName(outFilePath));
                CreateScreenDirectory(Path.GetDirectoryName(outCurFilePath));
                resultImage.Write(outFilePath);
                CurrentIM.Write(outCurFilePath);
                Console.Out.WriteLine("Погрешность= " + compareResult + " Изображения не совпадают" + outFilePath);

            }
            else
            {
                Console.Out.WriteLine("Изображения совпадают");

            }
            return compareResult;

        }
        private void CreateScreenDirectory(string path)
        {
            //если нет папки создаем 
            try
            {
                DirectoryInfo di = Directory.CreateDirectory(path);
            }
            catch
            {
                Console.Out.WriteLine("создание пути не удалось: " + path);
            }


        }
        public void PathToImage()
        {

        }

        public double CompareScreenShot(IWebElement element, string PathToStandart, string PathToResult, string PathToCurrent, string filename, int offset)
        {
            double resultCompare = 0;
            MagickImage standartIm = readImage(Path.Combine(PathToStandart, filename));
            //если есть эталон
            if (standartIm != null)
            {
                MagickImage testIm = takeSnapshot(element, offset);
                //создаем файл с результатами
                resultCompare += saveResult(standartIm, testIm, Path.Combine(PathToResult, filename), Path.Combine(PathToCurrent, filename));

            }
            //если эталона нет
            else
            {
                //сохраняем текущее состояние
                saveScreenshot(element, Path.Combine(PathToCurrent, filename), offset);
                resultCompare = 1;
            }
            return resultCompare;

        }
        public bool CompareScreenShots(string filename)
        {
            string pathofimages = Path.Combine(pageManager.globalpath, pageManager.browsername, pageManager.versionname);
            string standart = Path.Combine(pathofimages, pageManager.standartpath, pagename);
            string result = Path.Combine(pathofimages, pageManager.resultpath, pagename);
            string current = Path.Combine(pathofimages, pageManager.currentpath, pagename);

            double resultCompare = 0;
            List<IWebElement> elements = GetWebElements();
            // тут снимаем какие-то скриншоты и сравниваем
            int i = 0;
            foreach (IWebElement element in elements)
            {
                resultCompare = CompareScreenShot(element, standart, result, current, string.Format(filename + "[" + i + "].png"), 0);
                i++;
                Thread.Sleep(1000);
            }
            return resultCompare == 0;
        }


        public virtual List<IWebElement> GetWebElements()
        {
            List<IWebElement> elements = new List<IWebElement>();
            // тут делаем список элементов, которые есть на каждой странице
            // и для которых надо делать сравнение скриншотов
            //elements.Add(header);
            return elements;

        }
        protected void saveScreenshot(IWebElement webElement, string outFilePath, int offset)
        {
            try
            {
                CreateScreenDirectory(Path.GetDirectoryName(outFilePath));
                MagickImage MImage = takeSnapshot(webElement, offset);
                MImage.Write(outFilePath);
            }
            catch
            {
                Console.Out.WriteLine("Ошибка при сохранении файла Page.saveScreenshot");
            }


        }
        protected MagickImage takeSnapshot(IWebElement webElement, int offset)
        {
            try
            {
                Screenshot image = ((ITakesScreenshot)pageManager.driver).GetScreenshot();
                MagickImage MImage = new MagickImage(image.AsByteArray);
                Point coords = (webElement as ILocatable).LocationOnScreenOnceScrolledIntoView;
                // MagickGeometry n = new MagickGeometry(webElement.Location.X - offset, webElement.Location.Y - offset, webElement.Size.Width + 2 * offset, webElement.Size.Height + 2 * offset);
                MagickGeometry n = new MagickGeometry(coords.X - offset, coords.Y - offset, webElement.Size.Width + 2 * offset, webElement.Size.Height + 2 * offset);
                MImage.Crop(n);
                return MImage;
            }
            catch
            {
                Console.Out.WriteLine("Ошибка при снятии скриншота");
                return null;
            }



        }
        //разобраться как использовать данный метод
        protected bool IsElementPresent(By by)
        {
            return pageManager.driver.FindElements(by).Count > 0;
        }

        protected void setProgressBar(IWebElement field, int progress)
        {
            if (progress != null)
            {
                Actions actions = new Actions(pageManager.driver);
                actions.MoveToElement(field,field.Size.Width*progress/100, 0).Click().Build().Perform();
                
            }
                
        }
        protected int getProgressBar(IWebElement field)
        {
            try
            {
                if (field.GetAttribute("style") == "")
                {
                    return 0;
                }
                
                else
                {
                    string temp = field.GetAttribute("style").Remove(0, "width: ".Length);
                    return Convert.ToInt32(temp.Remove(temp.Length - "%;".Length));
                }
                   
            }
            catch (NoSuchElementException)
            {
                return 0;
            }


        }
        
        //метод для получения строки из текстового поля.
        protected string getTextField(IWebElement field)
        {
            try
            {
                if (field.GetAttribute("value") == "")
                {
                    return null;
                }
                else if (field.GetAttribute("value") == "дд.мм.гггг")//костыль для сафари
                {
                    return null;
                }
                else
                    return field.GetAttribute("value");
            }
            catch (NoSuchElementException)
            {
                return null;
            }


        }
        protected string getTextField(IWebElement field, string placeholder)
        {
            try
            {
                return getTextField(field).Remove(0, placeholder.Length);
            }
            catch
            {
                return null;
            }

        }
        protected string getTextField(IWebElement field, string placeholder, string placeholderend)
        {
            try
            {
                string temp = getTextField(field).Remove(0, placeholder.Length);
                return temp.Remove(temp.Length - placeholderend.Length);
            }
            catch
            {
                return null;
            }

        }



        protected void setTextField(IWebElement field, string text)
        {
            if (text != null)
                field.SendKeys(text);
        }

        /*  protected void setSuggestField(IWebElement suggest, string text)
          {
              if (text != null)
              {
                  //блок для стабильности в хроме
                  suggest.Click();
                  waitSuggestOpen();
                  //--------------------

                  suggest.SendKeys(text);
                  waitSuggestOpen();
                  //suggest.SendKeys(Keys.Enter);
                  suggest.FindElement(By.XPath("//div[@class = 'b-textfield-input-border']//div[contains(@class,'ng-binding') and text() = '" + text + "']")).Click();
              }

          }*/
        protected void setSuggestField(IWebElement suggest, string text)
        {
            try
            {
                if (text != null)
                {
                    //блок для стабильности в хроме
                    suggest.Click();
                    waitSuggestOpen();
                    //--------------------

                    suggest.SendKeys(text);
                    waitSuggestOpen();
                    //suggest.SendKeys(Keys.Enter);
                 //   suggest.FindElement(By.XPath("//div[@class = 'b-textfield_with_dropdown-item ng-scope']//span[contains(@class,'ng-binding') and text() = '" + text + "']")).Click();
                    suggest.FindElement(By.XPath("//div[contains(@class,'b-suggest_menu-item')]/span[text() = '" + text + "']")).Click();
                    
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }

        protected void setDateField(IWebElement dateField, string date)
        {
            if (date != null)
            {
                dateField.Click();
                dateField.SendKeys(Keys.Home);
                dateField.SendKeys(date);

            }

        }
        protected void setDateFieldWithDatePicker(IWebElement dateField, string date)
        {
            if (date != null)
            {
                dateField.Click();
                dateField.SendKeys(Keys.Home);
                dateField.SendKeys(date);
                Thread.Sleep(1000);
                dateField.FindElement(By.XPath("..//..//*[contains(@class,'b-date_picker--day-hover')]")).Click();


            }

        }


        protected void setDropdownByText(IWebElement dropdown, string text)
        {
            if (text != null)
            {
                // клик для открытия списка
                dropdown.Click();
                dropdown.FindElement(By.XPath("//*[contains(@class,'b-suggest_menu-item-name') and text() = '" + text + "']")).Click();
            }
        }

        private string getUneditableText(IWebElement element)
        {
            try
            {
                return element.Text;
            }
            catch
            {
                return null;
            }

        }
        private string getUneditableText(IWebElement element, string placeholder, string placeholderend)
        {
            try
            {
                string temp = getUneditableText(element).Remove(0, placeholder.Length);
                return temp.Remove(temp.Length - placeholderend.Length);
            }
            catch
            {
                return null;
            }

        }
        protected string getUneditableText(IWebElement element, string placeholder)
        {
            try
            {
                return getUneditableText(element).Remove(0, placeholder.Length);
            }
            catch
            {
                return null;
            }

        }
        protected string getDropDownText(IWebElement dropdown)
        {
            return getUneditableText(dropdown);
        }
        protected string getDropDownText(IWebElement dropdown, string placeholder, string placeholderend)
        {
            return getUneditableText(dropdown, placeholder);
        }
        protected string getCellText(IWebElement cell)
        {
            return getUneditableText(cell);
        }
        protected string getCellText(IWebElement cell, string placeholder, string placeholderend)
        {
            return getUneditableText(cell,placeholder,placeholderend);
        }


        public void waitSecond()
        {
            Thread.Sleep(1000);
        }
        public void waitSuggestOpen()
        {
            //ожидание саджеста, пока просто ожидание, так как логика саджеста будет описана позднее
            waitSecond();
            /*
            var wait = new WebDriverWait(pageManager.driver, TimeSpan.FromSeconds(PageManager.waitTime));
            wait.Until(d => d.FindElement(By.XPath("//div[contains(@class,'b-match ng-scope')]")));
            */

        }

        public virtual void waitSaveDone()
        {
            //ожидание плашки сохранения
            var wait = new WebDriverWait(pageManager.driver, TimeSpan.FromSeconds(PageManager.WAITTIMEFORFINDELEMENT));
            wait.Until(d => d.FindElement(By.ClassName("b-notification-content")));

        }
        protected void setStarsField(IWebElement webElement, int level)
        {
            //установка количества звезд
            if (level != 0)
            {
                ReadOnlyCollection<IWebElement> elements = webElement.FindElements(By.XPath(".//div[contains(@class,'b-control-ratings-star')]"));
                elements[level - 1].Click();
            }

        }
        protected int getStarsField(IWebElement webElement)
        {
            try
            {
                ReadOnlyCollection<IWebElement> elements = webElement.FindElements(By.XPath(".//div[contains(@class,'b-control-ratings-star--active')]"));
                return elements.Count;
            }
            catch
            {
                return 0;
            }

        }

        public void clearStarsField(IWebElement webElement)
        {
            ReadOnlyCollection<IWebElement> elements = webElement.FindElements(By.XPath(".//div[contains(@class,'b-control-ratings-star')]"));
            if (getStarsField(webElement) != 1)
            {
                elements[0].Click();
            }

            elements[0].Click();
        }

        protected void ClearManual(IWebElement webElement)
        {
            //очистка вручную
            webElement.SendKeys(Keys.Home);
            webElement.SendKeys(Keys.Shift + Keys.End);
            webElement.SendKeys(Keys.Delete);
            waitSecond();
        }

        public void clickFilter(IWebElement elementFilter)
        {
            elementFilter.Click();

        }
        public virtual List<IWebElement> GetFilters()
        {
            List<IWebElement> filters = new List<IWebElement>();

            return filters;

        }

        public void setFindFilter(IWebElement filter, string text)
        {
            ClearManual(filter);
            setTextField(filter, text);
        }

        public void setCheckBoxFilter(IWebElement filter, string status, string defaultstatus)
        {
            //общий метод установки фильтров с чекбоксами
            filter.Click();
            //*[@id="subheader_pane"]/div/div/div[1]/div/div/div/div[1]/span
            //   filter.FindElement(By.XPath(".//span[@class='ng-binding']")).Click();
            filter.FindElement(By.XPath("//label[text()='" + defaultstatus + "']")).Click();
            filter.FindElement(By.XPath("//label[text()='" + status + "']")).Click();
            filter.Click();

        }
        public void setCheckBoxDropDown(IWebElement filter, string status, string defaultstatus)
        {
            //общий метод установки фильтров с чекбоксами
            filter.Click();
            filter.FindElement(By.XPath("//label[text()='" + defaultstatus + "']")).Click();
            filter.FindElement(By.XPath("//label[text()='" + status + "']")).Click();
            filter.Click();

        }


        public List<string> getList(IWebElement elementList)
        {
            //получаем список элементов справочника 
            List<IWebElement> resultList = elementList.FindElements(By.XPath("//nav/ul/li")).ToList();
            //создаем список для получения текста из вебэлементов
            List<string> x = new List<string>();
            //наполняем список текстом
            foreach (IWebElement Element in resultList)
                x.Add(getUneditableText(Element));

            return x;
        }
        //Функция возвращает ячейку в таблице
        public IWebElement getCellByIndex(IWebElement table, int row, int col)
        {
            return table.FindElement(By.XPath(".//*[contains(@class,'b-table-row')][" + row + "]/div[" + col + "]"));
            // return table.FindElement(By.XPath("//div[@class = 'b-table-body']/div["+row+"]/div["+col+"]"));
        }
        public IWebElement getCellByText(IWebElement table, string text)
        {
            return table.FindElement(By.XPath("//*[contains(@class,'b-table-row')]//*[contains( text(), '" + text + "')]"));
            // return table.FindElement(By.XPath("//div[@class = 'b-table-body']/div["+row+"]/div["+col+"]"));
        }


        public void ensureUpdateTable()
        {
            //метод ожидания обновления таблицы
            //ждем появления спинера
            /* var wait1 = new WebDriverWait(pageManager.driver, TimeSpan.FromSeconds(PageManager.waitTime));
             wait1.Until(d => d.FindElement(By.XPath("//div[@class = 'b-ctrl_loader b-ctrl_loader--page_loader ng-isolate-scope' and  not(@style = 'display: none;')]")));
            */
            Thread.Sleep(2000);
            //ждем появления таблицы
            ensureTableLoaded();

        }
        public void ensureTableLoaded()
        {
            var wait = new WebDriverWait(pageManager.driver, TimeSpan.FromSeconds(PageManager.WAITTIMEFORFINDELEMENT));
            wait.Until(d => d.FindElement(By.ClassName("b-table-body")));

        }
        public void waitForFixPosition(IWebElement element)
        {
            try
            {
                Point prevLocation = new Point(0, 0);
                do
                {
                    prevLocation = element.Location;
                    Thread.Sleep(500);
                    Console.Out.WriteLine("prevLocation" + prevLocation);
                    Console.Out.WriteLine("element location" + element.Location);
                }
                while (!element.Location.Equals(prevLocation));

            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught. Проблемы с fix position", e);
            }
        }

        public void moveToHint(string id)
        {
            pageManager.driver.FindElement(By.XPath("//*[@common-tip-point = '" + id + "']"));

        }
        public Hint getHint(string id)
        {
            Hint testHint = new Hint();
            testHint.id = getUneditableText(pageManager.driver.FindElement(By.XPath("//*[@common-tip-point = '" + id + "']")));
            testHint.subject = getUneditableText(pageManager.driver.FindElement(By.XPath("//*[@common-tip-point = '" + id + "']")));
            testHint.message = getUneditableText(pageManager.driver.FindElement(By.XPath("//*[@common-tip-point = '" + id + "']")));
            return testHint;
        }
        public string getValidationMessage()
        {
            //Ожидание появления какого-нибудь валидатора
            var wait = new WebDriverWait(pageManager.driver, TimeSpan.FromSeconds(PageManager.WAITTIMEFORFINDELEMENT));
            wait.Until(d => d.FindElement(By.XPath("//div[@class = 'form-error-tooltip-msg']")));
            //Валидатор
            IWebElement Temp = pageManager.driver.FindElement(By.XPath("//div[@class = 'form-error-tooltip-msg']"));
            return Temp.Text;

        }
        public void setCheckBox(IWebElement element, bool state)
        {
            if (getCheckBox(element) != state)
            {
                element.Click();
            }

        }

        public bool getCheckBox(IWebElement element)
        {
            return element.Selected;
        }


    }
}
