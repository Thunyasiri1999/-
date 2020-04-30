using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
 
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                string sql = "SELECT * FROM emptable WHERE username = '" + textBox1.Text + "' AND password = '" + textBox2.Text + "'";

                MySqlConnection con = new MySqlConnection("host = localhost;user = tantim;password = 123456;database = employee");
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                this.Hide();
                MDIParent1 f2 = new MDIParent1();
                f2.Show();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SignUp f2 = new SignUp();
            f2.Show();
        }
    }
}
