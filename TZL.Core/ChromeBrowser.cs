using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TZL.Core
{
    class ChromeBrowser
    {
        private static ChromeBrowser _instance;

        public static ChromeBrowser Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = Activator.CreateInstance<ChromeBrowser >();
                }

                return _instance;
            }
        }

        // This is to control security/cookies for chrome when u are logging in etc
        public IWebDriver GetDriver()
        {
            ChromeOptions options = new ChromeOptions();

            options.AddArguments("disable-infobars");
            options.AddArguments("--disable-web-security");
            options.AddArguments("--disable-infobars");
            options.AddArguments("--allow-running-insecure-contect");

            return new ChromeDriver(options);
        }
    }
}
