using OpenQA.Selenium;
using project_automation_bootcamp_2._0.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_automation_bootcamp_2._0.src.code.page.todoist
{
    public class LoginPageSession
    {
        public TextBox emailTxt = new TextBox(By.XPath("//input[contains(@autocomplete, 'email')]"));
        public TextBox pwdTxt = new TextBox(By.XPath("//input[contains(@autocomplete, 'current-password')]"));
        public Button loginButton = new Button(By.XPath("//button[contains(@data-gtm-id, 'start-email-login')]"));

        public void Login(string user, string pwd)
        {
            emailTxt.SetText(user);
            pwdTxt.SetText(pwd);
            loginButton.Click();
        }
    }
}
