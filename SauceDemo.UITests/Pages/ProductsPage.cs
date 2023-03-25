using OpenQA.Selenium;
using SauceDemo.UITests.Support;

namespace SauceDemo.UITests.Pages
{
    public class ProductsPage
    {
        #region IWebElements

        private By InventoryItemName = By.LinkText("Sauce Labs Backpack");
        private By AddProductBtn = By.Id("add-to-cart-sauce-labs-backpack");
        private By ShoppingCartBtn = By.Id("shopping_cart_container");

        #endregion

        #region Actions

        private void OpenDetailProduct(By productName)
        { 
            Repository.Driver.FindElement(productName).Click();
        }

        #endregion
    }
}
