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
    public partial class frmQ3 : Form
    {
        public frmQ3()
        {
            InitializeComponent();
        }

      

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            frmQ4 fm = new frmQ4();
            fm.Show();
            this.Hide();
        }

       
    }
}
