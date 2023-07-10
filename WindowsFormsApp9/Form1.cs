using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(button9.Text == "")
            {
                button9.Text = button6.Text;
                button6.Text = "";
            }
            if (button5.Text == "")
            {
                button5.Text = button6.Text;
                button6.Text = "";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                button6.Text = button5.Text;
                button5.Text = "";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int[] arr = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8};
            Button [] btn = new Button[8] { button1, button2, button3, button4, button5, button6, button7, button8};
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int j = rand.Next(i + 1);

                int tmp = arr[j];
                arr[j] = arr[i];
                arr[i] = tmp;
                btn[i].Text += arr[i];
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
