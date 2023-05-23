using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using project_automation_bootcamp_2._0.src.code.session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_automation_bootcamp_2._0.src.code.control
{
    public class ControlSelenium
    {
        protected By locator;
        protected IWebElement control;

        public ControlSelenium(By locator)
        {
            this.locator = locator;
        }

        protected void FindControl()
        {
            control = Session.Instance().GetBrowser().FindElement(locator);
        }

        public void Click()
        {
            FindControl();
            control.Click();
        }

        public Boolean IsControlDisplayed()
        {
            try
            {
                FindControl();
                return control.Displayed;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public string GetText()
        {
            FindControl();
            return control.Text;
        }

        public void waitControlIsNotVisibleElement()
        {
            WebDriverWait explicitWait = new WebDriverWait(Session.Instance().GetBrowser(), TimeSpan.FromSeconds(10));
            explicitWait.Until(e => e.FindElement(this.locator));
        }
    }
}
