using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumLearning
{
    internal class SeleniumFirst
    {
        IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            //Chrome driver is naned chrome.exe            
            //new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            //driver = new ChromeDriver();

            //Firefox driver is named geckodriver
            //new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            //driver = new FirefoxDriver();

            //Edge driver is named Edgedriver
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            driver = new EdgeDriver();


            //to maximize window:
            driver.Manage().Window.Maximize();



        }

        [Test]
        public void Test1()
        {
            //https://rahulshettyacademy.com/loginpagePractise/
            driver.Url = "https://thenew.selazar-labs.co.uk/";
            TestContext.Progress.Write("Title of the page!");
            TestContext.Progress.WriteLine(driver.Title);
            TestContext.Progress.WriteLine("URL being used:");
            TestContext.Progress.WriteLine(driver.Url);
            //driver.Close(); //close the original window open
            //driver.Quit(); //all windows get close


        }
    }
}
