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
    public class DoYouHaveQuestionsPage
    {
        private IWebDriver driver;

        public DoYouHaveQuestionsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//button[@class='button']")]
        private IWebElement _submitButton;
        [FindsBy(How = How.XPath, Using = "//*[@class='input-error-message']")]
        private IWebElement _errorMessage;

        public void GetURL() => Assert.AreNotEqual("https://www.bbc.com/news/uk-47933096", driver.Url); 

        public void Submit() => _submitButton.Click();

        public void ErrorMessage()
        {
            bool visible = _errorMessage.Displayed;
            Assert.IsTrue(visible); 
        }
      
    }
}

