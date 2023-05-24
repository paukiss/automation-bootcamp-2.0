using OpenQA.Selenium;
using project_automation_bootcamp_2._0.src.code.session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_automation_bootcamp_2._0.src.code.control
{
    public class Frame : ControlSelenium
    {
        public Frame(By locator) : base(locator)
        {
        }

        public void switchFrame(string nameFrame)
        {
            IWebElement frameElementEmail = Session.Instance().GetBrowser().FindElement(By.Id(nameFrame));
            Session.Instance().GetBrowser().SwitchTo().Frame(frameElementEmail);
        }

        public void switchDefaultFrame()
        {
            Session.Instance().GetBrowser().SwitchTo().DefaultContent();
        }
    }
}
