using OpenQA.Selenium;
using project_automation_bootcamp_2._0.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_automation_bootcamp_2._0.src.code.page.yopmail
{
    public class CreateEmail
    {
        public TextBox emailTxt = new TextBox(By.Id("login"));
        public Button inboxButton = new Button(By.XPath("//button[contains(@title,'Check Inbox @yopmail.com')]"));

        public void createEmailAndLogin(string email)
        {
            emailTxt.SetText(email);
            inboxButton.Click();
        }
    }
}
