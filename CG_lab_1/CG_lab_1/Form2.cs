using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG_lab_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public int[,] mask = new int[3, 3] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };

        public void change(Button button, int i, int j)
        {
            if (button.Text == "1")
            {
                button.Text = "0";
                mask[i, j] = 0;
            }
            else
            {
                button.Text = "1";
                mask[i, j] = 1;
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            change(button1, 0, 0);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            change(button2, 0, 1);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            change(button3, 0, 2);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            change(button4, 1, 0);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            change(button5, 1, 1);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            change(button6, 1, 2);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            change(button7, 2, 0);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            change(button8, 2, 1);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            change(button9, 2, 2);
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
