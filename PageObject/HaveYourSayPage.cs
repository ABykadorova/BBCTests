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
    public class HaveYourSayPage
    {
        private IWebDriver driver;

        public HaveYourSayPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@href='/news/uk-47933096']")] 
        private IWebElement _doYouHaveQuestionsButton;

        public DoYouHaveQuestionsPage GoToDoYouHaveQuestionsPage()
        {
            _doYouHaveQuestionsButton.Click();
            return new DoYouHaveQuestionsPage(driver);
        }
    }
}

