using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium.Internal;
using SeleniumExtras.PageObjects;
using Test_question_to_BBC;


namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.BinaryLocation = "/Applications/Google Chrome 2.app/Contents/MacOS/Google Chrome";
            IWebDriver driver = new ChromeDriver("/Users/Iro4ka/Projects/T1/T1/", chromeOptions);

            PageHome pageHome = new PageHome(driver);
            BBC_Homepage bBC_Homepage = new BBC_Homepage(driver);
            PageFactory.InitElements(driver, pageHome);
            //Lorem Ipsum
            string[] lipsums = pageHome.generateLipsums();

            PageFactory.InitElements(driver, bBC_Homepage);
            driver.Navigate().GoToUrl("https://www.bbc.com/");
            bBC_Homepage.goToNews.Click();
            bBC_Homepage.goToMore.Click();
            bBC_Homepage.goToHaveYourSay.Click();
            bBC_Homepage.goToDoYouHaveAQuestion.Click();
            bBC_Homepage.fillQuestionTextarea.Click();
            bBC_Homepage.fillQuestionTextarea.SendKeys(lipsums[1]);
            bBC_Homepage.fillNameInput.Click();
            bBC_Homepage.fillNameInput.SendKeys("Iryna");
            bBC_Homepage.fillEmailInput.Click();
            bBC_Homepage.fillEmailInput.SendKeys("loripsum@gmail.com");
            bBC_Homepage.fillAgeInput.Click();
            bBC_Homepage.fillAgeInput.SendKeys("20");
            bBC_Homepage.fillPostcodeInput.Click();
            bBC_Homepage.fillPostcodeInput.SendKeys("02000");

        }
        [Test]
        public void Test2()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.BinaryLocation = "/Applications/Google Chrome 2.app/Contents/MacOS/Google Chrome";
            IWebDriver driver = new ChromeDriver("/Users/Iro4ka/Projects/T1/T1/", chromeOptions);

            PageHome pageHome = new PageHome(driver);
            BBC_Homepage bBC_Homepage = new BBC_Homepage(driver);
            PageFactory.InitElements(driver, pageHome);
            string[] lipsums = pageHome.generateLipsums();

            driver.Navigate().GoToUrl("https://www.bbc.com/");
            bBC_Homepage.goToNews.Click();
            bBC_Homepage.goToMore.Click();
            bBC_Homepage.goToHaveYourSay.Click();
            bBC_Homepage.goToDoYouHaveAQuestion.Click();
            bBC_Homepage.fillQuestionTextarea.Click();
            bBC_Homepage.fillQuestionTextarea.SendKeys(lipsums[0]);
            bBC_Homepage.fillNameInput.Click();
            bBC_Homepage.fillEmailInput.Click();
            bBC_Homepage.fillEmailInput.SendKeys("loripsum@gmail.com");
            bBC_Homepage.fillAgeInput.Click();
            bBC_Homepage.fillAgeInput.SendKeys("20");
            bBC_Homepage.fillPostcodeInput.Click();
            bBC_Homepage.fillPostcodeInput.SendKeys("02000");
        }
    }
    
}
