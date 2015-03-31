using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;

namespace Presentation
{
    public interface IProductListView
    {
        void Display(IList<ProductViewModel> products);
        Model.CustomerType CustomerType { get; }
        string ErrorMessage { set; }
    }
}
