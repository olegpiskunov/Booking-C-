using OpenQA.Selenium;


namespace SeleniumTestProject
{
    class PageObjects
    {
        private static IWebElement element = null;

        //private static IWebDriver driver = null;

        //private static WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));


        public static IWebElement GetSearchCity(IWebDriver driver)
        {
            //return element = wait.Until(x => x.FindElement(By.Id("ss")));

            return element = driver.FindElement(By.Id("ss"));
        }


        public static IWebElement GetSelectDate(IWebDriver driver)
        {
            //IWebElement selectDate = wait.Until(x => x.FindElement(By.XPath("//button[@type='button']")));

            return element = driver.FindElement(By.XPath("//button[@type='button']"));
        }


        public static IWebElement GetChoseTheDate(IWebDriver driver)
        {
            //IWebElement choseTheDate = wait.Until(x => x.FindElement(By.XPath(".//*[@id='frm']/div[1]/div[2]/div[2]/div/div/div[3]/div[1]/table/tbody/tr[6]/td[7]")));

            return element = driver.FindElement(By.XPath(".//*[@id='frm']/div[1]/div[2]/div[2]/div/div/div[3]/div[2]/table/tbody/tr[5]/td[6]"));
        }


        public static IWebElement GetChoseTheSecondDate(IWebDriver driver)
        {
            //IWebElement choseTheSecondDate = wait.Until(x => x.FindElement(By.XPath(".//*[@id='frm']/div[1]/div[2]/div[2]/div/div/div[3]/div[1]/table/tbody/tr[7]/td[2]")));

            return element = driver.FindElement(By.XPath(".//*[@id='frm']/div[1]/div[2]/div[2]/div/div/div[3]/div[2]/table/tbody/tr[6]/td[1]"));
        }


        public static IWebElement GetGuestNumber(IWebDriver driver)
        {
            //IWebElement guestNumber = wait.Until(x => x.FindElement(By.Id("xp__guests__toggle"))); 

            return element = driver.FindElement(By.Id("xp__guests__toggle"));
        }


        public static IWebElement GetKids(IWebDriver driver)
        {
            //IWebElement kids = wait.Until(x => x.FindElement(By.XPath(".//*[@id='group_children']")));

            return element = driver.FindElement(By.XPath(".//*[@id='group_children']"));
        }


        public static IWebElement GetKidsNumbers(IWebDriver driver)
        {
            //IWebElement kidsNumbers = wait.Until(x => x.FindElement(By.XPath(".//*[@id='group_children']/option[2]")));

            return element = driver.FindElement(By.XPath(".//*[@id='group_children']/option[2]"));
        }

        public static IWebElement GetDropDownAge(IWebDriver driver)
        {
            //IWebElement dropDownAge = wait.Until(x => x.FindElement(By.XPath(".//*[@id='frm']/div[1]/div[3]/div[2]/div/div/div[4]/select")));

            return element = driver.FindElement(By.XPath(".//*[@id='frm']/div[1]/div[3]/div[2]/div/div/div[4]/select"));
        }

        public static IWebElement GetKidsAge(IWebDriver driver)
        {
            //IWebElement kidsAge = wait.Until(x => x.FindElement(By.XPath(".//*[@id='frm']/div[1]/div[3]/div[2]/div/div/div[4]/select/option[5]")));
            return element = driver.FindElement(By.XPath(".//*[@id='frm']/div[1]/div[3]/div[2]/div/div/div[4]/select/option[5]"));
        }

        public static IWebElement GetKid(IWebDriver driver)
        {
            //IWebElement kid = wait.Until(x => x.FindElement(By.XPath(".//*[@id='frm']/div[1]/div[3]/div[2]/div/div/div[3]/div/div[2]/button[2]")));

            return element = driver.FindElement(By.XPath(".//*[@id='frm']/div[1]/div[3]/div[2]/div/div/div[3]/div/div[2]/button[2]"));
        }


        public static IWebElement GetKidNumbers(IWebDriver driver)
        {
            //IWebElement kidNumbers = wait.Until(x => x.FindElement(By.XPath(".//*[@id='frm']/div[1]/div[3]/div[2]/div/div/div[4]/select")));

            return element = driver.FindElement(By.XPath(".//*[@id='frm']/div[1]/div[3]/div[2]/div/div/div[4]/select"));
        }


        public static IWebElement GetDropAge(IWebDriver driver)
        {
            //IWebElement dropAge = wait.Until(x => x.FindElement(By.XPath(".//*[@id='frm']/div[1]/div[3]/div[2]/div/div/div[4]/select/option[5]")));

            return element = driver.FindElement(By.XPath(".//*[@id='frm']/div[1]/div[3]/div[2]/div/div/div[4]/select/option[5]"));
        }

        public static IWebElement GetBtnSearch(IWebDriver driver)
        {
            //IWebElement btnSearch = wait.Until(x => x.FindElement(By.XPath("//button[@type='submit']")));

            return element = driver.FindElement(By.XPath("//button[@type='submit']"));
        }

        public static IWebElement GetTxbParking(IWebDriver driver)
        {
            //IWebElement txbParking = wait.Until(x => x.FindElement(By.XPath(".//*[@id='filterbox_options']/div/div[3]/div[2]/a[1]/div")));

            return element = driver.FindElement(By.XPath(".//*[@id='filterbox_options']/div/div[3]/div[2]/a[1]/div"));
        }

        public static IWebElement GetTxbBreakfast(IWebDriver driver)
        {
            //IWebElement txbBreakfast = wait.Until(x => x.FindElement(By.XPath(".//*[@id='filterbox_options']/div/div[3]/div[2]/a[2]/div")));

            return element = driver.FindElement(By.XPath(".//*[@id='filterbox_options']/div/div[3]/div[2]/a[2]/div"));
        }

        public static IWebElement GetLowerPrice(IWebDriver driver)
        {
            //IWebElement lowerPrice = wait.Until(x => x.FindElement(By.XPath(".//*[@id='sort_by']/ul/li[2]/a")));

            return element = driver.FindElement(By.XPath(".//*[@id='sort_by']/ul/li[2]/a"));
        }

        public static IWebElement GetSeeAvailability(IWebDriver driver)
        {
            //IWebElement seeAvailability = wait.Until(x => x.FindElement(By.XPath(".//*[@id='hotellist_inner']/div[1]/div[2]/div[3]/div/div[3]/div/div/div/a/span")));

            return element = driver.FindElement(By.XPath(".//*[@id='hotellist_inner']/div[1]/div[2]/div[3]/div/div[3]/div/div/div/a/span"));
        }


        public static IWebElement GetSaveProperty(IWebDriver driver)
        {
            //IWebElement saveProperty = wait.Until(x => x.FindElement(By.XPath(".//*[@id='top-book']/button[2]")));

            return element = driver.FindElement(By.XPath(".//*[@id='top-book']/button[2]"));
        }

        public static IWebElement GetGoList(IWebDriver driver)
        {
            //IWebElement goList = wait.Until(x => x.FindElement(By.XPath(".//*[@id='hotel-wishlists']/label/span[2]/a")));

            return element = driver.FindElement(By.XPath(".//*[@id='hotel-wishlists']/label/span[2]/a"));
        }

    }
}
