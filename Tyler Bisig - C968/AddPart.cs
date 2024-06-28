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
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();

        }
        // Checks to see if InHouse radio button is selected
        private void rb_inHouse_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_inHouse.Checked)
            {
                label8.Text = "Machine ID";
            }
        }
        // Checks to see if Outsourced radio button is selected 
        private void rb_outsourced_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_outsourced.Checked)
            {
                label8.Text = "Company Name";
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            savePart();
        }
        
        /* 
         * validates entries are within boundaries and all fields are filled out.
         * saved part as inhouse or outsourced depending on which radio button is selected. 
         */
        private void savePart()
        {
            if (rb_inHouse.Checked)
            {
                InHouse inHousePart = new InHouse(Inventory.Parts.Count + 1, tb_partName.Text, decimal.Parse(tb_partValue.Text), int.Parse(tb_partInventory.Text), int.Parse(tb_partMin.Text), int.Parse(tb_partMax.Text), int.Parse(tb_partVariable.Text));
                // Checks to see if there are any empty text fields
                if (string.IsNullOrWhiteSpace(tb_partName.Text) || string.IsNullOrWhiteSpace(tb_partInventory.Text) ||
                    string.IsNullOrWhiteSpace(tb_partValue.Text) || string.IsNullOrWhiteSpace(tb_partMin.Text) ||
                    string.IsNullOrWhiteSpace(tb_partMax.Text) || string.IsNullOrWhiteSpace(tb_partVariable.Text))
                {
                    MessageBox.Show("All text fields must be filled out.");
                    return;
                }
                // Checks inventory count falls between the scope of max and min
                if (int.Parse(tb_partInventory.Text) > int.Parse(tb_partMax.Text) || int.Parse(tb_partMin.Text) > int.Parse(tb_partInventory.Text))
                {
                    MessageBox.Show("Inventory must be greater than minimum and less than maximum.");
                    return;
                }
                if (int.Parse(tb_partMin.Text) > int.Parse(tb_partMax.Text))
                {
                    MessageBox.Show("Minimum value can't be greater than Max value");
                }
                else
                {
                    Inventory.AddPart(inHousePart);
                    this.Close();
                }
            } 
            else
            {
                rb_outsourced.Checked = true;
                Outsourced outsourcedPart = new Outsourced(Inventory.Parts.Count + 1, tb_partName.Text, decimal.Parse(tb_partValue.Text), int.Parse(tb_partInventory.Text), int.Parse(tb_partMin.Text), int.Parse(tb_partMax.Text), tb_partVariable.Text);

                if (string.IsNullOrWhiteSpace(tb_partName.Text) || string.IsNullOrWhiteSpace(tb_partInventory.Text) ||
                    string.IsNullOrWhiteSpace(tb_partValue.Text) || string.IsNullOrWhiteSpace(tb_partMin.Text) ||
                    string.IsNullOrWhiteSpace(tb_partMax.Text) || string.IsNullOrWhiteSpace(tb_partVariable.Text))
                {
                    MessageBox.Show("All text fields must be filled out.");
                    return;
                }
                // Checks inventory count falls between the scope of max and min
                if (int.Parse(tb_partInventory.Text) > int.Parse(tb_partMax.Text) || int.Parse(tb_partMin.Text) > int.Parse(tb_partInventory.Text))
                {
                    MessageBox.Show("Inventory must be greater than minimum and less than maximum.");
                    return;
                }
                if (int.Parse(tb_partMin.Text) > int.Parse(tb_partMax.Text))
                {
                    MessageBox.Show("Minimum value can't be greater than Max value");
                }
                else
                {
                    Inventory.AddPart(outsourcedPart);
                    this.Close();
                }
            }
        }
        
        // Closes Add Part Window
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
