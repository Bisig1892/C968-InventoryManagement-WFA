using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyler_Bisig___C968
{
    public partial class InHouse : Part
    {
        private int machineId;
        public int MachineId { get; set; }

        public InHouse()
        {

        }

        public InHouse(int partId, string name, decimal price, int inStock, int min, int max, int machineId)
        {
            PartId = partId;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            MachineId = machineId; 
        }
    }
}
