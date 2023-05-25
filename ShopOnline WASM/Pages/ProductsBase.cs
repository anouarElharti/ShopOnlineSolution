using Microsoft.AspNetCore.Components;
using ShopOnline.Models.Dtos;
using ShopOnline_WASM.Services.Contracts;

namespace ShopOnline_WASM.Pages
{
    public class ProductsBase:ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; }
        public IEnumerable<ProductDto> Products { get; set; }

        protected override Task OnInitializedAsync()
        {
            return base.OnInitializedAsync();
        }
    }
}
