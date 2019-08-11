using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium.Internal;
using SeleniumExtras.PageObjects;
using Test_question_to_BBC;

namespace Test_question_to_BBC
{
    public class BBC_Homepage
    {
        public IWebDriver driver;

        public BBC_Homepage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='orb-nav-links']/ul/li[2]/a")]
        public IWebElement goToNews { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='gel-long-primer gs-u-ph']")]
        public IWebElement goToMore { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='orb-modules']/header/div[2]/div/div[2]/div/div/ul[4]/li/a")]
        public IWebElement goToHaveYourSay { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='topos-component']/div[4]/div/div[1]/div/div[1]/div/div[2]/div[1]/a")]
        public IWebElement goToDoYouHaveAQuestion { get; set; } 

        [FindsBy(How = How.XPath, Using = "//*[@id='hearken-embed-module-3252-1a6b9-0']")]
        public IWebElement fillQuestionTextarea { get; set; }

        [FindsBy(How = How.XPath, Using = "(.//*[@class='text-input__input'])[1]")]
        public IWebElement fillNameInput { get; set; }

        [FindsBy(How = How.XPath, Using = "(.//*[@class='text-input__input'])[2]")]
        public IWebElement fillEmailInput { get; set; }

        [FindsBy(How = How.XPath, Using = "(.//*[@class='text-input__input'])[3]")]
        public IWebElement fillAgeInput { get; set; }

        [FindsBy(How = How.XPath, Using = "(.//*[@class='text-input__input'])[4]")]
        public IWebElement fillPostcodeInput { get; set; }

    }
}
