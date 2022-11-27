using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAZ203.Week_6
{
    public class Product : IProduct, IComparable<Product>, IFormattable
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
            foreach(var product in _products)
            {
                Console.WriteLine(product.ToString());
            }
        }

        public override string? ToString()
        {
            return this.ToString(null, CultureInfo.CurrentCulture);
        }

        public string ToString(string format)
        {
            return this.ToString(format, CultureInfo.CurrentCulture);
        }

        public decimal GetUnitPrice(int id)
        {
            return (decimal)(_products[id].UnitPrice * _products[id].UnitInStock);
        }

        public int CompareTo(Product? other)
        {
            return this.ProductId.CompareTo(other.ProductId);
        }

        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            if (String.IsNullOrEmpty(format)) format = "ID";
            if (formatProvider == null) formatProvider = CultureInfo.CurrentCulture;

            switch (format.ToUpperInvariant())
            {
                case "ID":
                    return $"{ProductId} {ProductName} {UnitPrice} {UnitInStock}";
                case "N":
                    return $"{ProductName} {ProductId} {UnitPrice} {UnitInStock}";
                case "P":
                    return $"{UnitPrice} {ProductId} {ProductName} {UnitInStock}";
                case "S":
                    return $"{UnitInStock} {ProductId} {ProductName} {UnitPrice}";
                default:
                    throw new Exception("Format not supported!");
            }
        }
    }
}
