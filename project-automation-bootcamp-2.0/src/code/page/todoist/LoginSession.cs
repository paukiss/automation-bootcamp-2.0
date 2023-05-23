using OpenQA.Selenium;
using project_automation_bootcamp_2._0.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_automation_bootcamp_2._0.src.code.page.todoist
{
    public class LoginSession
    {
        public Button loginButton = new Button(By.XPath("//div/ul//a[text()='Log in']"));
    }
}
