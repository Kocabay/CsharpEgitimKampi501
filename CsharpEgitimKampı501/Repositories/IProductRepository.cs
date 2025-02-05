using CsharpEgitimKampı501.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CsharpEgitimKampı501.Repositories
{
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task CreateProductAsync(CreateProductDto createProductDto);
        Task UpdateProductAsync(UpdateProductDto updateProductDto);
        Task DeleteProductAsync(int id);
        Task GetByProductIdAsync(int id);
    }
}
