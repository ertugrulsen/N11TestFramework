using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestFrameworkAutomation
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }

     
        public static void Initialize()
        {
            Instance = new ChromeDriver();
          //  Instance.Manage().Timeouts().ImplicitWait(TimeSpan.FromSeconds(5));
            Instance.Manage().Window.Maximize();

        }

        public static string BaseUrl
        {
            get { return "https://www.n11.com/"; }
        }


        public void Close()
        {
            Instance.Close();
        }

        public static void Wait(TimeSpan timeSpan)
        {
            Thread.Sleep((int)timeSpan.TotalSeconds * 1000);
        }

      
    }
}
