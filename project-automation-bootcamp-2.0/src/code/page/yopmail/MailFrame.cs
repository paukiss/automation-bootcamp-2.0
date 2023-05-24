using OpenQA.Selenium;
using project_automation_bootcamp_2._0.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_automation_bootcamp_2._0.src.code.page.yopmail
{
    public class MailFrame
    {
        public TextBox messageTo = new TextBox(By.Id("msgto"));
        public TextBox messageSubject = new TextBox(By.Id("msgsubject"));
        public TextArea messageBody = new TextArea(By.Id("msgbody"));
        public Button sendMsg = new Button(By.Id("msgsend"));
        public Frame iframe = new Frame(By.Id("ifmail"));
        public TextBox msgEmailPop = new TextBox(By.XPath("//div[@id='msgpopmsg' and contains(text(),'Your message has been sent')]"));
        public TextBox deliverability = new TextBox(By.Id("icodeliverability"));

        public void sendMessage(string msgTo, string msgSubject, string msgBoby)
        {
            messageTo.SetText(msgTo);
            messageSubject.SetText(msgSubject);
            messageBody.SetText(msgBoby);
            sendMsg.Click();
        }
    }
}
