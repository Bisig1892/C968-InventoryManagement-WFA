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
    public partial class EditPart : Form
    {
        public EditPart()
        {
            InitializeComponent();
        }

        public EditPart(InHouse inHouse)
        {
            InitializeComponent();

            rb_inHouse.Checked = true;
            
            tb_partID.Text = Convert.ToString(inHouse.PartId);
            tb_partName.Text = inHouse.Name;
            tb_partInventory.Text = Convert.ToString(inHouse.InStock);
            tb_partValue.Text = Convert.ToString(inHouse.InStock);
            tb_partMax.Text = Convert.ToString(inHouse.Max);
            tb_partMin.Text = Convert.ToString(inHouse.Min);
            tb_partVariable.Text = Convert.ToString(inHouse.MachineId);

            int PartIndex = inHouse.PartId;
        }

        public EditPart(Outsourced outsourced)
        {
            InitializeComponent();

            rb_outsourced.Checked = true;

            tb_partID.Text = Convert.ToString(outsourced.PartId);
            tb_partName.Text = outsourced.Name;
            tb_partInventory.Text = Convert.ToString(outsourced.InStock);
            tb_partValue.Text = Convert.ToString(outsourced.InStock);
            tb_partMax.Text = Convert.ToString(outsourced.Max);
            tb_partMin.Text = Convert.ToString(outsourced.Min);
            tb_partVariable.Text = Convert.ToString(outsourced.CompanyName);

            int PartIndex = outsourced.PartId;
        }

        private void EditPart_Load(object sender, EventArgs e)
        {

        }
        // Closes Edit Part window
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rb_inHouse_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_inHouse.Checked)
            {
                label8.Text = "Machine ID";
            }
        }

        private void rb_outsourced_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_outsourced.Checked)
            {
                label8.Text = "Company Name"; 
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (rb_inHouse.Checked)
            {
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
                    InHouse inHouse = new InHouse(int.Parse(tb_partID.Text), tb_partName.Text, decimal.Parse(tb_partValue.Text), int.Parse(tb_partInventory.Text), int.Parse(tb_partMin.Text), int.Parse(tb_partMax.Text), int.Parse(tb_partVariable.Text));
                    Inventory.UpdatePart(int.Parse(tb_partID.Text), inHouse);
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
                    Outsourced outsourced = new Outsourced(int.Parse(tb_partID.Text), tb_partName.Text, decimal.Parse(tb_partValue.Text), int.Parse(tb_partInventory.Text), int.Parse(tb_partMin.Text), int.Parse(tb_partMax.Text), tb_partVariable.Text);
                    Inventory.UpdatePart(int.Parse(tb_partID.Text), outsourced);
                }
            }
            this.Close();
        }
    }
}
