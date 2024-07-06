using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyler_Bisig___C968
{
    public class Inventory
    {
        public static BindingList<Part> Parts = new BindingList<Part>();
        public static BindingList<Product> Products = new BindingList<Product>();

        public static int prtIndex;


        //populateBindingLists
        public static void populateLists()
        {
            //populate Parts
            Part testPart1 = new InHouse(1, "Mouse", (decimal)12.99, 22, 1, 200, 1234);
            Part testPart2 = new InHouse(2, "Keyboard", (decimal)18.76, 18, 17, 25, 4321);
            Part testPart3 = new Outsourced(3, "Graphics Card", (decimal)879.05, 34, 17, 44, "Some Company");
            Part testPart4 = new Outsourced(4, "Motherboard", (decimal)128.50, 6, 6, 75, "Test Company");

            Parts.Add(testPart1);
            Parts.Add(testPart2);
            Parts.Add(testPart3);
            Parts.Add(testPart4);
        }


        // Adds Part
        public static void AddPart(Part part)
        {
            Parts.Add(part);
        }

        // updates part from parts list by id
        public static void UpdatePart(int partId, Part part)
        {
            DeletePart(partId);
            Parts.Add(part);
        }

        // Deletes part from parts list by id
        public static bool DeletePart(int part)
        {
            Part p = GetPart(part);
            if (p ==  null)
            {
                return false;
            }
            else
            {
                Parts.Remove(p);
                return true;
            }
        }

        // Finds part from parts list by Id
        public static Part GetPart(int id) 
        {
            foreach (Part part in Parts)
            {
                if (part.PartId == id)
                {
                    return part;
                }
            }
            Part NoPart = null;
            return NoPart;

        }


        // Creates a Product
        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }

        // Updates a product
        public static void UpdateProduct(int id, Product updatedProduct)
        {
            foreach(Product currproduct in Products)
            {
                if(currproduct.ProductId == id)
                {
                    currproduct.Name = updatedProduct.Name;
                    currproduct.Price = updatedProduct.Price;
                    currproduct.InStock = updatedProduct.InStock;
                    currproduct.Min = updatedProduct.Min;
                    currproduct.Max = updatedProduct.Max;
                    currproduct.AssociatedParts = updatedProduct.AssociatedParts;
                    return;
                }
            }
        }

        // Deletes product
        public static bool DeleteProduct(int id)
        {
            bool remove = false;

            foreach (Product product in Products)
            {
                if( id == product.ProductId )
                {
                    Products.Remove(product);
                    return remove = true;
                }
                else 
                {
                    MessageBox.Show("Failed to remove product.");
                    return false;
                }
            }
            return remove;
        }
    }
}
