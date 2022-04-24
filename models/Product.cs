using System;
using System.Collections.Generic;
using System.Text;

namespace homework13.models
{
    class Product 
    {

        public string name;
        public double Price;
        private double _discountedprice;
        public string productype;
        static int code = 1000;
        public string no;
        public int totalcount;

        public Product(string product, double price)
        {
            productype = product;
            Price = price;
            no = $"{productype[0]}{code}";
            code++;
            totalcount++;
        }
        public double Discountedprice {
            get => _discountedprice;
            set
            {
                string[] arr = Enum.GetNames(typeof(ProductTypes));
                foreach (string item in arr)
                {
                    if (productype == item)
                    {
                        value = Price - ((Price * 10) / 100);
                        _discountedprice = value;
                    }
                }
            }
        }
    }

}
