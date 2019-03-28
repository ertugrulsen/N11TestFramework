using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFrameworkAutomation.Pages
{
    public class N11SearchPage
    {
      

        public static  SearchDataCommand SearchData(string search)
        {
            return new SearchDataCommand(search);
        }

    }

    public class SearchDataCommand
    {
        private readonly string search;

        public SearchDataCommand(string search)
        {
            this.search = search;
        }
       
        public void Search()
        {

            IWebElement SearchBox;
            SearchBox = Driver.Instance.FindElement(By.Id("searchData"));
            SearchBox.SendKeys(search);

            IWebElement SearchBtn;
            SearchBtn = Driver.Instance.FindElement(By.ClassName("searchBtn"));
            SearchBtn.Click();


            WebDriverWait wait8 = new WebDriverWait(Driver.Instance, new TimeSpan(0, 0, 30));
            wait8.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("2"))).Click();


            


        }
    }
}
