using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized ;
        }

       // Make Draggable.......................................................................
        Point lastClick;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
            lastClick = e.Location; 

        }//End Of Make Draggable...............................................................



        private void panel5_MouseHover(object sender, EventArgs e)
        {
            panel5.BackColor = Color.Orchid;
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = Color.HotPink;
        }

        private void panel4_MouseHover(object sender, EventArgs e)
        {
            panel4.BackColor = Color.CornflowerBlue;
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.RoyalBlue;
        }
        private void panel2_MouseHover(object sender, EventArgs e)
        {
            panel2.BackColor = Color.MediumSeaGreen;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.SeaGreen;
        }
        private void panel3_MouseHover(object sender, EventArgs e)
        {
            panel3.BackColor =Color.DarkGray;
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.Gray;
        }

        private void panel2_Click(object sender, EventArgs e)// Login Button
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login logi = new Login();
            logi.Show();
        }//End of login

        private void label3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            NewUser nu = new NewUser();
            nu.Visible =true;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            NewUser nu = new NewUser();
            nu.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label8.Text = DateTime.Now.ToString("HH:mm");
            label9.Text = DateTime.Now.ToString("ss");
            label10.Text = DateTime.Now.ToString("MMM dd yyyy");
            label11.Text = DateTime.Now.ToString("dddd");
        }

        private void Home_Load(object sender, EventArgs e)
        {

            timer1.Start();
        }

     
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            MemberPage mp = new MemberPage();
            mp.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
