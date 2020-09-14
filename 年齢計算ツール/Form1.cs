using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Class1 person = new Class1(textBox1.Text,dateTimePicker1.Value.Date);

            String names = person.getName();
            int day = person.getBirthday();


            MessageBox.Show(names + "さんの年齢は" + day + "です。");


        }
    }
}
