using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gameShop.Controls;
using Help = gameShop.Controls.Help;

namespace gameShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
          
        }

        private void Bclose_MouseLeave(object sender, EventArgs e)
        {
            Bclose.ForeColor =Color.White;  Bclose.ForeColor =Color.Brown;
        }

        Point lastPoint;
        private void top_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void top_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        
        private void adduserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            container.Controls.Clear();
            container.Controls.Add(userControl);
            userControl.BringToFront();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            adduserControl(h);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Games g = new Games();
            adduserControl(g);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Community c = new Community();
            adduserControl(c);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Categories c = new Categories();
            adduserControl(c);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Help h = new Help();
            adduserControl(h);
        }


        private void Bclose_MouseMove(object sender, MouseEventArgs e)
        {
            Bclose.ForeColor =Color.Brown; 
        }


        private void Bclose_MouseLeave_1(object sender, EventArgs e)
        {
            Bclose.ForeColor =Color.White; 
        }


        private void Bclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}