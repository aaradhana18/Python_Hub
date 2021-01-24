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
    public partial class Admin_Register : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Documents\Python_Hub.mdf;Integrated Security=True;Connect Timeout=30");
        public Admin_Register()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Admin_Register values('" + Name1.Text + "','" + Phoneno.Text + "','" + Username.Text + "','" + Password.Text + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("User Details Successfully added");
            Con.Close();
            Login l2 = new Login();
            this.Hide();
            l2.Show();
        }

        private void bunifuCustomLabel8_Click(object sender, EventArgs e)
        {
            Name1.Text = "";
            Phoneno.Text = "";
            Username.Text = "";
            Password.Text = "";
        }
    }
}
