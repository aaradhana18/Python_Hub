using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Python_Hub
{
    public partial class Admin_Login : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Documents\Python_Hub.mdf;Integrated Security=True;Connect Timeout=30");
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {
            Admin_Register al1 = new Admin_Register();
            this.Hide();
            al1.Show();
        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {
            Username.Text = "";
            Password.Text = "";
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select count (*) From Admin_Register Where Username='" + Username.Text + "'and Password='" + Password.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {

                Hide();
                Student_Profile f1 = new Student_Profile();
                f1.Show();
            }
            else
            {
                MessageBox.Show("Please Check your username and password!! ");
            }
        }
    }
}
