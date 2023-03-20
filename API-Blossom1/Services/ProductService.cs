using API_Blossom1.IServices;
using Entities.Entities;
using Entities.SearchFilter;
using Logic.ILogic;

namespace API_Blossom1.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductLogic _productLogic;
        public ProductService(IProductLogic productLogic)
        {
            _productLogic = productLogic;
        }


        public List<ProductItem> GetProduct()
        {
            return _productLogic.GetProduct();
        }

        List<ProductItem> IProductService.GetProductsByCriteria(ProductFilter productFilter)
        {
            return _productLogic.GetProductsByCriteria(productFilter);
        }

        public void DeleteProductItem(int id)
        {
            _productLogic.DeleteProductItem(id);
        }

        public int InsertProduct(ProductItem productItem)
        {
            _productLogic.InsertProductItem(productItem);
            return productItem.id;
        }

        public void UpdateProduct(ProductItem productItem)
        {
            _productLogic.UpdateProduct(productItem);
        }

        List<ProductItem> IProductService.GetProduct()
        {
            return _productLogic.GetProduct();
        }

        

        
    }
}
