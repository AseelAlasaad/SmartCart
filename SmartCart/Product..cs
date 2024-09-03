using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCart
{

    public enum ProductCategory
    {
        Food,
        Clothing, 
        Electronics,
        Others

    }
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public ProductCategory Category { get; set; }
    }
}
