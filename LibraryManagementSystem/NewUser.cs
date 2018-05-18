using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Speech;
using System.Speech.Synthesis;

namespace LibraryManagementSystem
{
    public partial class NewUser : Form
    {


        SpeechSynthesizer ss = new SpeechSynthesizer();
        public NewUser()
        {
            InitializeComponent();
            this.ActiveControl = label11;
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewUser_Load(object sender, EventArgs e)
        {

        }
        //Click Event Start ........................................
        private void textBox1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "First Name")
            {
                label3.Visible = true;
                textBox1.Text = "";
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Last Name")
            {
                label4.Visible = true;
                textBox2.Text = "";
            }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "Email")
            {
                label5.Visible = true;
                textBox3.Text = "";
            }
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "Contact No")
            {
                label6.Visible = true;
                textBox4.Text = "";
            }
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "Password")
            {
                label7.Visible = true;
                textBox5.Text = "";
                textBox5.UseSystemPasswordChar = true;
            }
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "Confirm Password")
            {
                label8.Visible = true;
                textBox6.Text = "";
                textBox6.UseSystemPasswordChar = true;

            }
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "Gender")
            {
                label9.Visible = true;
                textBox7.Text = "";
                
            }
        }

        private void textBox8_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == "Address")
            {
                label10.Visible = true;
                textBox8.Text = "";
            }
        }

        
        // Leav Event Start....................................................
         private void textBox1_Leave(object sender, EventArgs e)
         {
             if (textBox1.Text == "")
             {
                 label3.Visible = false;
                 textBox1.Text = "First Name";
             }
         }

         private void textBox2_Leave(object sender, EventArgs e)
         {
             if (textBox2.Text == "")
             {
                 label4.Visible = false;
                 textBox2.Text = "Last Name";
             }
         }

         private void textBox3_Leave(object sender, EventArgs e)
         {
             if (textBox3.Text == "")
             {
                 label5.Visible = false;
                 textBox3.Text = "Email";
             }

            String email = textBox3.Text;
            if(email.IndexOf('@')==-1 || email.IndexOf('.') == -1 )
            {
                label13.Text = "Invalid Email";
                label13.ForeColor = Color.White;
                label13.BackColor = Color.Red;
                ss.Dispose();
                ss = new SpeechSynthesizer();
                ss.SpeakAsync("Please enter a valid email address.");
            }

            else if(textBox3.Text == "Email")
            {
                label13.Text = null;
            }
            else {
                label13.Text = null;
            }


     
            

        }

         private void textBox4_Leave(object sender, EventArgs e)
         {
             if (textBox4.Text == "")
             {
                 label6.Visible = false;
                 textBox4.Text = "Contact No";
             }
         }

         private void textBox5_Leave(object sender, EventArgs e)
         {
             if (textBox5.Text == "")
             {
                 label7.Visible = false;
                 textBox5.Text = "Password";
                 textBox5.UseSystemPasswordChar = false;
             }

            if (label15.Text == "Weak")
            {
                ss.Dispose();
                ss = new SpeechSynthesizer();
                ss.SpeakAsync("Your passwors is soo weak, please enter a good password");
        }
        }

         private void textBox6_Leave(object sender, EventArgs e)
         {
             if (textBox6.Text == "")
             {
                 label8.Visible = false;
                 textBox6.Text = "Confirm Password";
                 textBox6.UseSystemPasswordChar = false;

             }

             if(label16.Text == "Not Match")
            {
                ss.Dispose();
                ss = new SpeechSynthesizer();
                ss.SpeakAsync("Your confirm password are not matched Please re-enter the password ");
            }
         }

         private void textBox7_Leave(object sender, EventArgs e)
         {
             if (textBox7.Text == "")
             {
                 label9.Visible = false;
                 textBox7.Text = "Gender";

             }
         }

         private void textBox8_Leave(object sender, EventArgs e)
         {
             if (textBox8.Text == "")
             {
                 label10.Visible = false;
                 textBox8.Text = "Address";
             }
         }

        private void textBox5_KeyUp(object sender, KeyEventArgs e)
        {
            int a = textBox5.TextLength;

            if (a < 7)
            {
                label15.Text = "Weak";
                label15.ForeColor = Color.White;
                label15.BackColor = Color.Red;
            }
            else if (a < 13)
            {
                label15.Text = "Good";
                label15.ForeColor = Color.White;
                label15.BackColor = Color.LightBlue;
            }
            else
            {
                label15.Text = "Strong";
                label15.ForeColor = Color.White;
                label15.BackColor = Color.YellowGreen;
            }
            
              
        }

        private void textBox6_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox5.Text == textBox6.Text)
            {
                label16.Text = "Matched";
                label16.BackColor = Color.Green;
                label16.ForeColor = Color.White;
            }
            else
            {
                label16.Text = "Not Match";
                label16.BackColor = Color.Red;
                label16.ForeColor = Color.White;
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="First Name") {
                label11.Text = "Enter First Name";
                label11.ForeColor = Color.White;
                label11.BackColor = Color.Red;
            }
            else
            {
                label11.Text = null;
            }
            if (textBox2.Text == "Last Name")
            {
                label12.Text = "Enter Last Name";
                label12.ForeColor = Color.White;
                label12.BackColor = Color.Red;
            }
            else
            {
                label12.Text = null;
            }
            if (textBox3.Text == "Email")
            {
                label13.Text = "Enter Email";
                label13.ForeColor = Color.White;
                label13.BackColor = Color.Red;
            }
            else
            {
                label13.Text = null;
            }
            if (textBox4.Text == "Contact No")
            {
                label14.Text = "Enter Contact No";
                label14.ForeColor = Color.White;
                label14.BackColor = Color.Red;
            }
            else
            {
                label14.Text = null;
            }
            if (textBox5.Text == "Password")
            {
                label15.Text = "Enter Password";
                label15.ForeColor = Color.White;
                label15.BackColor = Color.Red;
            }
            else
            {
                label15.Text = null;
            }
            if (textBox6.Text == "Confirm Password")
            {
                label16.Text = "Enter Confirm Password";
                label16.ForeColor = Color.White;
                label16.BackColor = Color.Red;
            }
            else
            {
                label16.Text = null;
            }
            if (textBox7.Text == "Gender")
            {
                label17.Text = "Enter Gender";
                label17.ForeColor = Color.White;
                label17.BackColor = Color.Red;
            }
            else
            {
                label17.Text = null;
            }
            if (textBox8.Text == "Address")
            {
                label18.Text = "Enter Address";
                label18.ForeColor = Color.White;
                label18.BackColor = Color.Red;
            }
            else
            {
                label18.Text = null;
            }

        }

       

        private void panel9_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Home hm = new Home();
            hm.Show();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        Point lastClick;
        private void NewUser_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;

        }

        private void NewUser_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }

        private void panel10_MouseDown(object sender, MouseEventArgs e)
        {

            lastClick = e.Location;

        }

        private void panel10_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }

        private void panel11_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }

        private void panel11_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }
    }
}
