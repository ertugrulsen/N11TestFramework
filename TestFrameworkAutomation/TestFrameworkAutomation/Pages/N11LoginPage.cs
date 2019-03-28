using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestFrameworkAutomation
{
    public class N11LoginPage
    {

        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl(Driver.BaseUrl);
        }
        public static N11Command EmailAs(string email)
        {
            return new N11Command(email);
        }

     



        public class N11Command
        {
            private readonly string email;
            private string password;
            private string search;


            public N11Command(string email)
            {
                this.email = email;
            }

            public N11Command WithPassword(string password)
            {
                this.password = password;
                return this;
            }
            public N11Command SearchData(string search)
            {
                this.search = search;
                return this;
            }



            public void Login()
            {



                WebDriverWait wait = new WebDriverWait(Driver.Instance, new TimeSpan(0, 0, 20));
                wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("btnSignIn"))).Click();
                // var wait5 = new WebDriverWait(Driver.Instance, new TimeSpan(0, 0, 10));
                // wait5.Until(d => d.SwitchTo().ActiveElement().GetAttribute("Name") == "Login");

                Driver.Wait(TimeSpan.FromSeconds(3));

                IWebElement Email;
                Email = Driver.Instance.FindElement(By.Id("email"));
                Email.SendKeys(email);

                IWebElement Password;
                Password = Driver.Instance.FindElement(By.Id("password"));
                Password.SendKeys(password);



                Driver.Wait(TimeSpan.FromSeconds(3));

                IWebElement LoginButton;
                LoginButton = Driver.Instance.FindElement(By.Id("loginButton"));
                LoginButton.Click();

                Driver.Wait(TimeSpan.FromSeconds(4));

            }

      


        }


    }

}

