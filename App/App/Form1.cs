using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private double factorial(int x)
        {
            double ans = 1;
            for (int i = 2; i < x + 1; ++i)
            {
                ans *= i;
            }
            return ans;
        }
        private double sin(double x, int n)
        {
            double ans = 0;
            for (int i = 1; i < n; i++)
            {
                ans += (double)(Math.Pow(-1, i - 1) * (Math.Pow(x, 2 * i - 1) / factorial(2 * i - 1)));
            }
            return ans;
        }

        private double cos(double x, int n)
        {
            double ans = 0;
            for (int i = 1; i < n; i++)
            {
                ans += (double)(Math.Pow(-1, i - 1) * (Math.Pow(x, 2 * i - 2) / factorial(2 * i - 2)));
            }
            return ans;
        }

        private double atn(double x, int n)
        {
            double res = 0;
            int sig = 1;
            for (int i = 1; i < n + 1; i+=2)
            {
                res += sig * (double)Math.Pow(x, i) / i;
                sig *= -1;
            }
            return res;
        }

        private double act(double x, int n)
        {
            double res = (Math.PI / 2) - atn(x, n);
            return res;
        }

        private double ang(double caty, double catx, int n)
        {
            if (caty < catx)
            {
                return atn(caty / catx, n);
            } else
            {
                return act(catx / caty, n);
            }
        }

        private int maxN;
        private int minN;
        private int x1, y1, x2, y2;

        private double finishDist(double x, double y)
        {
            return Math.Sqrt(Math.Pow(x - x2, 2) + Math.Pow(y - y2, 2));
        }
        private double calcRad(int n)
        {
            double ans = finishDist(x1, y1);
            double angle = ang(Math.Abs(y2 - y1), Math.Abs(x2 - x1), n);
            double x = x1;
            double y = y1;
            int step = 10;
            draw(x, y);
            while (true)
            {
                double nx = x + step * cos(angle, n);
                double ny = y - step * sin(angle, n);
                double nDist = finishDist(nx, ny);
                if (nDist >= ans)
                {
                    break;
                }
                x = nx;
                y = ny;
                ans = nDist;
                draw(x, y);
            }
            return ans;
        }

        private void x2t_TextChanged(object sender, EventArgs e)
        {

        }

        private void draw(double x, double y)
        {
            Graphics gr = field.CreateGraphics();
            gr.Clear(Color.White);
            gr.ScaleTransform(0.5f, 0.5f);
            int rand = 20;
            Pen p = new Pen(Color.Black, 10);
            gr.DrawEllipse(p, x1 - rand, y1 - rand, rand * 2, rand * 2);
            gr.DrawEllipse(p, x2 - rand, y2 - rand, rand * 2, rand * 2);
            gr.DrawEllipse(p, (float)x - rand, (float)y - rand, rand * 2, rand * 2);
            System.Threading.Thread.Sleep(3);
        }

        private void maxMinClac()
        {
            List<double> res = new List<double>();
            for (int n = maxN; n > minN - 1; --n)
            {
                var dist = calcRad(n);
                results.Items.Add(n.ToString() + " : " + dist.ToString());
                Console.WriteLine(n.ToString() + " : " + dist.ToString());
                results.Invalidate();
                res.Add(dist);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x1 = Int32.Parse(x1t.Text);
            y1 = Int32.Parse(y1t.Text);
            x2 = Int32.Parse(x2t.Text);
            y2 = Int32.Parse(y2t.Text);
            maxN = Int32.Parse(maxNt.Text);
            minN = Int32.Parse(minNt.Text);
            maxMinClac();
        }
    }
}
