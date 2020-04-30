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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
       
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        double money, pay, outcome;
        private void button1_Click(object sender, EventArgs e)
        {
            money = double.Parse(textBox4.Text);
            pay = double.Parse(textBox5.Text);
            double outcome;

            if (pay < money)
            {
                textBox1.Text = "  เงินที่กรอกชำระน้อยเกินไปจ้าา  ";
            }
            else 
            {
                outcome = pay - money;
                textBox1.Text = "เงินทอน" + "  " + outcome.ToString("#,##0.00") + "  " + "บาทจ้า";
            }

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
   
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("กรุณากรอกเป็นตัวเลขจ้าา");
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
