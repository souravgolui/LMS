using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;


namespace LibraryManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }

        

        
        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text =="User ID") {
                label2.Visible = true;
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label2.Visible = false;
                textBox1.Text = "User ID";
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {   
                
                label3.Visible = true;
                textBox2.Text = "";
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.UseSystemPasswordChar = false;
                label3.Visible = false;
                textBox2.Text = "Password";
                
            }
        }
        Point lastClick;
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            NewUser nu = new NewUser();
            nu.Show();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Home hm = new Home();
            hm.Show();
        }
        SpeechSynthesizer sp = new SpeechSynthesizer();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Sourav" && textBox2.Text == "Password" ) {

                label6.Text = "Please Fill the password field";
            }
            else if(textBox1.Text == "User ID" && textBox2.Text == "Sourav")
            {
                label6.Text = "Please enter user ID";
            }
            else if(textBox1.Text == "User ID" && textBox2.Text == "Password")
            {
                label6.Text = "Please enter user ID and password";
            }
            else
            {
                label6.Text = "Thanking You!";
            }


            if(label6.Text != null)
            {
                sp.Dispose();
                sp = new SpeechSynthesizer();
                sp.SpeakAsync(label6.Text);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
