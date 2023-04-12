using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SchoolNote.Resources
{
    public partial class DarkMain : Form
    {
        
        public DarkMain()
        {
            InitializeComponent();
        }
        Point lastPoint;
        private void DarkMain_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string klausurmode;
            klausurmode = textBox2.Text;
            if (klausurmode == "AN")
            {
                MessageBox.Show("Sie wurden bei einen schummeln versuch erwischt!");
                Application.Exit();
            }
            else
            {
                if (klausurmode == "An")
                {
                    MessageBox.Show("Sie wurden bei einen schummeln versuch erwischt!");
                    Application.Exit();
                }
                else
                {
                    if (klausurmode == "an")
                    {
                        MessageBox.Show("Sie wurden bei einen schummeln versuch erwischt!");
                        Application.Exit();
                    }
                    else
                    {
                        if (klausurmode == "aN")
                        {
                            MessageBox.Show("Sie wurden bei einen schummeln versuch erwischt!");
                            Application.Exit();
                        }
                        else
                        {
                            WindowState = FormWindowState.Minimized;
                        }
                    }
                }

            }
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DarkMain_Load_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.Title = "Open";
                fastColoredTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(fastColoredTextBox1.Text);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fach;
            fach = textBox1.Text;

            if (fach == "Mathe")
            {
                fastColoredTextBox1.Text = File.ReadAllText($"./Dokumente/Mathe/{listBox1.SelectedItem}");
            }
            else
            {
                if (fach == "Deutsch")
                {
                    fastColoredTextBox1.Text = File.ReadAllText($"./Dokumente/Deutsch/{listBox1.SelectedItem}");
                }
                else
                {
                    if (fach == "English")
                    {
                        fastColoredTextBox1.Text = File.ReadAllText($"./Dokumente/English/{listBox1.SelectedItem}");
                    }
                    else
                    {
                        if (fach == "Wirtschaft")
                        {
                            fastColoredTextBox1.Text = File.ReadAllText($"./Dokumente/Wirtschaft/{listBox1.SelectedItem}");
                        }
                        else
                        {
                            if (fach == "IT")
                            {
                                fastColoredTextBox1.Text = File.ReadAllText($"./Dokumente/IT/{listBox1.SelectedItem}");
                            }
                            else
                            {
                                if (fach == "Politik")
                                {
                                    fastColoredTextBox1.Text = File.ReadAllText($"./Dokumente/Politik/{listBox1.SelectedItem}");
                                }
                                else
                                {
                                    if (fach == "Geschichte")
                                    {
                                        fastColoredTextBox1.Text = File.ReadAllText($"./Dokumente/Geschichte/{listBox1.SelectedItem}");
                                    }
                                    else
                                    {
                                        if (fach == "Religion")
                                        {
                                            fastColoredTextBox1.Text = File.ReadAllText($"./Dokumente/Religion/{listBox1.SelectedItem}");
                                        }
                                        else
                                        {
                                            if (fach == "WuN")
                                            {
                                                fastColoredTextBox1.Text = File.ReadAllText($"./Dokumente/WuN/{listBox1.SelectedItem}");
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
        }
        

        private void button10_Click(object sender, EventArgs e)
        {
            string fach;
            fach = textBox1.Text;

            if (fach == "Mathe")
            {
                listBox1.Items.Clear();
                Functions.PopulateListBox(listBox1, "./Dokumente/Mathe", "*.txt");
                Functions.PopulateListBox(listBox1, "./Dokumente/Mathe", "*.lua");
            }
            else
            {
                if (fach == "Deutsch")
                {
                    listBox1.Items.Clear();
                    Functions.PopulateListBox(listBox1, "./Dokumente/Deutsch", "*.txt");
                    Functions.PopulateListBox(listBox1, "./Dokumente/Deutsch", "*.lua");
                }
                else
                {
                    if (fach == "English")
                    {
                        listBox1.Items.Clear();
                        Functions.PopulateListBox(listBox1, "./Dokumente/English", "*.txt");
                        Functions.PopulateListBox(listBox1, "./Dokumente/English", "*.lua");
                    }
                    else
                    {
                        if (fach == "Wirtschaft")
                        {
                            listBox1.Items.Clear();
                            Functions.PopulateListBox(listBox1, "./Dokumente/Wirtschaft", "*.txt");
                            Functions.PopulateListBox(listBox1, "./Dokumente/Wirtschaft", "*.lua");
                        }
                        else
                        {
                            if (fach == "IT")
                            {
                                listBox1.Items.Clear();
                                Functions.PopulateListBox(listBox1, "./Dokumente/IT", "*.txt");
                                Functions.PopulateListBox(listBox1, "./Dokumente/IT", "*.lua");
                            }
                            else
                            {
                                if (fach == "Politik")
                                {
                                    listBox1.Items.Clear();
                                    Functions.PopulateListBox(listBox1, "./Dokumente/Politik", "*.txt");
                                    Functions.PopulateListBox(listBox1, "./Dokumente/Politik", "*.lua");
                                }
                                else
                                {
                                    if (fach == "Geschichte")
                                    {
                                        listBox1.Items.Clear();
                                        Functions.PopulateListBox(listBox1, "./Dokumente/Geschichte", "*.txt");
                                        Functions.PopulateListBox(listBox1, "./Dokumente/Geschichte", "*.lua");
                                    }
                                    else
                                    {
                                        if (fach == "Religion")
                                        {
                                            listBox1.Items.Clear();
                                            Functions.PopulateListBox(listBox1, "./Dokumente/Religion", "*.txt");
                                            Functions.PopulateListBox(listBox1, "./Dokumente/Religion", "*.lua");
                                        }
                                        else
                                        {
                                            if (fach == "WuN")
                                            {
                                                listBox1.Items.Clear();
                                                Functions.PopulateListBox(listBox1, "./Dokumente/WuN", "*.txt");
                                                Functions.PopulateListBox(listBox1, "./Dokumente/WuN", "*.lua");
                                            }
                                            else
                                            {
                                                MessageBox.Show("Dieser Fach gibt es nicht in unsere daten,es gibt nur: Mathe.Deutsch.English,Wirtschaft,IT,Politik,Geschichte,Religion,WuN!");
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Rechner rr = new Rechner();
            rr.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SettingsDark sd = new SettingsDark();
            sd.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string klausurmode;
            klausurmode = textBox2.Text;
            if (klausurmode == "AN")
            {
                button11.Enabled= true;
                MessageBox.Show("Klausur Mode wurde aktiviert,bei jeden schummeln versuch wird die klausur abgegeben!");
            }
            else
            {
                button11.Enabled= false;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            frageDark fd = new frageDark();
            fd.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PaintDark pd = new PaintDark();
            pd.Show();
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
    }
}
