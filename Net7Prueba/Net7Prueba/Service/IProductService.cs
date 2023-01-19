using Net7Prueba.Models;

namespace Net7Prueba.Service
{
    public interface IProductService
    {
        void CreateProduct(ProductModel product);
        void DeleteProduct(int id);
        List<ProductEntity> GetAllProduct();
        ProductEntity GetProductById(int id);
    }
}