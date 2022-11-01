using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAZ203.Week_6
{
    public class Product : IProduct, IComparable<Product>
    {
        private int _productId;
        private string _productName;
        private decimal _unitPrice;
        private Int16 _unitInStock;

        private List<Product> _products;

        public Product()
        {
            _products = new List<Product>();
        }

        public Product(int productId, string productName, decimal unitPrice, short unitInStock)
        {
            _products = new List<Product>();
            ProductId = productId;
            ProductName = productName;
            UnitPrice = unitPrice;
            UnitInStock = unitInStock;
        }

        public Product(List<Product> products)
        {
            _products = products;
        }

        public int ProductId
        {
            get => _productId;
            set => _productId = value;
        }
        public string ProductName
        {
            get => _productName;
            set => _productName = value;
        }
        public decimal UnitPrice
        {
            get => _unitPrice;
            set => _unitPrice = value;
        }
        public short UnitInStock
        {
            get => _unitInStock;
            set => _unitInStock = value;
        }

        public void GetProduct()
        {
            _products.Sort();
            for (int i = 0; i < _products.Count; i++)
            {
                Console.WriteLine($"{_products[i].ProductId} " +
                    $"{_products[i].ProductName} " +
                    $"{_products[i].UnitPrice} " +
                    $"{_products[i].UnitInStock} " +
                    $"{GetUnitPrice(i)}");
            }
        }

        public decimal GetUnitPrice(int id)
        {
            return (decimal)(_products[id].UnitPrice * _products[id].UnitInStock);
        }

        public int CompareTo(Product? other)
        {
            return this.ProductId.CompareTo(other.ProductId);
        }
    }
}
