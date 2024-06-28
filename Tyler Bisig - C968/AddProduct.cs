using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyler_Bisig___C968
{
    public partial class AddProduct : Form
    {
        Inventory inventory = new Inventory();
        Product product = new Product();

        public BindingList<Part> tempPart = new BindingList<Part>();

        public AddProduct()
        {
            InitializeComponent();
            dg_candidateParts.DataSource = Inventory.Parts;
            dg_associatedParts.DataSource = product.AssociatedParts;

            LoadAddProduct();
        }

        public void LoadAddProduct()
        {
            var CandidatePartLoad = new BindingSource();
            var AssociatedPartLoad = new BindingSource();

            tb_productId.Text = Convert.ToString(Inventory.Products.Count + 1);
            tb_productId.Enabled = false;

            // populates candidate parts
            CandidatePartLoad.DataSource = Inventory.Parts;
            dg_candidateParts.DataSource = CandidatePartLoad;
            dg_candidateParts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // populates parts associated to product
            AssociatedPartLoad.DataSource = tempPart;
            dg_associatedParts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg_associatedParts.DataSource = product.AssociatedParts;


            // adds all parts associated to product
            foreach (Part part in product.AssociatedParts)
            {
                tempPart.Add(part);
            }

        }

        // adds candidate part to associated part for product
        private void btn_AddPartToProduct_Click(object sender, EventArgs e)
        {
            Part part = (Part)dg_candidateParts.CurrentRow.DataBoundItem;
            product.addAssociatedPart(part);
        }


        // deletes selected rows of associated parts from product
        private void btn_DeletePartFromProduct_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Are you sure you want to delete this part from the product?", "Delete?", MessageBoxButtons.YesNo); 
            {
                if ( confirmation == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dg_associatedParts.SelectedRows)
                    {
                        dg_associatedParts.Rows.RemoveAt(row.Index);
                    }
                }
                else return;
            }
        }

        private void btn_SaveProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_productName.Text) || string.IsNullOrWhiteSpace(tb_productInventory.Text) ||
                    string.IsNullOrWhiteSpace(tb_productPrice.Text) || string.IsNullOrWhiteSpace(tb_productMax.Text) ||
                    string.IsNullOrWhiteSpace(tb_productMin.Text))
            {
                MessageBox.Show("All text fields must be filled out.");
                return;
            }
            // Checks inventory count falls between the scope of max and min
            if (int.Parse(tb_productInventory.Text) > int.Parse(tb_productMax.Text) || int.Parse(tb_productMin.Text) > int.Parse(tb_productInventory.Text))
            {
                MessageBox.Show("Inventory must be greater than minimum and less than maximum.");
                return;
            }
            if (int.Parse(tb_productMin.Text) > int.Parse(tb_productMax.Text))
            {
                MessageBox.Show("Minimum value can't be greater than Max value");
            }
            else
            {
                try
                {
                    Product product = new Product(int.Parse(tb_productId.Text), tb_productName.Text, decimal.Parse(tb_productPrice.Text), int.Parse(tb_productInventory.Text), int.Parse(tb_productMin.Text), int.Parse(tb_productMax.Text));
                    try
                    {
                        foreach (DataGridViewRow r in dg_associatedParts.Rows)
                        {
                            Part p = (Part)r.DataBoundItem;
                            product.AssociatedParts.Add(p);
                        }
                    }
                    catch 
                    {
                        throw;
                    }
                    Inventory.AddProduct(product);
                }
                catch (Exception)
                {
                    MessageBox.Show("An error has occurred while adding product. Please try again.");
                    throw;
                }

                this.Close();
            }
        }

        // Closes Add Product Window
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // searches parts datagridview
        private void btn_SearchAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int SearchID = int.Parse(tb_SearchPartsTable.Text);
                Part partFound = Inventory.GetPart(SearchID);

                foreach (DataGridViewRow r in dg_candidateParts.Rows)
                {
                    Part p = (Part)r.DataBoundItem;
                    if (p.PartId == partFound.PartId)
                    {
                        r.Selected = true;
                        dg_candidateParts.CurrentCell = r.Cells[0];

                        break;

                    }
                    else
                    {
                        r.Selected = false;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Part not found.");
            }
        }

        private void digitKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void decimalKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if ((sender as TextBox).Text.IndexOf('.') > -1 && (e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }
    }
}
