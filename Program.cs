
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading.Tasks;

namespace InventoryScrapperTAL
{
    class Program
    {
        static async Task Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver("../InventoryScrapperTAL/WebDriver");

            // This will open up the URL
            driver.Url = "https://www.takealot.com/cart";
            var cookies = driver.Manage().Cookies.AllCookies;
            SellerProductDto result = new GetProducts().GetProductListAsync().GetAwaiter().GetResult();
            Console.WriteLine("Here is the cookie content:");
            Console.WriteLine(cookies);
            driver.Close();
            driver.Quit();
        }
    }
}
