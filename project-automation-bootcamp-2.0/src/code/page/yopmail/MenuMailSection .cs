using OpenQA.Selenium;
using project_automation_bootcamp_2._0.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_automation_bootcamp_2._0.src.code.page.yopmail
{
    public class MenuMailSection
    {
        public Button newEmail = new Button(By.Id("newmail"));
        public Button refresh = new Button(By.Id("refresh"));
        public TextBox numberMails = new TextBox(By.Id("nbmail"));
    }
}
