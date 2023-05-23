using OpenQA.Selenium;
using project_automation_bootcamp_2._0.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_automation_bootcamp_2._0.src.code.page.todoist
{
    public class ProjectsPage
    {
        public Button newProject = new Button(By.XPath("//a[@href='/app/projects']"));
        public Button addProject = new Button(By.XPath("//button[span[contains(text(),'Add project')]]"));
        public TextBox nameProject = new TextBox(By.XPath("//input[@id='edit_project_modal_field_name']"));
        public Button addNewProject = new Button(By.XPath("//button[span[text()='Add']]"));
        public TextBox newNameProject = new TextBox(By.XPath("//input[contains(@aria-label, 'Name')]"));
        public Button saveProject = new Button(By.XPath("//button[span[text()='Save']]"));
        public Label nameProjectHeader = new Label(By.XPath("//h1/span[contains(@class,'simple_content')]"));
        public void clickOnNameProject(string nameProject)
        {
            TextBox projectCreated = new TextBox((By.XPath("//h1/span[text()='" + nameProject + "']")));
            projectCreated.Click();
        }

        public void selectNameProjectToAddTask(string nameProject)
        {
            Button nameProjectSelected = new Button(By.XPath("//div[text()='" + nameProject + "']"));
            nameProjectSelected.Click();
        }

    }
}
