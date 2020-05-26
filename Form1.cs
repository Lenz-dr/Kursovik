using System;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            double y, x, R=3;
            for (double i=-10; i<=6; i++)//рисование графика
            {
                if ((i >= -10) && (i <= 0))
                    y = -0.5 * i - 3;
                else if ((i > 0) && (i <= 3))
                    y = Math.Sqrt(R * R - i * i) * (-1);
                else
                    y = Math.Sqrt(R * R - (i - 6) * (i - 6));
                chart1.Series[0].Points.AddXY(i, y);
            }
            double.TryParse(textBox2.Text, out x);
            R = Convert.ToDouble(textBox2.Text);
            if ((x >= -10) && (x <= 0))//расчет значения точки
                textBox3.Text = Convert.ToString(-0.5 * x - 3);
            else if ((x > 0) && (x <= 3))
                textBox3.Text = Convert.ToString(Math.Sqrt(R * R - x * x) * (-1));
            else if ((x > 3) && (x <= 6))
                textBox3.Text = Convert.ToString(Math.Sqrt(R * R - (x - 6) * (x - 6)));
            else
                textBox3.Text = "-";
        }
    }
}
