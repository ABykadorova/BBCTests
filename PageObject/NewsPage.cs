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
    public class NewsPage
    {
        private IWebDriver driver;
        
        public NewsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//span[text()='More']")] 
        private IWebElement _moreButton;
        [FindsBy(How = How.XPath, Using = "//div[@class='nw-c-nav__wide-overflow-list gel-layout']//a//span[text()='Have Your Say']")] 
        private IWebElement _haveYourSayButton;

        public NewsPage ClickMoreButton()
        {
            _moreButton.Click();
            return new NewsPage(driver);
        }

        public HaveYourSayPage GoToHaveYourSayPage()
        {
            _haveYourSayButton.Click();
            return new HaveYourSayPage(driver);
        }
    }
}
