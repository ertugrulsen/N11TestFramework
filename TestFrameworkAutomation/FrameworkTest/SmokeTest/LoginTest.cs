using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFrameworkAutomation;
using TestFrameworkAutomation.Pages;

namespace FrameworkTest
{
    [TestClass]
    public class LoginTest : FrameworkTest
    {



        [TestMethod]
        public void User_Can_Go_To_LoginPage()
        {
            //Confirm that the home page is open
            Assert.IsTrue(Messages.BasePageMsg("n11.com - Alışverişin Uğurlu Adresi"));
            //checking login
            Assert.IsTrue(Messages.LoginSuccessMsg("senertugrul@hotmail.co.uk"));


        }
    }
}