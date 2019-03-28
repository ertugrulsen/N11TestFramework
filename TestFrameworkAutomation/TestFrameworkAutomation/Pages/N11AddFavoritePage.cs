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
    public class N11AddFavoritePage
    {


        public static AddFovoriteCommand ChoosePrdouct(int add)
        {
            return new AddFovoriteCommand(add);
        }

    }

    public class AddFovoriteCommand
    {
        private readonly int add;

        public AddFovoriteCommand(int add)
        {
            this.add = add;
        }

        public void AddFavorite()
        {

            IWebElement ProductSelect = Driver.Instance.FindElement(By.Id("view"));
            IWebElement ProductTag = ProductSelect.FindElements(By.ClassName("column"))[add];


            WebDriverWait wait1 = new WebDriverWait(Driver.Instance, new TimeSpan(0, 0, 30));
            wait1.Until(ExpectedConditions.ElementIsVisible(By.XPath("//li[3]/div/div[2]/span[@title='Favorilere ekle']"))).Click();




            WebDriverWait wait2 = new WebDriverWait(Driver.Instance, new TimeSpan(0, 0, 30));
            IWebElement element = wait2.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='header']/div/div/div[2]/div[2]/div[2]/div[1]/a[1]")));

            Actions action = new Actions(Driver.Instance);
            action.MoveToElement(element).Perform();

            IWebElement s = Driver.Instance.FindElement(By.LinkText("İstek Listem / Favorilerim"));
            s.Click();

            //if 0 dam büyükse 

            WebDriverWait wait3 = new WebDriverWait(Driver.Instance, new TimeSpan(0, 0, 20));
            wait3.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='myAccount']/div[3]/ul/li[1]/div/a/h4"))).Click();

            WebDriverWait wait4 = new WebDriverWait(Driver.Instance, new TimeSpan(0, 0, 20));
            wait4.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("span.deleteProFromFavorites"))).Click();


            Driver.Instance.SwitchTo().ActiveElement();

            WebDriverWait wait5 = new WebDriverWait(Driver.Instance, new TimeSpan(0, 0, 20));
            wait5.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div[5]/div/div/span"))).Click();


            Driver.Instance.SwitchTo().DefaultContent();
            Driver.Wait(TimeSpan.FromSeconds(4));

        }
    }
}
