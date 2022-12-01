using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class MainPageObject
    {
        IWebDriver _driver;

        public MainPageObject(IWebDriver driver)
        {
            _driver = driver;
        }

        public AirticketsPageObject GoToAirticketsPage()
        {
            _driver.FindElement(By.XPath("//span[text()='Авиабилеты']")).Click();

            return new AirticketsPageObject(_driver);
        }

        public HotelsPageObject SearchForHotels()
        {
            _driver.FindElement(By.XPath("//*[@id='textInput']")).SendKeys("Торревьеха");

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.FindElement(By.XPath("//span[text()='Торревьеха']")).Click();

            _driver.FindElement(By.XPath("//p[text()='1 ночь']")).Click();

            _driver.FindElement(By.XPath("//*[@id='SearchBoxContainer']/div[2]/button")).Click();

            return new HotelsPageObject(_driver);
        }
    }
}
