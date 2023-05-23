using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace project_automation_bootcamp_2._0
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;

        [TestInitialize]
        public void OpenBrowser()
        {
            Console.WriteLine("setuap");
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            driver = new ChromeDriver(path + "/driver/chromedriver.exe");
            driver.Navigate().GoToUrl("https://www.google.com");
        }

        [TestCleanup]
        public void CloseBrowser()
        {
            Console.WriteLine("Cleanup");
        }

        [TestMethod]
        public void VerifyLoginIsSuccessfuly()
        {
            driver.FindElement();
            Console.WriteLine("test");
        }
    }
}