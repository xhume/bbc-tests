using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium.Internal;
using SeleniumExtras.PageObjects;
using Test_question_to_BBC;

namespace Test_question_to_BBC
{
    public class PageHome
    {
        public IWebDriver driver;

        public PageHome(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//input")]
        public IWebElement valueInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Panes']/div[4]/form/table/tbody/tr[1]/td[2]/table/tbody/tr[3]/td[1]")]
        public IWebElement bytesLabel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='generate']")]
        public IWebElement generateInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='lipsum']/p")]
        public IWebElement getLipsum { get; set; }

        public string[] generateLipsums()
        {
            //Lorem Ipsum
            this.driver.Navigate().GoToUrl("https://www.lipsum.com/");
            this.valueInput.Click();
            //Console.WriteLine("1");
            this.valueInput.Clear();
            //Console.WriteLine("2");
            this.valueInput.SendKeys("141");
            //Console.WriteLine("3");
            this.bytesLabel.Click();
            //Console.WriteLine("4");
            this.generateInput.Click();
            //Console.WriteLine("5");
            string lipsumFull = this.getLipsum.Text;
            //Console.WriteLine("Text: " + lipsumFull);
            return new string[] { lipsumFull, lipsumFull.Substring(0, lipsumFull.Length - 1)};
        }


    }
}
