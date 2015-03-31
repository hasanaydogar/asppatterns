using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model;
using Repository;
using StructureMap;
using StructureMap.Configuration.DSL;

namespace WebUI
{
    public class BootStrapper
    {
        public static void ConfigureStructureMap()
        {
            ObjectFactory.Initialize(x=> x.AddRegistry<ProductRegistry>());
        }
    }

    public class ProductRegistry : Registry
    {
        public ProductRegistry()
        {
            For<IProductRepository>().Use<ProductRepository>();
            //http://stackoverflow.com/questions/3352637/structuremap-2-6-1-bootstrapper
        }
    }
}