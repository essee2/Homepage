using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Forms.VisualStyles;

namespace Homepage
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nWeightEllipse

        );

        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnUser.Height;
            pnlNav.Top = btnUser.Top;
            btnUser.BackColor = Color.FromArgb(46, 51, 73);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnApp.Height;
            pnlNav.Top = btnApp.Top;
            btnApp.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnHis_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnHis.Height;
            pnlNav.Top = btnHis.Top;
            btnHis.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnUser_Leave(object sender, EventArgs e)
        {
            btnUser.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnApp_Leave(object sender, EventArgs e)
        {
            btnApp.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnHis_Leave(object sender, EventArgs e)
        {
            btnHis.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {
            btnsearch.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            btnlogout.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnlogout_Leave(object sender, EventArgs e)
        {
            btnlogout.BackColor = Color.DodgerBlue;
        }

        private void btnlogout_Enter(object sender, EventArgs e)
        {
            btnlogout.BackColor = Color.LightSkyBlue;
        }

        private void btnsearch_Click_1(object sender, EventArgs e)
        {
            pnlNav.Height = btnsearch.Height;
            pnlNav.Top = btnsearch.Top;
            btnsearch.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnsearch_Enter(object sender, EventArgs e)
        {
            btnsearch.BackColor = Color.LightSkyBlue;
        }

        private void btnsearch_Leave(object sender, EventArgs e)
        {
            btnsearch.BackColor = Color.DodgerBlue;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
