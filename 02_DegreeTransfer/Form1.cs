using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_DegreeTransfer
{

    public partial class Form1 : Form
    {
        //public double degree { get; set; }
        //public double Celsius_degree => (degree - 32) * 5 / 9;
        //public double Fahrenheit_degree => 9 / 5 * degree + 32;

        //public double degree { get; set; }
        public Form1()
        {
            InitializeComponent();
        }
        static double result = 0;

        private static double GetCelsius_degree(double T)
        {
            return ((T - 32.0) * 5.0) / 9.0;
        }

        private static double GetFahrenheit_degree(double T)
        {
            return 32.0 + T * 9.0 / 5.0;
        }

        private void transfer_Click(object sender, EventArgs e)
        {
            if (CeltoFah.Checked)
            {
                result = GetFahrenheit_degree(Convert.ToDouble(input.Text));
                resultlabel.Text = $"結果為:{input.Text}℃={result}℉";
            }
            if (FahtoCel.Checked)
            {
                result = GetCelsius_degree(Convert.ToDouble(input.Text));
                resultlabel.Text = $"結果為:{input.Text}℉={result}℃";
            }
        }

        private void num1_MouseClick(object sender, MouseEventArgs e)
        {
            input.Text += 1;
        }

        private void num2_Click(object sender, EventArgs e)
        {
            input.Text += 2;
        }

        private void num3_Click(object sender, EventArgs e)
        {
            input.Text += 3;
        }

        private void num4_Click(object sender, EventArgs e)
        {
            input.Text += 4;
        }

        private void num5_Click(object sender, EventArgs e)
        {
            input.Text += 5;
        }

        private void num6_Click(object sender, EventArgs e)
        {
            input.Text += 6;
        }

        private void num7_Click(object sender, EventArgs e)
        {
            input.Text += 7;
        }

        private void num8_Click(object sender, EventArgs e)
        {
            input.Text += 8;
        }

        private void num9_Click(object sender, EventArgs e)
        {
            input.Text += 9;
        }

        private void num0_Click(object sender, EventArgs e)
        {
            input.Text += 0;
        }

        private void dot_Click(object sender, EventArgs e)
        {
            input.Text += '.';
        }
        private void clear_Click(object sender, EventArgs e)
        {
            input.Text = " ";
            resultlabel.Text = "結果為:";
        }

    }
}
