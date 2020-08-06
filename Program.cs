using System;
using System.Threading;
using Docker.DotNet.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using Telerik.JustMock;

namespace SeleniumProj1
{
    class Selenium1
    {
        [Obsolete]
        static void Main(string[] args)
        {
           //1.  Go to Bing and searching "rediffmail" in the Search box
            
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.bing.com/?PC=YA03";

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(10);

            //Creating an Object named 'Search' and assigning the Search box element to it.
            IWebElement Search = driver.FindElement(By.Id("sb_form_q"));
            Search.SendKeys("rediffmail");
            Search.SendKeys(Keys.Enter);


            Console.WriteLine("PAge opened successfully");

            //2. Go to Graphnet website 
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            driver.Url = "https://www.graphnet.com/";

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            IWebElement Graphnet = driver.FindElement(By.LinkText("Graphnet#"));
            Graphnet.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement About = driver.FindElement(By.Id("menu-item-420"));
            About.Click();

            IWebElement Solutions = driver.FindElement(By.Id("menu-item-416"));
            Solutions.Click();

            IWebElement DataWarehouse = driver.FindElement(By.Id("menu-item-417"));
            DataWarehouse.Click();

            IWebElement Timeline = driver.FindElement(By.Id("menu-item-415"));
            Timeline.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            IWebElement Clients = driver.FindElement(By.Id("menu-item-419"));
            Clients.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            IWebElement Contact = driver.FindElement(By.Id("menu-item-418"));
            Contact.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);


            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            var Translate = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("dropdown-toggle")));
            Actions Hover = new Actions(driver);
            Hover.MoveToElement(Translate).Perform();
            //Waiting for the menu to be displayed    

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);



            IWebElement English = driver.FindElement(By.LinkText("English"));
            English.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            var Translatelink = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("dropdown-toggle")));
            Actions Hover2 = new Actions(driver);
            Hover2.MoveToElement(Translatelink).Perform();
            //Waiting for the menu to be displayed    

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            IWebElement Francais = driver.FindElement(By.LinkText("Français"));
            Francais.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            Console.WriteLine("Graphnet PAge also opened successfully");

        }
    }
}
