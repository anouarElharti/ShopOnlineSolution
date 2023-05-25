using ShopOnline.Models.Dtos;

namespace ShopOnline_WASM.Services.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetItems();
    }
}
