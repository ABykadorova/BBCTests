using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using BBC1_task2.PageObject;
using System.Collections.Generic;

namespace BBC1_task2
{
    public class Tests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }
    
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void TestWithAnOneMoreCharacterInForm() => new Task2tests(driver).FillInTheFormWithAnOneMoreCharacter();

        [Test]
        public void TestWithAnEmptyName() => new Task2tests(driver).FillInTheFormWithAnEmptyName();

        [Test]
        public void TestWithAnEmptyEmailAddress() => new Task2tests(driver).FillInTheFormWithAnEmptyEmailAddress();

        [Test]
        //this test shoud always fail, since we didn’t press Submit  
        public void ValidTestWithAllCorrectFields() => new Task2tests(driver).ValidTestWithAllCorrectFieldsWithoutClickingSubmitButton();
    }
}  