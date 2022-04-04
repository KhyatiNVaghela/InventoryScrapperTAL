
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace InventoryScrapperTAL
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver("../InventoryScrapperTAL/WebDriver");
 
            // This will open up the URL
            driver.Url = "https://www.takealot.com/cart";
            var cookies = driver.Manage().Cookies.AllCookies;
            var f = new GetProducts().GetProductListAsync();
            Console.WriteLine("Here is the cookie content:");
            Console.WriteLine(cookies);
            driver.Close();
            driver.Quit();
        }
    }
}
