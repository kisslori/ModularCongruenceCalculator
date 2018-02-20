using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modularCongruency
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!run_checks())
                return;

            int a;
            int.TryParse(a_txtbox.Text, out a);
            int b;
            int.TryParse(b_txtbox.Text, out b);
            int n;
            int.TryParse(n_txtbox.Text, out n);

            if( n == 0)
            {
                ans_label.Text = "Modulo must be greater than 0 ";
                return;
            }

            int div = gcd(a, n);

            if (div == 1)
            {
                computeX(a, b, n);
            }
            else
            {
                if (b/div == (float)b / (float)div)
                {
                    computeX(a / div, b / div, n / div);
                }
                else
                {
                    ans_label.Text = "X has no solution for given numbers.";
                }

            }
        }

        public void computeX(int a, int b , int n)
        {
            int x = invMod(a, n)*b;
            ans_label.Text = "X(g) is : " + x % n+ " + "+ n+"k";
        }

       

        public int invMod(int a, int b)
        {
            a = a % b;
            for(int x =1; x < b; x++)
            {
                if ((a * x) % b == 1)
                {
                    return x;
                }
            }
            return -1;
        }

        public int gcd(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a == 0 ? b : a;
        }

        public bool run_checks()
        {
            if (String.IsNullOrWhiteSpace(a_txtbox.Text) || String.IsNullOrWhiteSpace(b_txtbox.Text) || String.IsNullOrWhiteSpace(n_txtbox.Text))
            {
                ans_label.Text = "Fields cannot be empty";
                return false;
            }

            return true;
        }

        private void a_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ans_label.Text = "";
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                ans_label.Text = "Please insert only numbers";
                e.Handled = true;
            }
        }

        private void b_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ans_label.Text = "";
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                ans_label.Text = "Please insert only numbers";
                e.Handled = true;
            }
        }

        private void n_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ans_label.Text = "";
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                ans_label.Text = "Please insert only numbers";
                e.Handled = true;
            }
        }
    }
}
