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
    class CartItemClient
    {

        public async Task<CartItemDto> SetCartItemAsync(Dictionary<string, string> cookies, int productId)
        {
            //Application application = new Application();
            string cartItems = "";
            string payload = "{\"products\":[{\"id\":73795251,\"quantity\":2000}]}";
                             //"{\"products\":[{\"id\":73795251,\"quantity\":2000}]}"
            try
            {
                var headers = new Dictionary<string, string>()
                {
                    {"Content-Type","application/string"},
                    {"User-Agent", "Other"}
                };
                cartItems = await "https://api.takealot.com/rest/v-1-10-0/customers/-414697246/cart/items"
                .WithHeaders(headers)
                .WithCookies(cookies)
                .PutStringAsync(payload).ReceiveString();//.ReceiveString();

            //     sellerProducts = await "https://api.takealot.com/rest/v-1-10-0/searches/products?Sellers:29825747&filter=Sellers:29825747"
            //    .WithHeaders(headers)
            //        .GetAsync().ReceiveString();
            }
            catch (System.Exception ex)
            {
               // Console.WriteLine($"Error occurred: {ex.Message}");
                //Console.WriteLine($"Error occurred: {ex.InnerException.Message}");
            }

            return JsonConvert.DeserializeObject<CartItemDto>(cartItems);

        }

        public async Task<SellerProductDto> listAddresses()
        {
            //var url = this.baseUrl + "addresses";
            SellerProductDto resp = await "https://api.takealot.com/rest/v-1-10-0/searches/products?Sellers:29825747&filter=Sellers:29825747".GetJsonAsync<SellerProductDto>();
            return resp;
        }
    }
}