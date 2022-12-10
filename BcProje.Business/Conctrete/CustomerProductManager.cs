using BcProje.Business.Abstract;
using BcProje.DataAccess.Abstract;
using BcProje.Entities;
using BcProje.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcProje.Business.Conctrete
{
    public class CustomerProductManager : ICustomerProductService
    {
        private readonly ICustomerProductDal _customerProductDal;
        private readonly IProductDal _productDal;
        public CustomerProductManager(ICustomerProductDal customerProductDal, IProductDal productDal)
        {
            _customerProductDal = customerProductDal;
            _productDal = productDal;
        }


        
        public async Task<bool> AddProductToCustomer(CustomerProduct cusPro)
        {
            var result = await _customerProductDal.CreateAsync(cusPro);

            return result;
        }


        public async Task<List<Product>> GetAddedProduct(int customerId)
        {
            List<Product> AddedList =  new List<Product>();

            var addedCompositeKey = await _customerProductDal.GetAsync(cp => cp.CustomerId == customerId);

            if (addedCompositeKey is not null)
            {
                foreach (var item in addedCompositeKey)
                {
                    AddedList.Add(await _productDal.GetByIdAsync(item.ProductId));
                }
               
            }
            //buraya addedList'in null olma durumunda dönülecek bir exeption yazılacak.

            return AddedList;
        }

        public async Task<List<Product>> GetPossibleAddedProduct(int customerId)
        {
            List<Product> PosibbleAdded = new List<Product>();
            var addedProducts = await _customerProductDal.GetAsync(cp => cp.CustomerId == customerId);
            var allProducts = await _productDal.GetAsync();

            if (addedProducts is not null)
            {
                allProducts.ForEach(x =>
                {
                    if (!addedProducts.Any(c => c.ProductId == x.ProductId))
                    {
                        PosibbleAdded.Add(x);
                    }
                });
            }
            
            return PosibbleAdded;
        }

        public async Task<bool> RemoveCustomerProduct(CustomerProduct cusPro)
        {
            var result = await _customerProductDal.RemoveDataFormInstance(cusPro);
            
            return result;
        }

        
    }
}
