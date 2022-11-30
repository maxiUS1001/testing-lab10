using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class AirticketsPageObject
    {
        IWebDriver _driver;

        public AirticketsPageObject(IWebDriver driver)
        {
            _driver = driver;
        }   

        public void SearchForFlights()
        {
            _driver.FindElement(By.XPath("//span[text()='One-way']")).Click();

            _driver.FindElement(By.XPath("//input[@name='origin']")).Clear();
            _driver.FindElement(By.XPath("//input[@name='origin']")).SendKeys("Vilnius(VNO)");

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.FindElement(By.XPath("//*[@id='ap-VNO/7110']/div[2]")).Click();

            _driver.FindElement(By.XPath("//input[@name='destination']")).SendKeys("Paris (PAR)");

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.FindElement(By.XPath("//*[@id='ap-PAR/36014']/div[2]")).Click();

            _driver.FindElement(By.XPath("//div[text()='Depart']")).Click();

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.FindElement(By.XPath("//div[@aria-label='December 14']")).Click();

            _driver.FindElement(By.XPath("//span[text()='Search']")).Click();
        }
    }
}
