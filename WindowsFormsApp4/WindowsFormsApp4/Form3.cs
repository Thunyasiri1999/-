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
    public partial class Form3 : Form
    {
        Form4 f2 = new Form4();
        public Form3()
        {
            InitializeComponent();
        }
        double price = 0, total = 0, vat = 0;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            price = 0;
            int a1 = 0, a2 = 0, a3 = 0, a4 = 0, a5 = 0, a6 = 0, a7 = 0, a8 = 0, a9 = 0, a10 = 0, a11 = 0, a12 = 0, a13 = 0, a14 = 0, a15 = 0, a16 = 0, a17 = 0, a18 = 0;
            if (checkBox1.Checked)
            {
                a1 = 85 * (int)numericUpDown1.Value;
                price += a1;
            }
            if (checkBox2.Checked)
            {
                a2 = 80 * (int)numericUpDown2.Value;
                price += a2;
            }
            if (checkBox3.Checked)
            {
                a3 = 50 * (int)numericUpDown3.Value;
                price += a3;
            }
            if (checkBox4.Checked)
            {
                a4 = 65 * (int)numericUpDown4.Value;
                price += a4;
            }
            if (checkBox5.Checked)
            {
                a5 = 70 * (int)numericUpDown5.Value;
                price += a5;
            }
            if (checkBox6.Checked)
            {
                a6 = 65 * (int)numericUpDown6.Value;
                price += a6;
            }
            if (checkBox7.Checked)
            {
                a7 = 60 * (int)numericUpDown7.Value;
                price += a7;
            }
            if (checkBox8.Checked)
            {
                a8 = 55 * (int)numericUpDown8.Value;
                price += a8;
            }
            if (checkBox9.Checked)
            {
                a9 = 55 * (int)numericUpDown9.Value;
                price += a9;
            }
            if (checkBox10.Checked)
            {
                a10 = 35 * (int)numericUpDown10.Value;
                price += a10;
            }
            if (checkBox11.Checked)
            {
                a11 = 50 * (int)numericUpDown11.Value;
                price += a11;
            }
            if (checkBox12.Checked)
            {
                a12 = 15 * (int)numericUpDown12.Value;
                price += a12;
            }
            if (checkBox13.Checked)
            {
                a13 = 60 * (int)numericUpDown13.Value;
                price += a13;
            }
            if (checkBox14.Checked)
            {
                a14 = 50 * (int)numericUpDown14.Value;
                price += a14;
            }
            if (checkBox15.Checked)
            {
                a15 = 40 * (int)numericUpDown15.Value;
                price += a15;
            }
            if (checkBox16.Checked)
            {
                a16 = 40 * (int)numericUpDown16.Value;
                price += a16;
            }
            if (checkBox17.Checked)
            {
                a17 = 40 * (int)numericUpDown17.Value;
                price += a17;
            }
            if (checkBox18.Checked)
            {
                a18 = 50 * (int)numericUpDown18.Value;
                price += a18;
            }
            textBox19.Text = price.ToString("#,##0.00");
            textBox1.Text = "ต้มยำกุ้ง"+"           " + numericUpDown1.Value.ToString() + "\r\n" + "แกงส้มกุ้ง" + "          " + numericUpDown2.Value.ToString() + "\r\n" + "แกงจืด " + "           " + numericUpDown3.Value.ToString() + "\r\n" + "แกงไตปลา " + "        " + numericUpDown4.Value.ToString() + "\r\n" + "แกงฮังเล " + "          " + numericUpDown5.Value.ToString() + "\r\n" + "แกงเขียวหวาน " + "      " + numericUpDown6.Value.ToString() + "\r\n" + "ข้าวคลุกกะปิ" + "        " + numericUpDown7.Value.ToString() + "\r\n" + "ข้างกะเพราไข่ดาว " + "   " + numericUpDown8.Value.ToString() + "\r\n" + "ข้าวมันไก่" + "          " + numericUpDown9.Value.ToString() + "\r\n" + "ข้าวไข่เจียว " + "        " + numericUpDown10.Value.ToString() + "\r\n" + "ข้าวผัด " + "           " + numericUpDown11.Value.ToString() + "\r\n" + "ข้าวเปล่า " + "         " + numericUpDown12.Value.ToString() + "\r\n" + "ข้าวเหนียวมะม่วง" + "    " + numericUpDown13.Value.ToString() + "\r\n" + "บัวลอย" + "           " + numericUpDown14.Value.ToString() + "\r\n" + "ขนมถ้วย" + "           " + numericUpDown15.Value.ToString() + "\r\n" + "ลูกชุบ" + "             " + numericUpDown16.Value.ToString() + "\r\n" + "ขนมไทย" + "           " + numericUpDown17.Value.ToString() + "\r\n" + "ช่อม่วง" + "            " + numericUpDown18.Value.ToString();
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged(sender, e);
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged(sender, e);
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged(sender, e);
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged(sender, e);
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged(sender, e);
        }
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged(sender, e);
        }
        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged(sender, e);
        }
        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged(sender, e);
        }
        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged(sender, e);
        }
        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged(sender, e);
        }
        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged(sender, e);
        }
        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged(sender, e);
        }
        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged(sender, e);
        }
        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged(sender, e);
        }
        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged(sender, e);
        }
        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged(sender, e);
        }
        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged(sender, e);
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged(sender, e);
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged(sender, e);
        }
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged(sender, e);
        }
        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged(sender, e);
        }
        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged(sender, e);
        }
        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged(sender, e);
        }
        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged(sender, e);
        }
        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged(sender, e);
        }
        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged(sender, e);
        }
        private void numericUpDown10_ValueChanged(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged(sender, e);
        }
        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged(sender, e);
        }
        private void numericUpDown12_ValueChanged(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged(sender, e);
        }
        private void numericUpDown13_ValueChanged(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged(sender, e);
        }
        private void numericUpDown14_ValueChanged(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged(sender, e);
        }
        private void numericUpDown15_ValueChanged(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged(sender, e);
        }
        private void numericUpDown16_ValueChanged(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged(sender, e);
        }
        private void numericUpDown17_ValueChanged(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged(sender, e);
        }
        private void numericUpDown18_ValueChanged(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged(sender, e);
        }
        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            vat = price * 7 / 100;
            total = price + vat;
            textBox19.Text = price.ToString("#,##0.00");
            textBox20.Text = vat.ToString("#,##0.00");
            textBox21.Text = total.ToString("#,##0.00");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox19.Text = "0.00";
            textBox20.Text = "0.00";
            textBox21.Text = "0.00";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;
            numericUpDown6.Value = 0;
            numericUpDown7.Value = 0;
            numericUpDown8.Value = 0;
            numericUpDown9.Value = 0;
            numericUpDown10.Value = 0;
            numericUpDown11.Value = 0;
            numericUpDown12.Value = 0;
            numericUpDown13.Value = 0;
            numericUpDown14.Value = 0;
            numericUpDown15.Value = 0;
            numericUpDown16.Value = 0;
            numericUpDown17.Value = 0;
            numericUpDown18.Value = 0;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                f2.Show();
                f2.textBox3.Text = textBox1.Text;
                f2.textBox4.Text = textBox21.Text;

            }
        }


    }

}
