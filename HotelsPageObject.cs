using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class HotelsPageObject
    {
        IWebDriver _driver;

        public HotelsPageObject(IWebDriver driver)
        {
            _driver = driver;
        }

        public void SortInAscending()
        {
            _driver.FindElement(By.XPath("//span[text()='По возрастанию цены']")).Click();
        }
    }
}
