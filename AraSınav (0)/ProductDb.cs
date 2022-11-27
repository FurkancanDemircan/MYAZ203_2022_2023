using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAZ203.AraSınav__0_
{
    public static class ProductDb
    {
        private static List<Product> _products { get; }
        static ProductDb()
        {
            _products = new List<Product>();
        }

        public static void Add(Product product)
        {
            _products.Add(product);
        }

        public static void AddRange(List<Product> products)
        {
            for (int i = 0; i < products.Count; i++)
            {
                var pro = _products.Where(pro => pro.Id == products[i].Id).First();
                Console.WriteLine(pro.Id);
                if(pro!=null)
                    _products.Add(products[i]);
            }

        }


        public static List<Product> GetAllProducts()
        {
            return _products;
        }


    }
}
