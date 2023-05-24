using OpenQA.Selenium.Chrome;
using project_automation_bootcamp_2._0.src.code.page.todoist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_automation_bootcamp_2._0.src.code.test.todoist
{
    [TestClass]
    public class ProjectTest : TestBase
    {

        MainPage mainPage = new MainPage();
        LoginPageSession loginPageSession = new LoginPageSession();
        LoginSession loginSession = new LoginSession();
        OptionsProjectPage optionsProjectPage = new OptionsProjectPage();
        ProjectsPage projectsPage = new ProjectsPage();
        string user = "sergiopaucarasaca@gmail.com";
        string pass = "123456789abc";

        [TestMethod]
        public void VerifyCRUDProject()
        {
            string nameProject = "New project sergio";
            string updateNameProject = "Update name project";

            loginSession.loginButton.Click();
            loginPageSession.Login(user, pass);
            mainPage.projectLabel.waitControlIsNotVisibleElement();
            Assert.IsTrue(mainPage.projectLabel.IsControlDisplayed(), "Error! Log in failed");

            projectsPage.newProject.Click();
            projectsPage.addProject.Click();
            projectsPage.nameProject.SetText(nameProject);
            projectsPage.addNewProject.Click();
            Assert.IsTrue(projectsPage.nameProjectHeader.IsControlDisplayed(), "Error! Project was not created");

            projectsPage.clickOnNameProject(nameProject);
            projectsPage.newNameProject.waitControlIsNotVisibleElement();
            projectsPage.newNameProject.SetText(updateNameProject);
            projectsPage.saveProject.Click();
            Assert.IsTrue(optionsProjectPage.optionsProject.IsControlDisplayed(), "Error! Project was not updated");

            optionsProjectPage.optionsProject.Click();
            optionsProjectPage.deleteOption.Click();
            optionsProjectPage.confirmDelete.Click();
            Assert.AreEqual("Inbox", projectsPage.nameProjectHeader.GetText(), "Error! Project was not deleted");
        }

    }
}
