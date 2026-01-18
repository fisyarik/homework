using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class heart : Form
    {
        public heart()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void heart_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddPolygon(new PointF[]
            {
               
                // Верхняя дуга (левая часть)
                new PointF(100, 100),
                new PointF(150, 60),
                new PointF(200, 100),
    
                // Правая верхняя дуга
                new PointF(250, 60),
                new PointF(300, 100),
    
                // Правая сторона и нижняя точка
                new PointF(300, 160),
                new PointF(270, 200),
                new PointF(220, 220),
    
                // Нижняя точка сердца (остриё)
                new PointF(200, 240),
    
                // Левая сторона и нижняя точка
                new PointF(180, 220),
                new PointF(130, 200),
                new PointF(100, 160),
    
                // Возвращаемся к началу для замыкания контура
                new PointF(100, 100)
        });

            Region myRegion = new Region(path);
            this.Region = myRegion;
        }
    }
}


