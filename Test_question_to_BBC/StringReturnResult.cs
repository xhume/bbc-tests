using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium.Internal;
using SeleniumExtras.PageObjects;
using Test_question_to_BBC;

namespace Test_question_to_BBC
{
    public class StringReturnResult
    {
        public IWebDriver driver;

        public StringReturnResult(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        
    }
}
