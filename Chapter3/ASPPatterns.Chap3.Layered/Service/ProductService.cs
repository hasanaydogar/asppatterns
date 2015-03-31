using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ProductService
    {
        private Model.ProductService _productService;

        public ProductService(Model.ProductService productService)
        {
            _productService = productService;
        }

        public ProductListResponse GetAllProductsFor(ProductListRequest productListRequest)
        {
            ProductListResponse productListResponse = new ProductListResponse();

            try
            {
                IList<Model.Product> productEntites = _productService.GetAllProductsFor(productListRequest.CustomerType);
                productListResponse.Products = productEntites.ConvertToProductListViewModel();
                productListResponse.Success = true;
            }
            catch (Exception ex)
            {
                // Log the exeption
                productListResponse.Success = false;
                productListResponse.Message = "An Error occured :" + ex.ToString();
            }
            return productListResponse;
        }
    }
}
