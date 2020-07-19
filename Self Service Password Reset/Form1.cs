using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace resetpassword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            sendcode sc = new sendcode();
            this.Hide();
            sc.Show();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=aa3ro;persistsecurityinfo=True;database=ssprsytem");  
            MySqlDataAdapter adp = new MySqlDataAdapter("select * from  tblForgetpass  where user_email='" + txtuser.Text + "' and password='"+txtpass.Text+"'", con);
            con.Open();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Sucessful");
            }
            else
            {
                MessageBox.Show("Login fail Error..try again");
            }
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
