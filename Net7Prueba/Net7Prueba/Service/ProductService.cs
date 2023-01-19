using Net7Prueba.Data;
using Net7Prueba.Models;
using Net7Prueba.Service;

namespace Net7Prueba.Service
{
    public class ProductService : IProductService
    {
        private readonly StoreDbContext _context;
        public ProductService(StoreDbContext context)
        {
            this._context = context;
        }

        public void CreateProduct(ProductModel product)
        {
            ProductEntity productEntity = new()
            {
                Name = product.Name,
                Description = product.Description,
                Stock = product.Stock,
                CreateDate = DateTime.Now
            };
            _context.Products.Add(productEntity);
            _context.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            ProductEntity productToDelete = this.GetProductById(id);
            _context.Products.Remove(productToDelete);
            _context.SaveChanges();
        }

        public ProductEntity GetProductById(int id)
        {
            return _context.Products.Find(id);
        }

        public List<ProductEntity> GetAllProduct()
        {
            return _context.Products.ToList();
        }


    }
}
