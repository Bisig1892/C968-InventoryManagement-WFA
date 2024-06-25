using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyler_Bisig___C968
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min {  get; set; }
        public int Max { get; set; }

        public BindingList<Part> AssociatedParts = new BindingList<Part>();

        public Product()
        {
        
        }

        public Product(int productId, string name, decimal price, int inStock, int min, int max)
        {
            ProductId = productId;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }
        // Adds part to product
        public void addAssociatedPart(Part part) 
        { 
            AssociatedParts.Add(part);
        }

        // Removes part from product
        public void removeAssociatedPart(int partId) 
        {
            foreach (Part part in AssociatedParts) 
            {
                if (part.PartId == partId)
                {
                    AssociatedParts.Remove(part);
                    return;
                }
                else
                {
                    MessageBox.Show("Part not found.");
                    return;
                }
            }
            return;
        }
        // Finds parts associated with product
        public Part lookupAssociatedPart(int partId)
        {
            foreach (Part part in AssociatedParts)
            {
                if (part.PartId == partId)
                {
                    return part;
                }
            }
            return null;
        }
    }
}
