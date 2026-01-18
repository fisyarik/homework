using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class triangle : Form
    {
        public triangle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void triangle_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath heart = new System.Drawing.Drawing2D.GraphicsPath();
            heart.AddPolygon(new Point[] 
            {
                new Point(0,0),
                new Point(0, this.Height),
                new Point(this.Width, 0), 
            });

            Region myRegion = new Region(heart);
            this.Region = myRegion;
        }
    }
}
