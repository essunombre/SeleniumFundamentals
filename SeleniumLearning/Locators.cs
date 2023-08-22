using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumLearning
{
    internal class Locators
    {
        //Xpath Css, id, classname, name, tagname
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            //For Chrome ChromeDriver
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();

            //driver.Manage().Window.Maximize();
            //driver.Url = "https://thenew.selazar-labs.co.uk/";

            driver.Manage().Window.Maximize();
            driver.Url = "https://rahulshettyacademy.com/loginpagePractise/"; ;

            
        }
        [Test]
        public void LocatorsIdentification()
        {
            //driver.FindElement(By.Id("slz-custom-input")).SendKeys("Petro");
            //driver.FindElement(By.Id("slz-custom-input")).Clear();
            //driver.FindElement(By.Id("slz-custom-input")).SendKeys("francisco.torreglosa@outlook.com");
            //driver.FindElement(By.Name("password")).SendKeys("Password1*");
            //driver.FindElement(By.Id("SEL-Slz-Button168")).Click();

            TestContext.Progress.WriteLine(driver.Title);
            TestContext.Progress.WriteLine(driver.Url);
            driver.FindElement(By.Id("username")).SendKeys("rahulshettyacademy");
            driver.FindElement(By.Id("username")).Clear();
            driver.FindElement(By.Id("username")).SendKeys("rahulshetty");
            driver.FindElement(By.Name("password")).SendKeys("123456");

            //xpath 
            driver.FindElement(By.XPath("//input[@id='terms']")).Click();
            //css selector
            driver.FindElement(By.CssSelector("input[id='signInBtn']")).Click();

            //driver.Close(); //only one window
            //driver.Quit(); //2windows

        }
    }
}
