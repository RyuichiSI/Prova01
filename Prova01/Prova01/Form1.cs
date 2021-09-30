using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbtAdição_CheckedChanged(object sender, EventArgs e)
        {
            double n1 = 0, n2 = 0;
            txtResultado.Text = "";
            if (txtN1.Text == "")
            {
                MessageBox.Show("Favor digitar um numero ");
            }
            else if (txtN2.Text == "")
            {
                MessageBox.Show("Favor digitar um numero ");
            }
            else
            {
                n1 = Convert.ToDouble(txtN1.Text);
                n2 = Convert.ToDouble(txtN2.Text);
                txtResultado.Text = $"{(n1 + n2).ToString()}";
            }

        }

        private void rbtSubtração_CheckedChanged(object sender, EventArgs e)
        {
            double n1 = 0, n2 = 0;
            txtResultado.Text = "";
            if (txtN1.Text == "")
            {
                MessageBox.Show("Favor digitar um numero ");
            }
            else if (txtN2.Text == "")
            {
                MessageBox.Show("Favor digitar um numero ");
            }
            else
            {
                n1 = Convert.ToDouble(txtN1.Text);
                n2 = Convert.ToDouble(txtN2.Text);
                txtResultado.Text = $"{(n1 - n2).ToString()}";
            }
        }

        private void rbtMult_CheckedChanged(object sender, EventArgs e)
        {
            double n1 = 0, n2 = 0;
            txtResultado.Text = "";
            if (txtN1.Text == "")
            {
                MessageBox.Show("Favor digitar um numero ");
            }
            else if (txtN2.Text == "")
            {
                MessageBox.Show("Favor digitar um numero ");
            }
            else
            {
                n1 = Convert.ToDouble(txtN1.Text);
                n2 = Convert.ToDouble(txtN2.Text);
                txtResultado.Text = $"{(n1 * n2).ToString()}";
            }
        }

        private void rbtDiv_CheckedChanged(object sender, EventArgs e)
        {
            double n1 = 0, n2 = 0;
            txtResultado.Text = "";
            if (txtN1.Text == "")
            {
                MessageBox.Show("Favor digitar um numero ");
            }
            else if (txtN2.Text == "")
            {
                MessageBox.Show("Favor digitar um numero ");
            }
            else
            {
                n1 = Convert.ToDouble(txtN1.Text);
                n2 = Convert.ToDouble(txtN2.Text);
                txtResultado.Text = $"{(n1 / n2).ToString()}";
            }
        }
    }
}
