using System;
using System.Collections.Generic;
using System.Text;
using SeleniumExtras;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;

namespace BBC1_task2.PageObject
{
    public class BBCHomePage
    {
        private IWebDriver driver;

        public BBCHomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'News')]")]
        private IWebElement _newsButton;

        public BBCHomePage GoToBBCPage()
        {
            driver.Navigate().GoToUrl("https://www.bbc.com");
            return new BBCHomePage(driver);
        }

        public NewsPage GoToNewsPage()
        {
            _newsButton.Click();
            return new NewsPage(driver);
        }
    }
}
