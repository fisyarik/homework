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
    public partial class car : Form
    {
        public car()
        {
            InitializeComponent();
        }

        private void car_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath car = new System.Drawing.Drawing2D.GraphicsPath();

            Rectangle carCapot = new Rectangle(200, 100, 100, 50);
            Rectangle carBody = new Rectangle(200, 100, 400, 100); // x, y, ширина, высота
            Rectangle leftWheel = new Rectangle(280, 190, 60, 40); // Левое колесо
            Rectangle rightWheel = new Rectangle(450, 190, 60, 40); // Правое колесо
            car.AddRectangle(carCapot);
            car.AddRectangle(leftWheel);
            car.AddRectangle(rightWheel);
            car.AddRectangle(carBody);

            Region myRegion = new Region(car);
            this.Region = myRegion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
