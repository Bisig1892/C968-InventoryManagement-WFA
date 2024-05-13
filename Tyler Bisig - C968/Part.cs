using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyler_Bisig___C968
{
    public abstract class Part
    {
        private int PartId { get; set; }
        private string Name { get; set; }
        private decimal Price { get; set; }
        private int Inventory { get; set; }
        private int Min { get; set; }
        private int Max { get; set; }
    }


}
