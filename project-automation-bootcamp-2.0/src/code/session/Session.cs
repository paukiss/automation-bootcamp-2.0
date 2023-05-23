using OpenQA.Selenium;
using project_automation_bootcamp_2._0.src.code.browser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_automation_bootcamp_2._0.src.code.session
{
    public class Session
    {
        private static Session instance = null;
        private IWebDriver browser;

        private Session()
        {
            browser = FactoryBrowser.Make("chrome").Create();
        }

        public static Session Instance()
        {
            if (instance == null)
            {
                instance = new Session();
            }

            return instance;
        }

        public void CloseBrowser()
        {
            instance = null;
            browser.Quit();
        }

        public IWebDriver GetBrowser()
        {
            return browser;
        }

    }
}
