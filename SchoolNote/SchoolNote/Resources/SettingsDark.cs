using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolNote.Resources
{
    public partial class SettingsDark : Form
    {
        public SettingsDark()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Work in progress!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Work in progress!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Work in progress!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Work in progress!");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Klausur Mode wurde aktiviert,bei jeden schummeln versuch wird die klausur abgegeben!");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DarkMain dmc = new DarkMain();
            dmc.Close();

            DarkMain dm = new DarkMain();
            dm.Hide();
            dm.Show();

            
        }

        private void SettingsDark_Load(object sender, EventArgs e)
        {

        }
    }
}
