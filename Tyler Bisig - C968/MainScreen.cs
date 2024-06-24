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
        // opens Add Product Window
        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            AddProduct frm = new AddProduct();
            frm.Show();
        }
        // opens Modify Product Window 
        private void btn_editProduct_Click(object sender, EventArgs e)
        {
            EditProduct frm = new EditProduct();
            frm.Show();
        }
        // Closes Application
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
