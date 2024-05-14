using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyler_Bisig___C968
{
    public class Product
    {
        private int ProductId;
        private string Name;
        private decimal Price;
        private int InStock;
        private int Min;
        private int Max;

        public BindingList<Part> AssociatedParts = new BindingList<Part>();

        public Product()
        {
        
        }
    }
}
