using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //タイトルの文字列
            String caption = "どっちか選んでね";

            //メッセージボックスに「はい」「いいえ」ボタンを表示
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            //メッセージボックスの結果を取得するための列拳体

            DialogResult result1;
            DialogResult result2;

            //一つ目の質問
            String message1 = "甘いものがいい？";
            //二つ目の質問
            String message2 = "カロリーを気にしてる？";


            if (textBox1.Text == "")
            {
                MessageBox.Show("金額を入力してください");
            }
            else {
                int price = int.Parse(textBox1.Text);

                if (price < 300)
                {
                    label1.Text = "チョコドーナツだね";
                }
                else if(price >= 300)
                {
                    result1 = MessageBox.Show(message1, caption, buttons);
                    //メッセージ、タイトル、ボタンを指定


                    result2 = MessageBox.Show(message2, caption, buttons);
                    //メッセージ、タイトル、ボタンを指定


                    if(result1 == DialogResult.Yes & result2 == DialogResult.Yes)
                    {
                        label2.Text = "お豆腐プリンにしましょう";
                    }
                    else if(result1 == DialogResult.Yes & result2 == DialogResult.No)
                    {
                        label2.Text = "濃厚キャラメルチーズタルトにしましょう";
                    }
                    else if(result1 == DialogResult.No & result2 == DialogResult.Yes)
                    {
                        label2.Text = "ダイエットコーラとこんにゃくゼリーにしましょう";
                    }
                    else
                    {
                        label2.Text = "ウーロン茶とポテチにしましょう";
                    }

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "今日のおやつは？";
        }
    }
}
