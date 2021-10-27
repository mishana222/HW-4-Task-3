using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_4_Task_3
{
    public partial class Form1 : Form
    {
        private RightTriangle right;
        private IsoscelesTriangle isosceles;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            right = null;
            isosceles = null;
            try
            {
                double SideA = Convert.ToDouble(textBox1.Text);
                double SideB = Convert.ToDouble(textBox2.Text);
                double CornerC = Convert.ToDouble(textBox3.Text);

                double SideC = Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideB, 2) - 2 * SideA * SideB * Math.Cos(CornerC));

                if (CornerC == 90 || (SideA > SideB && SideC == Math.Sqrt(Math.Pow(SideA, 2) - Math.Pow(SideB, 2))))
                {
                    right = new RightTriangle(SideA, SideB, CornerC);
                    MessageBox.Show("Створено прямокутний трикутник.");
                }
                else if (CornerC == 90 || (SideA < SideB && SideC == Math.Sqrt(Math.Pow(SideB, 2) - Math.Pow(SideA, 2))))
                {
                    right = new RightTriangle(SideA, SideB, CornerC);
                    MessageBox.Show("Створено прямокутний трикутник.");
                }
                else
                {
                    isosceles = new IsoscelesTriangle(SideA, SideB, CornerC);
                    MessageBox.Show("Створено рівнобедрений трикутник.");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалося створити трикутник");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (right != null)
                MessageBox.Show(right.GetPerimetr().ToString());
            else if (isosceles != null)
                MessageBox.Show(isosceles.GetPerimetr().ToString());
            else
                MessageBox.Show("Ніякого трикутника ще не створено.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (right != null)
                MessageBox.Show(right.GetArea().ToString());
            else if (isosceles != null)
                MessageBox.Show(isosceles.GetArea().ToString());
            else
                MessageBox.Show("Ніякого трикутника ще не створено.");
        }

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}
	}
}
