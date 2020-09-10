using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fprice = 0;
            int total = 0;

            int price = int.Parse(textBox1.Text);
            int count = int.Parse(textBox2.Text);
           
            fprice = price * count;

            total = (int)(0.1*fprice)+(fprice);

            label6.Text = Convert.ToString(fprice);
            label7.Text = Convert.ToString(0.1*fprice);
            label8.Text = Convert.ToString(total);
                

        }

        
    }
}
