using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Models
{
    class Product
    {
        public string productname;
        public string productdescription;
        public int productcount;
        public int productdeadday;
        public int productdeadmonth;
        public int productdeadyear;
        public Product()
        {
        }
        public Product(string ProductName)
        {
            this.productname = ProductName;
        }
        public Product(string ProductName,string ProductDescription):this(ProductName)
        {
            this.productdescription = ProductDescription;
        }
        public Product(string ProductName, string ProductDescription,int ProductCount):this(ProductName, ProductDescription)
        {
            this.productcount = ProductCount;
        }
        public Product(string ProductName, string ProductDescription, int ProductCount,int ProductDeadDay):this(ProductName, ProductDescription, ProductCount)
        {
            this.productdeadday=ProductDeadDay;
        }
        public Product(string ProductName, string ProductDescription, int ProductCount, int ProductDeadDay, int ProductDeadMonth):this(ProductName,ProductDescription,ProductCount,ProductDeadDay)
        {
            this.productdeadmonth=ProductDeadMonth;
        }
        public Product(string ProductName, 
            string ProductDescription,
            int ProductCount, 
            int ProductDeadDay, 
            int ProductDeadMonth,int ProductDeadYear):this(ProductName,ProductDescription,ProductCount, ProductDeadDay, ProductDeadMonth)
        {
            this.productdeadyear=ProductDeadYear;
        }
        public void Buy()
        {
            if (productdeadday>20 || productdeadmonth>12 || productdeadyear>2022)
            {
                --productcount;
                Console.WriteLine($"Productun son sayi:{productcount}");
            }
            else if(productdeadday == 20 || productdeadmonth == 12 || productdeadyear == 2022)
            {
                --productcount;
                Console.WriteLine($"Productun son sayi:{productcount}");
            }
            else
            {
                Console.WriteLine("Son istifade tarixi bitmisdir...");
            }
        }
        

    }
}
