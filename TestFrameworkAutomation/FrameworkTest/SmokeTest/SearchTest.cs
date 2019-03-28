using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFrameworkAutomation;
using TestFrameworkAutomation.Pages;

namespace FrameworkTest
{
    [TestClass]
    public class SearchTestt : FrameworkTest
    {



        [TestMethod]
        public void User_Can_Go_To_Samsung_Search()
        {
            //we can write to search data on web site
            N11SearchPage.SearchData("samsung").Search();
            //We can control  product in samsung search
            Assert.IsTrue(Messages.CheckProductsMsg != "0");
            //We can control samsung second page in samsung search
            Assert.IsTrue(Messages.GetUrl("https://www.n11.com/arama?q=samsung&pg=2"));


        
        }

    }




}