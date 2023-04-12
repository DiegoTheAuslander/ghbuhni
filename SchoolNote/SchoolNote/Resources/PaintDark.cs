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
    public partial class PaintDark : Form

    {

        //Feld
        bool paint = false;
        int index = 0;
        int x, y,sX,sY,cX,cY;
        Color colorP;
        Point pointX, pointY;
        Bitmap BitmapN;
        Graphics graphics;
        Pen pen =new Pen(Color.White, 2);
        Pen eraser = new Pen(Color.Black, 2);

        ColorDialog cd = new ColorDialog();
        Color new_color;
        Point lastPoint;


        private void BtnColor_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            pen.Color = button11.BackColor;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pen.Color = button10.BackColor;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pen.Color = button12.BackColor;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            pen.Color = button19.BackColor;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            pen.Color = button13.BackColor;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            pen.Color = button14.BackColor;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            pen.Color = button15.BackColor;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            pen.Color = button16.BackColor;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            pen.Color = button17.BackColor;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            pen.Color = button18.BackColor;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            pen.Color = button20.BackColor;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            pen.Color = button21.BackColor;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            pen.Color = button22.BackColor;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            pen.Color = button23.BackColor;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            pen.Color = button24.BackColor;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            pen.Color = button25.BackColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPenWidth_Click(object sender, EventArgs e)
        {

        }

        private void Pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            pointY = e.Location;

            cX = e.X;
            cY = e.Y;
        }

        private void Pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (index == 1)
                {
                    pointX = e.Location;
                    graphics.DrawLine(pen, pointX, pointY);
                    pointY = pointX;
                }
            }
            Pic.Refresh();
            x= e.X;
            y= e.Y;
            sX = e.X - cX;
            sY= e.Y-cY;
        }

        private void Pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            sX =x-cX;
            sY=y-cY;

            if(index == 3)
            {
                graphics.DrawEllipse(pen,cX,cY,sX,sY); ;
            }
            if(index == 4)
            {
                graphics.DrawRectangle(pen,cX,cY,sX,sY);
            }
            if(index == 5)
            {
                graphics.DrawLine(pen,cX,cY,x,y);
            }
        }

        private void BtnPen_Click(object sender, EventArgs e)
        {
            index= 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pen.Color=(Color.Black);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            index= 4;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            index= 5;
        }

        private void Pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics= e.Graphics;
            if (paint)
            {
                if (index == 3)
                {
                    graphics.DrawEllipse(pen, cX, cY, sX, sY); ;
                }
                if (index == 4)
                {
                    graphics.DrawRectangle(pen, cX, cY, sX, sY);
                }
                if (index == 5)
                {
                    graphics.DrawLine(pen, cX, cY, x, y);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.Black);
            Pic.Image = BitmapN;
            index= 0;
        }

        private void PinTitle_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void PinTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }




        //Metode

        static Point SetPoint(PictureBox pictureBox, Point point)
        {
            float pX = 1f * pictureBox.Image.Width / pictureBox.Width;
            float pY = 1f * pictureBox.Image.Height/ pictureBox.Height;

            return new Point((int)(point.X * pX),(int)(point.Y * pY));
        }







        private void Validate(Bitmap bitmap, Stack<Point> pointStack, int x, int y, Color colorNew, Color colorOld)
        {
            Color cx = bitmap.GetPixel(x, y);
            if (cx == colorOld)
            {
                pointStack.Push(new Point(x, y));
                bitmap.SetPixel(x,y,colorNew);
            }
        }




        public void FillUp(Bitmap bitmap, int x, int y,Color newColor) 
        {
            Color OldColor = bitmap.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bitmap.SetPixel(x, y, newColor);

            if (OldColor == newColor) return;
            
            while (pixel.Count > 0)
            {
                Point point = (Point)pixel.Pop();

                if (point.X > 0 && point.Y > 0 && point.X <bitmap.Width - 1 && point.Y < bitmap.Width - 1)
                {
                    Validate(bitmap, pixel, point.X - 1, point.Y, OldColor, newColor);
                    Validate(bitmap, pixel, point.X , point.Y -1, OldColor, newColor);
                    Validate(bitmap, pixel, point.X + 1, point.Y, OldColor, newColor);
                    Validate(bitmap, pixel, point.X, point.Y + 1, OldColor, newColor);

                }
            }

            
        }




        public PaintDark()
        {
            InitializeComponent();
            BitmapN = new Bitmap(Pic.Width, Pic.Height);
            graphics = Graphics.FromImage(BitmapN);
            graphics.Clear(Color.Black);
            Pic.Image = BitmapN;
            
        }



        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void PaintDark_Load(object sender, EventArgs e)
        {

        }
    }
}
