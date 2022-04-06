using Flurl;
using Flurl.Http;
using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InventoryScrapperTAL
{
    class SellerProductsClient
    {

        public async Task<SellerProductDto> GetProductListAsync()
        {
            //Application application = new Application();
            string sellerProducts = "";
            try
            {
                var headers = new Dictionary<string, string>()
                {
                    {"Content-Type","application/json"},
                    {"User-Agent", "Other"}
                };

                sellerProducts = await "https://api.takealot.com/rest/v-1-10-0/searches/products?Sellers:29825747&filter=Sellers:29825747"
               .WithHeaders(headers)
                   .GetAsync().ReceiveString();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine($"Error occurred: {ex.Message}");
                Console.WriteLine($"Error occurred: {ex.InnerException.Message}");
            }

            return JsonConvert.DeserializeObject<SellerProductDto>(sellerProducts);

        }

        public async Task<SellerProductDto> listAddresses()
        {
            //var url = this.baseUrl + "addresses";
            SellerProductDto resp = await "https://api.takealot.com/rest/v-1-10-0/searches/products?Sellers:29825747&filter=Sellers:29825747".GetJsonAsync<SellerProductDto>();
            return resp;
        }
    }
}