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
    class Task2tests
    {
        private readonly IWebDriver driver;

        public Task2tests(IWebDriver driver) => this.driver = driver;

        private void TheSameClicksForAllTests() => new BBCHomePage(driver).GoToBBCPage().GoToNewsPage().ClickMoreButton().GoToHaveYourSayPage().GoToDoYouHaveQuestionsPage();

        private void ClickSubmitToHaveAnErrorMessage()
        {
             DoYouHaveQuestionsPage doYouHaveQuestions = new DoYouHaveQuestionsPage(driver);
             doYouHaveQuestions.Submit();
             doYouHaveQuestions.ErrorMessage(); 
        }
    
        public void FillInTheFormWithAnOneMoreCharacter()
        {
            var FormToFill = new Dictionary<string, string>()
            {
               { "What questions would you like us to investigate?", 
                "We're particularly interested in hearing from you if you have a question about gaming you'd like us to answer. " +
                "Let us know by sending us you."},
               { "Name", "Anastasiia"},
               { "Age", "21"},
               { "Postcode", "03058"},
            };

            TheSameClicksForAllTests();
            DoYouHaveQuestionsPage doYouHaveQuestions = new DoYouHaveQuestionsPage(driver);     
            FormToFillInDoYourHaveQuestionsPage form = new FormToFillInDoYourHaveQuestionsPage(driver);
            form.Fillform(FormToFill);
            ClickSubmitToHaveAnErrorMessage();
        }

        public void FillInTheFormWithAnEmptyName()
        {
            var FormToFill = new Dictionary<string, string>()
            {
               { "What questions would you like us to investigate?", "Many important questions"},
               { "Email address", "Anastasiia@gmail.com"},
               { "Age", "21"},
               { "Postcode", "03058"},
            };
                        
            TheSameClicksForAllTests();
            DoYouHaveQuestionsPage doYouHaveQuestions = new DoYouHaveQuestionsPage(driver);
            FormToFillInDoYourHaveQuestionsPage form = new FormToFillInDoYourHaveQuestionsPage(driver);
            form.Fillform(FormToFill);
            ClickSubmitToHaveAnErrorMessage();
        }

        public void FillInTheFormWithAnEmptyEmailAddress()
        {
            var FormToFill = new Dictionary<string, string>()
            {
               { "What questions would you like us to investigate?", "Many important questions"},
               { "Name", "Anastasiia"},
               { "Age", "21"},
               { "Postcode", "03058"},
            };

            TheSameClicksForAllTests();
            DoYouHaveQuestionsPage doYouHaveQuestions = new DoYouHaveQuestionsPage(driver);
            FormToFillInDoYourHaveQuestionsPage form = new FormToFillInDoYourHaveQuestionsPage(driver);
            form.Fillform(FormToFill);
            ClickSubmitToHaveAnErrorMessage();
        }

        public void ValidTestWithAllCorrectFieldsWithoutClickingSubmitButton()
        {
            var FormToFill = new Dictionary<string, string>()
            {
               { "What questions would you like us to investigate?", "Many important questions"},
               { "Name", "Anastasiia"},
               { "Email address", "Anastasiia@gmail.com"},
               { "Age", "21"},
               { "Postcode", "03058"},
            };

            TheSameClicksForAllTests();
            DoYouHaveQuestionsPage doYouHaveQuestions = new DoYouHaveQuestionsPage(driver);
            FormToFillInDoYourHaveQuestionsPage form = new FormToFillInDoYourHaveQuestionsPage(driver);
            form.Fillform(FormToFill);
            doYouHaveQuestions.GetURL();
        }
    }
}
