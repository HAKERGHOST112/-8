using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace пР_8_2_КУРС
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = textBox1.Text.Length;
            int b = textBox2.Text.Length;
            if (a > b)
            {
                label3.Text=label1.Text;
            }
            else if (b > a)
            {
                label3.Text = label2.Text;
            }
            else
            {
                label3.Text = "Фамилии одинаковой длины";
            }


        }
    }
}
