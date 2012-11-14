using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmQ1 : Form
    {
        public frmQ1()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            frmQ2 fm2 = new frmQ2();            
            fm2.Show();
            this.Hide();
        }

        private void rbHigh_CheckedChanged(object sender, EventArgs e)
        {

        }

       
    }
}
