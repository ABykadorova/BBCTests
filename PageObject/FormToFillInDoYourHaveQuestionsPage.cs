using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BBC1_task2.PageObject
{
    public class FormToFillInDoYourHaveQuestionsPage
    {
        private IWebDriver driver;
        public FormToFillInDoYourHaveQuestionsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        
        private IWebElement formField(string field) => driver.FindElement(By.XPath($"//*[@placeholder='{field}']"));
                   
        public void  Fillform(Dictionary<string, string> FormToFill)
        {
            foreach (var key in FormToFill.Keys)
                formField(key).SendKeys(FormToFill[key]);
        }

    } 
}
