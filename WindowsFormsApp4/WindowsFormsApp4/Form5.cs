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

namespace WindowsFormsApp4
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM emptable" ;
            sql = "INSERT INTO emptable (Password,Username) VALUES ('" + textBox2.Text + " ',' "+textBox1.Text+"')"; 

            MySqlConnection con = new MySqlConnection("host = localhost;user = tantim;password = 123456;database = employee");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            /*MySqlDataReader reader = cmd.ExecuteReader();
           
            while (reader.Read())
            {
                this.Hide();
                MDIParent1 f2 = new MDIParent1();
                f2.Show();
            }*/
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" SignUp เรียบร้อยแล้ว ");
        }
    }
}
