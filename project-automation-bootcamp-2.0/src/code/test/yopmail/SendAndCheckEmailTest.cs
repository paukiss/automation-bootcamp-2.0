using project_automation_bootcamp_2._0.src.code.page.todoist;
using project_automation_bootcamp_2._0.src.code.page.yopmail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_automation_bootcamp_2._0.src.code.test.yopmail
{
    [TestClass]
    public class SendAndCheckEmailTest : TestBase
    {

        CreateEmail createEmail = new CreateEmail();
        MailFrame mailFrame = new MailFrame();
        MenuMailSection menuMailSection = new MenuMailSection();


        [TestMethod]
        public void SendEmailAndCheckReceive()
        {
            string email = "sergiopaucara@yopmail.com";
            string msgSubject = "Hello, myself!";
            string msgBody = "Hi, how are you?";

            createEmail.createEmailAndLogin(email);
            Assert.IsTrue(menuMailSection.newEmail.IsControlDisplayed(), "Error! the login");

            menuMailSection.newEmail.Click();
            mailFrame.iframe.switchFrame("ifmail");
            mailFrame.sendMessage(email, msgSubject, msgBody);
            mailFrame.msgEmailPop.waitControlIsNotVisibleElement();
            Assert.IsTrue(mailFrame.msgEmailPop.IsControlDisplayed(), "Error! Messagge was not send");

            mailFrame.iframe.switchDefaultFrame();
            string lastNumberMsg = menuMailSection.numberMails.GetText();
            menuMailSection.refresh.Click();
            mailFrame.iframe.switchFrame("ifmail");
            mailFrame.deliverability.waitControlIsNotVisibleElement();
            mailFrame.iframe.switchDefaultFrame();
            menuMailSection.numberMails.waitControlIsNotVisibleElement();
            string currectNumberMsg = menuMailSection.numberMails.GetText();
            Assert.AreNotEqual(lastNumberMsg, currectNumberMsg, "Error! Email was not receive");
        }
    }
}
