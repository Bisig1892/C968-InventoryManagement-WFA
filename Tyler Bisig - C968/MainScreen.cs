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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        // opens Add Part Window
        private void btn_addPart_Click(object sender, EventArgs e)
        {
            AddPart frm = new AddPart();
            frm.Show();
        }
        // opens Modify Part Window
        private void btn_editPart_Click(object sender, EventArgs e)
        {
            EditPart frm = new EditPart();
            frm.Show();
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
