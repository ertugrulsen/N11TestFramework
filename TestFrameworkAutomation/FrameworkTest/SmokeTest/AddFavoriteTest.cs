using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFrameworkAutomation;
using TestFrameworkAutomation.Pages;

namespace FrameworkTest
{
    [TestClass]
    public class AddFavoriteTest : FrameworkTest
    {



        [TestMethod]
        public void User_Can_Add_A_Product_To_Favorite()
        {
            //we can write to search data on web site
            N11SearchPage.SearchData("samsung").Search();
            //Check product in samsung search
            Assert.IsTrue(Messages.CheckProductsMsg != "0");
            //Check samsung second page in samsung search
            Assert.IsTrue(Messages.GetUrl("https://www.n11.com/arama?q=samsung&pg=2"));
            //We can choose a product to add favorite
            N11AddFavoritePage.ChoosePrdouct(2).AddFavorite();
            //This product is not on your favorite page           
            Assert.IsTrue(Messages.CheckFav("İzlediğiniz bir ürün bulunmamaktadır."));

          








        }
    }
}