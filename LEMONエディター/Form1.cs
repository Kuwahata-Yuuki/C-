using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String saveFileName;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                saveFileName = saveFileDialog1.FileName;
            }
            else
            {
                return;
            }

            StreamWriter textFile =
                new StreamWriter(new FileStream(saveFileName, FileMode.Create));

            textFile.Write(textBox1.Text);
            textFile.Close();

        }

        private void 開くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String openFileName;

        if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileName = openFileDialog1.FileName;
            }
            else
            {
                return;
            }

            textBox1.Clear();
            StreamReader textFile = new StreamReader(openFileName);
            textBox1.Text = textFile.ReadToEnd();
            textFile.Close();


        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
