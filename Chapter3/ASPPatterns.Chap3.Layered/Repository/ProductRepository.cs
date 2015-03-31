using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Repository
{
   public class ProductRepository : IProductRepository
    {
       public IList<Model.Product> FindAll()
       {
           var products = from p in new ShopDataContext().Products
               select new Model.Product
               {
                   Id = p.ProductId,
                   Name = p.ProductName,
                   Price = new Price(p.RRP, p.SellingPrice)
               };

           return products.ToList();
       }
    }
}
