using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Linq_com_Lambda
{
    class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public Category category { get; set; }


        public override string ToString()
        {
            return id
                + ", "
                + name
                + ", "
                + price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + category.name
                + ", "
                + category.tier;

            // teste commit git 
        }
    }
}
