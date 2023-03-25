using OpenQA.Selenium;

namespace SauceDemo.UITests.Pages
{
    public class CartPage
    {
        #region IWebElements

        private By ItemName = By.ClassName("inventory_item_name");
        private By InventoryPrice = By.ClassName("inventory_item_price");
        private By CheckoutBtn = By.Id("checkout");

        #endregion

        #region Actions

        #endregion
    }
}
