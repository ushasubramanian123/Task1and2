using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Task1
{
    public class Tests
    {
        IWebDriver driver;
        IWebElement searchTextBox;
        IWebElement searchButton;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Window.Maximize();
            //search by name
            //searchTextBox = driver.FindElement(By.Name("q"));
            //search using xpath with class name
            searchTextBox = driver.FindElement(By.XPath("//input[@class='gLFyf gsfi']"));
            searchTextBox.SendKeys("India");
            searchTextBox.SendKeys(Keys.Tab);
            searchButton = driver.FindElement(By.XPath("//div[@class='FPdoLc lJ9FBc']//input[@value='Google Search']"));
            searchButton.Click();
            Assert.Pass();
        }
    }
}