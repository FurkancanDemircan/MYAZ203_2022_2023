using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAZ203.AraSınav__0_
{
    public class ProductManager
    {
        public int NumberOfProducts => _products.Count;
        public decimal TotalAmount => GetTotalAmount();
        public int DiscountRate => 10;
        public decimal Discount => MakeDiscount((uint)DiscountRate);
        public decimal TotalAmountAfterDiscount => TotalAmount - Discount;

        

        private readonly List<Product> _products;

        public ProductManager()
        {
            _products = ProductDb.GetAllProducts();
        }

        public void Add(Product product)
        {
            ProductDb.Add(product);
        }

        public void AddRange(List<Product> products)
        {
            throw new NotImplementedException();
        }

        public decimal GetTotalAmount()
        {
            decimal total = 0;

            for (int i = 0; i < _products.Count; i++)
                total += _products[i].Price;

            return total;
        }

        public decimal MakeDiscount(uint discountRate)
        {
            int total = 0;
            for (int i = 0; i < _products.Count; i++)
            {
                if (_products[i].Price >= 10000)
                {
                    total += (int) _products[i].Price;
                }
            }
            if (discountRate >= 10 && discountRate <= 50)
            {
                var dis = (total * discountRate) / 100;
                return dis;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            foreach (var prd in _products)
            {
                builder.Append($"\n{prd}");
            }
            builder.Append($"\n{new String('-',51)}");
            builder.Append($"\n{"Total Amount",-40} :  {TotalAmount,-10}");
            builder.Append($"\n{"Discount Rate",-40} :  {DiscountRate,-10}");
            builder.Append($"\n{"Discount",-40} :  {Discount,-10}");
            builder.Append($"\n{"Total Amount After Discount",-40} :  {TotalAmountAfterDiscount,-10}");


            return builder.ToString();
        }
    }
}
