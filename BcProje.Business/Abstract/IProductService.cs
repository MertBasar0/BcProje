using BcProje.Entities;
using BcProje.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcProje.Business.Abstract
{
    public interface IProductService
    {
        Task<bool> AddProduct(Product product);

        Task<List<Product>> GetAllProducts();

        Task<Product> GetProductById(int productId);


    }
}
