using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedlinePlusAutomation
{
    public class HomePage
    {
        public static void GoTo()
        {
            var driver = new FirefoxDriver();

            driver.Navigate().GoToUrl("https://medlineplus.gov/");
        }

        public static object SearchWith(string v)
        {
            throw new NotImplementedException();
        }
    }
}
