using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ASPPatterns.Chap2.Service
{
    public class ProductService
    {
        private IProductRepository _productRepository;
        private ICacheStorage _cacheStorage;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IList<Product> GetAllProductsIn(int categoryId)
        {
            IList<Product> products;
            string storageKey = string.Format("products_in_category_id{0}",categoryId);

            products = _cacheStorage.Retrieve<List<Product>>(storageKey);

            if (products == null)
            {
                products = _productRepository.GetAllProductsIn(categoryId);
                _cacheStorage.Store(storageKey,products);
            }

            return products;
        }
    }
}
