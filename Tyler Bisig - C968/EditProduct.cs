using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyler_Bisig___C968
{
    public partial class EditProduct : Form
    {

        Product product = new Product();
        Inventory inventory = new Inventory();

        public BindingList<Part> tempPart = new BindingList<Part>();
        public EditProduct(Product product)
        {
            InitializeComponent();
            LoadEditProduct(product);
        }

        public void LoadEditProduct(Product product)
        {
            var CandidatePart = new BindingSource();
            var AssociatedPart = new BindingSource();

            CandidatePart.DataSource = Inventory.Parts;
            AssociatedPart.DataSource = tempPart;

            dg_candidateParts.DataSource = CandidatePart;
            dg_associatedParts.DataSource = AssociatedPart;
            dg_candidateParts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg_associatedParts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            tb_productId.Text = Convert.ToString(product.ProductId);
            tb_productName.Text = product.Name;
            tb_productInventory.Text = Convert.ToString(product.InStock);
            tb_productPrice.Text = Convert.ToString(product.Price);
            tb_productMax.Text = Convert.ToString(product.Max);
            tb_productMin.Text  = Convert.ToString(product.Min);

            foreach (Part part in product.AssociatedParts)
            {
                tempPart.Add(part);
            }
        }

        // Adds selected part to product
        private void btn_AddPartToProduct_Click(object sender, EventArgs e)
        {
            if (dg_candidateParts.CurrentRow == null || !dg_candidateParts.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a part to add.");
            }
            else
            {
                Part addPart = (Part)dg_candidateParts.CurrentRow.DataBoundItem;
                tempPart.Add(addPart);
            }
        }
        // Deletes selected part from product
        private void btn_DeletePartFromProduct_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this part from the product?", "Delete?", MessageBoxButtons.YesNo);
            {
                if (confirm == DialogResult.Yes)
                {
                    foreach (DataGridViewRow r in dg_associatedParts.SelectedRows)
                    {
                        dg_associatedParts.Rows.RemoveAt(r.Index);
                    }
                }
                else return;
            }
        }
        // Saves Product
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
                        foreach (Part addPart in tempPart)
                        {
                            product.addAssociatedPart(addPart);
                        }
                        Inventory.UpdateProduct(int.Parse(tb_productId.Text), product);
                    }
                    catch
                    {
                        throw;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("An error has occurred while updating the product. Please try again.");
                    throw;
                }

                this.Close();
            }
        }

        // Closes Modify Product Window
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_SearchProduct_Click(object sender, EventArgs e)
        {
            string searchValue = tb_SearchPartsTable.Text.ToLower();

            dg_candidateParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            try
            {
                foreach (DataGridViewRow r in dg_candidateParts.Rows)
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
