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
    }
}
