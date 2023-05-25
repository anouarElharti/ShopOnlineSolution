using ShopOnline.Models.Dtos;
using ShopOnline_WASM.Services.Contracts;
using System.Net.Http.Json;

namespace ShopOnline_WASM.Services
{
    public class ProductService: IProductService
    {
        private readonly HttpClient httpClient;

        public ProductService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<ProductDto>> GetItems()
        {
            try
            {
                var products = await this.httpClient.GetFromJsonAsync<IEnumerable<ProductDto>>("api/product");
                return products;
            }catch (Exception)
            {

            }
        }
    }
}
