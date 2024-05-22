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

        private void AddPart_Load(object sender, EventArgs e)
        {

        }
        // Closes Add Part Window
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
