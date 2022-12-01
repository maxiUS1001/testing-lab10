using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;

namespace lab9
{
    public class Tests
    {
        IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            _driver = new EdgeDriver();
            _driver.Navigate().GoToUrl("https://www.agoda.com/ru-ru/?cid=1844104");
            _driver.Manage().Window.Maximize();
        }

        [Test]
        public void SearchForFlightToParisFromVilnius()
        {
            var mainMenu = new MainPageObject(_driver);

            mainMenu.GoToAirticketsPage().SearchForFlights();
        }

        [Test]
        public void SortHotelsPriceInAscendingOrder()
        {
            var mainMenu = new MainPageObject(_driver);

            mainMenu.SearchForHotels().SortInAscending();
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}