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
    public partial class frmQ2 : Form
    {
        public frmQ2()
        {
            InitializeComponent();
        }

       

        private void btnNext_Click(object sender, EventArgs e)
        {
            frmQ3 fm3 = new frmQ3();
            fm3.Show();
            this.Hide();
        }

       
    }
}
