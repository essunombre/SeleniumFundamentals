using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.UI;

namespace SeleniumLearning
{
    internal class FunctionalTest
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            //For Chrome ChromeDriver
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.Manage().Window.Maximize();
            driver.Url = "https://rahulshettyacademy.com/loginpagePractise/"; ;


        }
        [Test]
        public void dropdown()
        {
            IWebElement dropdown =  driver.FindElement(By.CssSelector("select.form-control"));

            SelectElement s = new SelectElement(dropdown);
            s.SelectByIndex(1);
            //s.SelectByValue("teach");
            //s.SelectByText("Teacher");
        }

    }
}
