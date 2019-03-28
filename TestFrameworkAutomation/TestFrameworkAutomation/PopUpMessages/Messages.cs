using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestFrameworkAutomation
{
    public class Messages
    {

        public static bool BasePageMsg(string msg)
        {
            msg = Driver.Instance.FindElement(By.XPath("/html/head/title")).Text;
            return true;
        }
        public static bool LoginSuccessMsg(string msg)
        {

            msg = Driver.Instance.FindElement(By.XPath("//*[@id='header']/div/div/div[2]/div[2]/div[2]/div[1]/a[2]")).Text;
            return true;
        }

       public static string  CheckProductsMsg
        {
            get
            {
                string a = Driver.Instance.FindElement(By.XPath("//*[@id='contentListing']/div/div/div[2]/section[1]/div[1]/div[1]/strong")).Text;

                return a;
            }

        }

        public static bool GetUrl(string msg)
        {

            msg = Driver.Instance.Url;
            return true;
        }

        public static int CheckFavorite
        {
            get
            {

                var FavoriteProduct = Driver.Instance.FindElement(By.XPath("//*[@id='view']"));
                int x = FavoriteProduct.FindElements(By.TagName("li")).Count;

                return x;

            }
        }


        public static bool CheckFav(string msg)
        {

            msg = Driver.Instance.FindElement(By.XPath("//*[@id='watchList']/div")).Text;
            return true;

        }


       

    }
}
