using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyler_Bisig___C968
{
    public class Outsourced : Part
    {

        private string companyName;

        public string CompanyName { get; set; }

        public Outsourced() { }

        public Outsourced(int partId, string name, decimal price, int inStock, int min, int max)
        {
            PartId = partId;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }

        public Outsourced(int partId, string name, decimal price, int inStock, int min, int max, string companyName)
        {
            PartId = partId;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            CompanyName = companyName;
        }


    }
}
