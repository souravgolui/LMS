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
    public partial class MemberPage : Form
    {

      //Object of TAB
       public MemberHome memberHome = new MemberHome();
       public Search search = new Search();
        public MemberPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel12_Click(object sender, EventArgs e)
        {
            if (panel2.Width == 50)
            {
                panel2.Width = 264;
                panel12.Visible = false;
                panel13.Visible = true;
                panel14.Visible = false;
                panel22.Visible = true;

                panel3.Width = 264;
                panel4.Width = 264;
                panel5.Width = 264;
                panel6.Width = 264;
                panel7.Width = 264;
                panel8.Width = 264;
                panel9.Width = 264;
            }
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            if (panel2.Width == 264)
            {
                panel2.Width = 50;
                panel12.Visible = true;
                panel13.Visible = false;
                panel14.Visible = true;
                panel22.Visible = false;

            }
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            if (panel2.Width == 50) {
                panel9.Width = 50;

            }
            else
            {
                panel9.Width = 264;
            }
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            if (panel2.Width == 50)
            {
                panel8.Width = 50;

            }
            else
            {
                panel9.Width = 264;
            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            if (panel2.Width == 50)
            {
                panel7.Width = 50;

            }
            else
            {
                panel9.Width = 264;
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            if (panel2.Width == 50)
            {
                panel6.Width = 50;

            }
            else
            {
                panel9.Width = 264;
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            if (panel2.Width == 50)
            {
                panel5.Width = 50;

            }
            else
            {
                panel9.Width = 264;
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            if (panel2.Width == 50)
            {
                panel4.Width = 50;

            }
            else
            {
                panel9.Width = 264;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            if (panel2.Width == 50)
            {
                panel3.Width = 50;

            }
            else
            {
                panel9.Width = 264;
            }
        }
        Point lastclick;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastclick = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastclick.X;
                this.Top += e.Y - lastclick.Y;
            }
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            panel3.BackColor = Color.DarkCyan;
        }

        private void panel4_MouseHover(object sender, EventArgs e)
        {
            panel4.BackColor = Color.DarkCyan;
        }

        private void panel5_MouseHover(object sender, EventArgs e)
        {
            panel5.BackColor = Color.DarkCyan;
        }

        private void panel6_MouseHover(object sender, EventArgs e)
        {
            panel6.BackColor = Color.DarkCyan;
        }

        private void panel7_MouseHover(object sender, EventArgs e)
        {
            panel7.BackColor = Color.DarkCyan;
        }

        private void panel8_MouseHover(object sender, EventArgs e)
        {
            panel8.BackColor = Color.DarkCyan;
        }

        private void panel9_MouseHover(object sender, EventArgs e)
        {
            panel9.BackColor = Color.DarkCyan;
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.Teal;
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Teal;
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = Color.Teal;
        }

        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            panel6.BackColor = Color.Teal;
        }

        private void panel7_MouseLeave(object sender, EventArgs e)
        {
            panel7.BackColor = Color.Teal;
        }

        private void panel8_MouseLeave(object sender, EventArgs e)
        {
            panel8.BackColor = Color.Teal;
        }

        private void panel9_MouseLeave(object sender, EventArgs e)
        {
            panel9.BackColor = Color.Teal;
        }

        private void label9_MouseDown(object sender, MouseEventArgs e)
        {
            lastclick = e.Location;
        }

        private void label9_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastclick.X;
                this.Top += e.Y - lastclick.Y;
            }
        }

        private void panel23_MouseDown(object sender, MouseEventArgs e)
        {
            lastclick = e.Location;
        }

        private void panel23_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastclick.X;
                this.Top += e.Y - lastclick.Y;
            }
        }

        private void panel15_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.TopLevel = false;
            search.AutoScroll = true;
            Body.Controls.Add(search);
            search.Dock = DockStyle.Fill;
            search.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void Body_Click(object sender, EventArgs e)
        {

        }

        private void panel15_Click_1(object sender, EventArgs e)
        {

            memberHome.Hide();
           
            search.TopLevel = false;
            search.AutoScroll = true;
            Body.Controls.Add(search);
            search.Dock = DockStyle.Fill;
            search.Show();
        }

        private void Body_Paint(object sender, PaintEventArgs e)
        {

            memberHome.TopLevel = false;
            memberHome.AutoScroll = true;
            Body.Controls.Add(memberHome);
            memberHome.Dock = DockStyle.Fill;
            memberHome.Show();

        }

        private void label10_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            

        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
