using BcProje.Business.Abstract;
using BcProje.DataAccess.Abstract;
using BcProje.Entities;
using BcProje.Entities.Models;

namespace BcProje.Business.Conctrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        

        public async Task<bool> AddProduct(Product product)
        {
            return await _productDal.CreateAsync(product);
        }


        public async Task<List<Product>> GetAllProducts()
        {
            return await _productDal.GetAsync();
        }

        public Task<Product> GetProductById(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
