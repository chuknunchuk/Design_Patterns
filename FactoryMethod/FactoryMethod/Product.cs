using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Product : IProduct
    {
        public Product()
        {
            Console.WriteLine(this.GetHashCode());
        }
    }
}
