using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAZ203.AraSınav__0_
{
    public class Product
    {
        public Product()
        {

        }

        public Product(int id, string? productName, decimal price)
        {
            Id = id;
            ProductName = productName;
            Price = price;
        }

        public int Id { get; set; }
        public String? ProductName { get; set; }
        public Decimal Price { get; set; }

        /// <summary>
        /// Sadece ToString metodunun gövdesini cevap kağıdına geçiriniz.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override string ToString()
        {
            return $"{Id,-5}  {ProductName,-15} {Price,-5}";
        }
    }
}
