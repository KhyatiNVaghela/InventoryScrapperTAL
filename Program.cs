
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace InventoryScrapperTAL
{
    class Program
    {
        static async Task Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver("../InventoryScrapperTAL/WebDriver");
            try
            {

                // This will open up the URL
                driver.Url = "https://www.takealot.com/cart";
                Thread.Sleep(2 * 1000);
                var cookies = driver.Manage().Cookies.AllCookies;
                List<int> productIds = new List<int>();
                Dictionary<string, string> cookieDictionary = new Dictionary<string, string>();
                cookieDictionary.Clear();
                foreach (Cookie cookie in cookies)
                {
                    if (cookieDictionary.ContainsKey(cookie.Name))
                    {
                        cookieDictionary.Remove(cookie.Name);
                    }
                    cookieDictionary.Add(cookie.Name, cookie.Value);
                }

                //string postPayload = "{\"products\":[{\"id\":73795251,\"quantity\":2000}]}";


                var gg = new CartItemClient().SetCartItemAsync(cookieDictionary, 123).GetAwaiter().GetResult();

                Console.WriteLine("Here is the cookie content:");
                Console.WriteLine(cookies);


                SellerProductDto result = new SellerProductsClient().GetProductListAsync().GetAwaiter().GetResult();
                foreach (var product in result.sections.products.results)
                {
                    productIds.Add(product.product_views.core.id);
                }

            }
            catch (Exception ex)
            {
                driver.Close();
                driver.Quit();
            }
            driver.Close();
            driver.Quit();
        }
    }
}
