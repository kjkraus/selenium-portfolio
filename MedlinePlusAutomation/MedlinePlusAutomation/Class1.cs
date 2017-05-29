using OpenQA.Selenium.Firefox;

namespace MedlinePlusAutomation
{
    public class Class1
    {
        public void Go()
        {
            var driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://google.com");
        }
    }
}