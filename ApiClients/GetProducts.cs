using Flurl;
using Flurl.Http;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading.Tasks;

namespace InventoryScrapperTAL
{
    class GetProducts
    {

        public async Task<string> GetProductListAsync()
        {
            try
            {
                var person = await "https://api.takealot.com/rest/v-1-10-0/searches/products?Sellers:29825747&filter=Sellers:29825747"
                    .GetJsonAsync().Result;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine($"Error occurred: {ex.Message}");
                Console.WriteLine($"Error occurred: {ex.InnerException.Message}");
            }
            //.ReceiveJson<Person>();
            return "";
        }

        public async Task<SellersProducts> listAddresses()
        {
            //var url = this.baseUrl + "addresses";
            SellersProducts resp = await "https://api.takealot.com/rest/v-1-10-0/searches/products?Sellers:29825747&filter=Sellers:29825747".GetJsonAsync<SellersProducts>();
            return resp;
        }
    }
}