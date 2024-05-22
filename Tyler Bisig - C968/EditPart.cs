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

        private void EditPart_Load(object sender, EventArgs e)
        {

        }
        // Closes Edit Part window
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
