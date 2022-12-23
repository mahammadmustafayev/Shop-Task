using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Models
{
    class Bread:Product
    {
        public string useplace;
        public Bread()
        {
        }
        public Bread(string UsePlace)
        {
            this.useplace = UsePlace;
        }
        public Bread(string UsePlace,string ProductName):base(ProductName)
        {
            this.productname = ProductName;
        }
        public Bread(string UsePlace, string ProductName,string ProductDescription):base(ProductName,ProductDescription)
        {
            this.productdescription= ProductDescription;
        }
        public Bread(string UsePlace, string ProductName, string ProductDescription,int ProductCount):base(ProductName,ProductDescription,ProductCount)
        {
            this.productcount= ProductCount;
        }
        public Bread(string UsePlace, 
            string ProductName, 
            string ProductDescription, 
            int ProductCount,
            int ProductDeadDay):base(ProductName,ProductDescription,ProductCount,ProductDeadDay)
        {
            this.productdeadday = ProductDeadDay;
        }
        public Bread(string UsePlace,
            string ProductName,
            string ProductDescription,
            int ProductCount,
            int ProductDeadDay,
            int ProductDeadMonth):base(ProductName,ProductDescription,ProductCount,ProductDeadDay,ProductDeadMonth)
        {
            this.productdeadmonth = ProductDeadMonth;
        }
        public Bread(string UsePlace,
            string ProductName,
            string ProductDescription,
            int ProductCount,
            int ProductDeadDay,
            int ProductDeadMonth,
            int ProductDeadYear):base(ProductName,ProductDescription,ProductCount,ProductDeadDay,ProductDeadMonth,ProductDeadYear)
        {
            this.productdeadyear= ProductDeadYear;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Productun Adi:{productname}");
            Console.WriteLine($"Product Haqqinda qisa melumat:{productdescription}");
            Console.WriteLine($"Productun hal-hazirki sayi:{productcount}");
            Console.WriteLine($"Productun son istifade tarixi:{productdeadday}/{productdeadmonth}/{productdeadyear}");
            Console.WriteLine($"Productun  istifade yeri:{useplace}");
            Console.WriteLine("-----------------------------------------------------------------------");
        }
    }
}
