using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAZ203.Week_6
{
    public class Program
    {
        public static void Main()
        {
            List<Product> products = new List<Product>()
            {
                new Product(4, "Product D", 40, 5),
                new Product(1, "Product A", 15, 45),
                new Product(6, "Product F", 5, 20),
                new Product(3, "Product C", 35, 4),
                new Product(2, "Product B", 25, 11),
                new Product(5, "Product E", 8, 100),
            };

            Product product = new Product(products);
            product.GetProduct();
        }
    }
}
