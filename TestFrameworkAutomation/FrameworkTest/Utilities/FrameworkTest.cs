using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFrameworkAutomation;

namespace FrameworkTest
{
   public class FrameworkTest
    {
        [TestInitialize]
        public void Init()
        {

            Driver.Initialize();
            N11LoginPage.GoTo();
            N11LoginPage.EmailAs("senertugrul@hotmail.co.uk").WithPassword("321sen321").Login();

        }
        [TestCleanup]
        public void CleanUp()
        {
            Driver.Instance.Close();
        }
    }
}
