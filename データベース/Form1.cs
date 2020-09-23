using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {

        private SqlConnection cn = new SqlConnection();
        private SqlCommand cmd = new SqlCommand();
        private SqlDataReader rd;


        private string cnstr =
    @"Data Source=(LocalDB)\MSSQLLocalDB;" +
    @"AttachDbFilename=|DataDirectory|\Database1.mdf;" +
    "Integrated Security=True;" +
    "Connect Timeout=30";
            

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            cn.ConnectionString = cnstr;
            cn.Open();

            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [dbo].[Table]";


                                 
            rd = cmd.ExecuteReader();

            while (rd.Read())
            

                listBox1.Items.Add(
                    String.Format("[{0}] {1,-10} {2,-10} {3,-30} 【Tel】{4}",
                                   rd["Id"], rd["Name"], rd["ZipCode"], rd["Address"], rd["Tel"]
                   ));

               rd.Close();
                cn.Close();
                
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            cn.ConnectionString = cnstr;
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [dbo].[Table]" +
                                "WHERE Address LIKE N'%" + textBox2.Text + "%'";

            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                listBox1.Items.Add(
                    String.Format("[{0}] {1,-10} {2,-10} {3,-30} 【Tel】{4}",
                                   rd["Id"], rd["Name"], rd["ZipCode"], rd["Address"], rd["Tel"]));
            }
            

                rd.Close();
                cn.Close();
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


            cn.ConnectionString = cnstr;
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [dbo].[Table]" +
                                "WHERE Id LIKE N'%" + textBox1.Text + "%'";

            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                listBox1.Items.Add(
                    String.Format("[{0}] {1,-10} {2,-10} {3,-30} 【Tel】{4}",
                                   rd["Id"], rd["Name"], rd["ZipCode"], rd["Address"], rd["Tel"]));
            }


            rd.Close();
            cn.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            f2.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();

            f3.Show();

        }
    }
}
