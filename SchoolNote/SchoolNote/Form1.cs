using SchoolNote.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolNote
{
    public partial class Form1 : Form
    {
        Point lastPoint;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username , password;
            username= textBox1.Text; 
            password= textBox2.Text;

            if (username == "Dragos" && password == "florinicA05")
            {
                MessageBox.Show("Richtig!");
                this.Hide();
                DarkMain dm = new DarkMain();
                dm.Show();
            }
            else
            {
                 if (username == "/Anwender" && password == "xxx")
                    {
                        MessageBox.Show("Richtig!");
                        this.Hide();
                    DarkMain dm =new DarkMain();
                    dm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Falsch!");
                    }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HelpDarkClass hdc = new HelpDarkClass();
            hdc.Show();
        }
    }
}
