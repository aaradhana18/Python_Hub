using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Python_Hub
{
    public partial class RollCard : Form
    {
        public RollCard()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Admin_Login ad2 = new Admin_Login();
            this.Hide();
            ad2.Show();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Login l3 = new Login();
            this.Hide();
            l3.Show();
        }
    }
}
