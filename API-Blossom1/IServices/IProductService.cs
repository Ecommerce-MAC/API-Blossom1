using Entities.Entities;
using Entities.SearchFilter;

namespace API_Blossom1.IServices
{
    public interface IProductService
    {
        int InsertProduct(ProductItem productItem);
        List<ProductItem> GetProduct();

        List<ProductItem> GetProductsByCriteria(ProductFilter productFilter);
        void DeleteProductItem(int id);

        void UpdateProduct(ProductItem productItem);

    }
}
