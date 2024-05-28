using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prac23
{
    public partial class Form1 : Form
    {
        Rectangle Rectangle = new Rectangle(10, 10, 200, 100);
        Rectangle Circle = new Rectangle(220, 10, 150, 150);
        Rectangle Square = new Rectangle(380, 10, 150, 150);
        bool rect = false;
        bool circ = false;
        bool sqr = false;
        int RectangleX = 0;
        int RectangleY = 0;
        int CircleX = 0;
        int CircleY = 0;
        int SquareX = 0;
        int SquareY = 0;
        
        public Form1()
        {
            InitializeComponent();
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Red, Circle);
            e.Graphics.FillRectangle(Brushes.Blue, Square);
            e.Graphics.FillRectangle(Brushes.Yellow, Rectangle);

        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.X < Rectangle.X + Rectangle.Width) && (e.X > Rectangle.X))
            {
                if ((e.Y < Rectangle.Y + Rectangle.Height) && (e.Y > Rectangle.Y))
                {
                    rect = true;
                    RectangleX = e.X - Rectangle.X;
                    RectangleY = e.Y - Rectangle.Y;
                }
            }
            if ((e.X < Circle.X + Circle.Width) && (e.X > Circle.X))
            {
                if ((e.Y < Circle.Y + Circle.Height) && (e.Y > Circle.Y))
                {
                    circ = true;
                    CircleX = e.X - Circle.X;
                    CircleY = e.Y - Circle.Y;
                }
            }
            if ((e.X < Square.X + Square.Width) && (e.X > Square.X))
            {
                if ((e.Y < Square.Y + Square.Height) && (e.Y > Square.Y))
                {
                    sqr = true;
                    SquareX = e.X - Square.X;
                    SquareY = e.Y - Square.Y;
                }
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            rect = false;
            circ = false;
            sqr = false;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (circ)
            {
                Circle.X = e.X - CircleX;
                Circle.Y = e.Y - CircleY;
            }
            if(rect)
            {
                Rectangle.X = e.X - RectangleX;
                Rectangle.Y = e.Y - RectangleY;
            }
            if(sqr)
            {
                Square.X = e.X - SquareX;
                Square.Y = e.Y - SquareY;
            }
            pictureBox1.Invalidate();

            if ((label1.Location.X < Square.X + Square.Width) && (label1.Location.X > Square.X))
            {
                if ((label1.Location.Y < Square.Y + Square.Height) && (label1.Location.Y > Square.Y))
                {
                    label1.Text = "Синий квадрат";
                }
            }
            if ((label1.Location.X < Circle.X + Circle.Width) && (label1.Location.X > Circle.X))
            {
                if ((label1.Location.Y < Circle.Y + Circle.Height) && (label1.Location.Y > Circle.Y))
                {
                    label1.Text = "Красный круг";
                }
            }
            if ((label1.Location.X < Rectangle.X + Rectangle.Width) && (label1.Location.X > Rectangle.X))
            {
                if ((label1.Location.Y < Rectangle.Y + Rectangle.Height) && (label1.Location.Y > Rectangle.Y))
                {
                    label1.Text = "Жёлтый прямоугольник";
                }
            }
            //разделитель для глаз
            if ((label2.Location.X < Square.X + Square.Width) && (label2.Location.X > Square.X))
            {
                if ((label2.Location.Y < Square.Y + Square.Height) && (label2.Location.Y > Square.Y))
                {
                    label2.Text = "Синий квадрат";
                }
            }
            if ((label2.Location.X < Circle.X + Circle.Width) && (label2.Location.X > Circle.X))
            {
                if ((label2.Location.Y < Circle.Y + Circle.Height) && (label2.Location.Y > Circle.Y))
                {
                    label2.Text = "Красный круг";
                }
            }
            if ((label2.Location.X < Rectangle.X + Rectangle.Width) && (label2.Location.X > Rectangle.X))
            {
                if ((label2.Location.Y < Rectangle.Y + Rectangle.Height) && (label2.Location.Y > Rectangle.Y))
                {
                    label2.Text = "Жёлтый прямоугольник";
                }
            }
            //разделитель для глаз
            if ((label3.Location.X < Square.X + Square.Width) && (label3.Location.X > Square.X))
            {
                if ((label3.Location.Y < Square.Y + Square.Height) && (label3.Location.Y > Square.Y))
                {
                    label3.Text = "Синий квадрат";
                }
            }
            if ((label3.Location.X < Circle.X + Circle.Width) && (label3.Location.X > Circle.X))
            {
                if ((label3.Location.Y < Circle.Y + Circle.Height) && (label3.Location.Y > Circle.Y))
                {
                    label3.Text = "Красный круг";
                }
            }
            if ((label3.Location.X < Rectangle.X + Rectangle.Width) && (label3.Location.X > Rectangle.X))
            {
                if ((label3.Location.Y < Rectangle.Y + Rectangle.Height) && (label3.Location.Y > Rectangle.Y))
                {
                    label3.Text = "Жёлтый прямоугольник";
                }
            }
            //разделитель


        }
    }
}
