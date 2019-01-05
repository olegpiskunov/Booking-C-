using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Linq;


namespace SeleniumTestProject
{
    [TestFixture()]
    public class Test
    {

        IWebDriver driver;
        readonly string url = "https://www.booking.com/";

      
        [SetUp]
        public void TestSetup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            // Tell webdriver to wait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        }



        [Test()]
        public void Search()
        {
            Assert.IsTrue(PageObjects.GetSearchCity(driver).Displayed);
            PageObjects.GetSearchCity(driver).Clear();
            PageObjects.GetSearchCity(driver).SendKeys("Boston");


            //Get Today's number
            string today = System.DateTime.Today.ToString("dd/MM/yy");
            Console.WriteLine("Date :{0}", today);


            //Click and open the datepickers
            Assert.IsTrue(PageObjects.GetSelectDate(driver).Displayed);
            PageObjects.GetSelectDate(driver).Click();


            //choose in date
            Assert.IsTrue(PageObjects.GetChoseTheDate(driver).Displayed);
            PageObjects.GetChoseTheDate(driver).Click();


            //choose out date
            Assert.IsTrue(PageObjects.GetChoseTheSecondDate(driver).Displayed);
            PageObjects.GetChoseTheSecondDate(driver).Click();


            //choose number of guests
            Assert.IsTrue(PageObjects.GetGuestNumber(driver).Displayed);
            PageObjects.GetGuestNumber(driver).Click();

          
            try
            {
                //choose children
                Assert.IsTrue(PageObjects.GetKids(driver).Enabled);
                PageObjects.GetKids(driver).Click();

                //choose children numbers
                Assert.IsTrue(PageObjects.GetKidsNumbers(driver).Displayed);
                PageObjects.GetKidsNumbers(driver).Click();


                //click on children age dropdown
                Assert.IsTrue(PageObjects.GetDropDownAge(driver).Displayed);
                PageObjects.GetDropDownAge(driver).Click();


                //choose children age from dropdown
                Assert.IsTrue(PageObjects.GetKidsAge(driver).Displayed);
                PageObjects.GetKidsAge(driver).Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("IOException source: {0}", ex.Source);

                //choose children
                Assert.IsTrue(PageObjects.GetKid(driver).Displayed);
                PageObjects.GetKid(driver).Click();

                //choose children numbers
                Assert.IsTrue(PageObjects.GetKidNumbers(driver).Displayed);
                PageObjects.GetKidNumbers(driver).Click();

                //choose children age from dropdown
                Assert.IsTrue(PageObjects.GetDropAge(driver).Displayed);
                PageObjects.GetDropAge(driver).Click();
            }


            //click on search button
            Assert.IsTrue(PageObjects.GetBtnSearch(driver).Displayed);
            PageObjects.GetBtnSearch(driver).Click();


            //scroll to parking and breakfast checkmark
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(1000);

            //click on parking textbox
            Assert.IsTrue(PageObjects.GetTxbParking(driver).Displayed);
            PageObjects.GetTxbParking(driver).Click();



            //click on breakfast textbox
            Assert.IsTrue(PageObjects.GetTxbBreakfast(driver).Displayed);
            PageObjects.GetTxbBreakfast(driver).Click();



            //click on Price(lowest first)
            js.ExecuteScript("window.scrollBy(0,0)");
            Assert.IsTrue(PageObjects.GetLowerPrice(driver).Displayed);
            PageObjects.GetLowerPrice(driver).Click();


            Thread.Sleep(4000);
            //click on See availability button
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Assert.IsTrue(PageObjects.GetSeeAvailability(driver).Displayed);
            PageObjects.GetSeeAvailability(driver).Click();


            //Handle the second opened tab
            driver.SwitchTo().Window(driver.WindowHandles[0]).Close();
            driver.SwitchTo().Window(driver.WindowHandles.Last()); 



            //click on save the property button
            Assert.IsTrue(PageObjects.GetSaveProperty(driver).Displayed);
            PageObjects.GetSaveProperty(driver).Click();


            //go to the list
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Assert.IsTrue(PageObjects.GetGoList(driver).Displayed);
            PageObjects.GetGoList(driver).Click();


            //Handle the second opened tab
            driver.SwitchTo().Window(driver.WindowHandles[0]).Close();
            driver.SwitchTo().Window(driver.WindowHandles.Last());

            //check if the property added 
            Assert.AreEqual("Booking.com: Lists", driver.Title);

            Thread.Sleep(4000);
        }

        [TearDown]
        public void Cleanup()
        {
            driver.Close();
            driver.Quit();
        }


        public void SwitchTo(string prefix)
        {
            System.Collections.ObjectModel.ReadOnlyCollection<string> handlers = driver.WindowHandles;

            foreach (var handler in handlers)
            {
                driver.SwitchTo().Window(handler);
                if (driver.Url.Contains(prefix)) return;
            }
        }
    }
}
