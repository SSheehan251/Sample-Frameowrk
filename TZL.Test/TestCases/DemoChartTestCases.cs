using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TZL.Core;
using TZL.Repository;
using NUnit.Framework;


namespace TZL.Test.TestCases
{
    class DemoChartTestCases : BaseTest
    {
        [Test]
        public void VerifyItemsCanbeSearchedInSearchItemsTextBox()
        {
            try
            {
                LogMessage("Navigate To URL", () => NavigateToUrl("https://demostore.x-cart.com/", Driver));

                var pgDemoChart = Page<DemoChart>(Driver);

                LogMessage("Invoking Search Items Method", () => pgDemoChart.SearchItems("IPhone", "Android"));

                LogMessage("Close Browser", () => CloseBrowser(Driver));
            }

            catch (Exception)
            {
                LogMessage("CloseBrowser Browser", () => CloseBrowser(Driver));
            }
        }

    }


    

    }

