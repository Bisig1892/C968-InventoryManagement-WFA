using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyler_Bisig___C968
{
    public partial class MainScreen : Form
    {

        public MainScreen()
        {
            InitializeComponent();
            populateDataGrids();

        }

        public void populateDataGrids()
        {
            // populates the parts and products lists in the data grid
            Inventory.populateLists();


            // populates parts data grid
            var Parts = new BindingSource();
            Parts.DataSource = Inventory.Parts;
            dg_parts.DataSource = Parts;
            dg_products.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // populates products data grid
            var Products = new BindingSource();
            Products.DataSource = Inventory.Products;
            dg_products.DataSource = Products;
            dg_products.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // opens Add Part Window
        private void btn_addPart_Click(object sender, EventArgs e)
        {
            AddPart frm = new AddPart();
            frm.Show();
        }
        // opens Edit Part Window
        private void btn_editPart_Click(object sender, EventArgs e)
        {
            // opens window to edit inhouse part information
            if(dg_parts.CurrentRow.DataBoundItem.GetType() == typeof(Tyler_Bisig___C968.InHouse))
            {
                InHouse inHousePart = (InHouse)dg_parts.CurrentRow.DataBoundItem;
                new EditPart(inHousePart).ShowDialog();
            }
            // opens window to edit outsourced part information 
            else
            {
                Outsourced outsourcedPart = (Outsourced)dg_parts.CurrentRow.DataBoundItem;
                new EditPart(outsourcedPart).ShowDialog();
            }


        }

        // deletes selected part
        private void btn_deletePart_Click(object sender, EventArgs e)
        {
            // checks to see if a part is selected
            if (!dg_parts.CurrentRow.Selected || dg_parts.CurrentRow == null)
            {
                MessageBox.Show("Select a part to delete.");
            }
            else
            {
                // confirms if the user wants to delete the part
                DialogResult confirmation = MessageBox.Show("Are you sure you want to delete this part?", "Delete Part?", MessageBoxButtons.YesNo);
                {
                    if (confirmation == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow r in dg_parts.SelectedRows)
                        {
                            dg_parts.Rows.RemoveAt(r.Index);
                        }
                    }
                    else return;
                }
            }
        }
        // searches for part
        private void btn_searchPart_Click(object sender, EventArgs e)
        {
            string searchValue = tb_searchPart.Text.ToLower();

            dg_parts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            try
            {
                foreach (DataGridViewRow r in dg_parts.Rows)
                {
                    if (r.Cells[1].Value.ToString().ToLower().Contains(searchValue))
                    {
                        r.Selected = true;
                        break;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Part not found.");
            }
        }
        // opens Add Product Window
        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            AddProduct frm = new AddProduct();
            frm.Show();
        }
        // opens Modify Product Window 
        private void btn_editProduct_Click(object sender, EventArgs e)
        {
            if (dg_products.CurrentRow == null || !dg_products.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a product to edit.");
                return;
            }
            if (dg_products.CurrentRow.DataBoundItem is Product)
            {
                Product SelectedProduct = dg_products.CurrentRow.DataBoundItem as Product;
                new EditProduct(SelectedProduct).ShowDialog();
            }
        }
        private void btn_deleteProduct_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this product?", "Delete Product?", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                Product p = (Product)dg_products.CurrentRow.DataBoundItem;
                if (p.AssociatedParts.Count > 0)
                {
                    MessageBox.Show("You must unassign assigned parts from product before deleting.");
                    return;
                }
                foreach (DataGridViewRow r in dg_products.SelectedRows) 
                {
                    dg_products.Rows.RemoveAt(r.Index);
                }
            }
            else
            {
                return;
            }
        }
        private void btn_searchProduct_Click(object sender, EventArgs e)
        {
            string searchValue = tb_searchProduct.Text.ToLower();

            dg_products.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            try
            {
                foreach (DataGridViewRow r in dg_products.Rows)
                {
                    if (r.Cells[1].Value.ToString().ToLower().Contains(searchValue))
                    {
                        r.Selected = true;
                        break;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Part not found.");
            }
        }
        // Closes Application
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
