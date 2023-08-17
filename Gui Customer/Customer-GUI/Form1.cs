using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void light_Click(object sender, EventArgs e)
        {
            if (light.Text == "Light mode."){
                light.Text = "Dark mode.";
                set_light("dark");
            }
            else
            {
                light.Text = "Light mode.";
                set_light("Light.");
            }
        }
        private void set_light(string x)
        {
            if (x == "Light.")
            {
                groupBox1.ForeColor = Color.Black;
                groupBox2.ForeColor = Color.Black;
                Logss.ForeColor = Color.Black;
                Machinecount.ForeColor = Color.Black;

                button4.BackColor = Color.White;
                button2.BackColor = Color.White;
                Logs.BackColor = Color.White;

                Logcount.ForeColor = Color.Black;
                passwordcount.ForeColor = Color.Black;

                BackColor = Color.White;
                light.ForeColor = Color.Black;
                light.BackColor = Color.White;

            }
            else
            {
                groupBox1.ForeColor = Color.White;

                button4.BackColor = Color.Black;
                button2.BackColor = Color.Black;
                Logs.BackColor = Color.Black;
                Attack_btn.ForeColor = Color.Black;

                groupBox2.ForeColor = Color.White;
                Logss.ForeColor = Color.White;
                Machinecount.ForeColor = Color.White;
                Logcount.ForeColor = Color.White;
                passwordcount.ForeColor = Color.White;
                BackColor = Color.Black;
                light.ForeColor = Color.White;
                light.BackColor = Color.Black;
            }
        }

        private void Exitbutton_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
        }

        private void Logs_click(object sender, EventArgs e)
        {
            if (Logss.Visible)
            {
                Logss.Visible = false;
            }
            else
            {
                Logss.Visible = true;
                groupBox1.Visible = false;
                groupBox2.Visible = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (groupBox1.Visible)
            {
                groupBox1.Visible = false;
            }
            else
            {
                groupBox1.Visible = true;
                Logss.Visible = false;
                groupBox2.Visible = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DDos_click(object sender, EventArgs e)
        {
            if (groupBox2.Visible)
            {
                groupBox2.Visible = false;
            }
            else
            {
                groupBox2.Visible = true;
                Logss.Visible = false;
                groupBox1.Visible = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void HWID1LABEL_Click(object sender, EventArgs e)
        {

        }
    }
}
