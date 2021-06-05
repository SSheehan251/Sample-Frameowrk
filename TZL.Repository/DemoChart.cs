using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TZL.Core;

namespace TZL.Repository
{
    public class DemoChart : BasePage
    {
        readonly IWebDriver _driver = null;
        
        
        #region Constructor

        public DemoChart(IWebDriver driver)
        {
            _driver =_driver;
        }

        #endregion

        #region Object Repository

        private IWebElement SearchTestItems => _driver.css("input[placeholder='Searchitems...'] ");

        private IList<IWebElement> HotDealsLink =>_driver.Allcss(".primary-title");

        private IWebElement Sale => _driver.LinkText("Sale");

        private IWebElement iphone => _driver.LinkText("Search Powerd by CLoudSearch");

        private IWebElement Android => _driver.LinkText("Search Powerd by CLoudSearch");

        #endregion

        #region Test Case Methods

        public void SearchItems(string value1, string value2)
        {
            LogMessage("Entering a Value into Search Items Text Box", () => Input(SearchTestItems, value1));
            LogMessage("Validating if Iphones are visible", () => AssertIsTrue(iphone.Displayed));
            LogMessage("Entering a Value into Search Items Text Box", () => ClearAndInput(SearchTestItems, value2));
            LogMessage("Validating if Android are visible", () => AssertIsTrue(Android.Displayed));
        }

        

        public void HotDeals()
        {
            LogMessage("Mouse Hover On Hot Deals Text", () => MouseHover(HotDealsLink[1],_driver));

            LogMessage("Click OnSale Text", () => Click(Sale));
        }

        #endregion
    }
}
