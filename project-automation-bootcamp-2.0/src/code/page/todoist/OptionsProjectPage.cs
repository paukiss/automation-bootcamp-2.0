using OpenQA.Selenium;
using project_automation_bootcamp_2._0.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_automation_bootcamp_2._0.src.code.page.todoist
{
    public class OptionsProjectPage
    {
        public Button optionsProject = new Button(By.XPath("//button[@aria-label='Project options menu']"));
        public Button deleteOption = new Button(By.XPath("//div[text()='Delete project']"));
        public Button confirmDelete = new Button(By.XPath("//button[span[text()='Delete']]"));
    }
}
