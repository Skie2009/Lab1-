﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            // Получаем объект Graphics
            Graphics g = e.Graphics;
            // Рисуем линию
            g.DrawLine(Pens.Violet, 10, 5, 110, 15);
            // Рисуем эллипс
            g.DrawEllipse(Pens.Gold, 10, 20, 110, 45);
            // Рисуем прямоугольник
            g.DrawRectangle(Pens.Firebrick, 10, 70, 110, 45);
            // Рисуем закрашенный эллипс
            g.FillEllipse(Brushes.Pink, 130, 20, 110, 45);
            // Рисуем закрашенный прямоугольник
            g.FillRectangle(Brushes.OrangeRed, 130, 70, 110, 45);
            base.OnPaint(e);
        }

        private void button1_Click(object sender, EventArgs e)
            {
                // Выбираем перо myPen красного цвета толщиной в 1 пиксел:
                Pen myPen = new Pen(Color.Black, 1);
                // Объявляем объект «g» класса Graphics и предоставляем
                // ему возможность рисования на pictureBox1:
                Graphics g = pictureBox1.CreateGraphics();
                // Рисуем прямоугольник:
                g.DrawRectangle(myPen, 0, 0, pictureBox1.Size.Width - 1,
                pictureBox1.Size.Height - 1);
                g.Dispose();
        }
    }
}
