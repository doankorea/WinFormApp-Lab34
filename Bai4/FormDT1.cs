using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class FormDT1 : Form
    {
        public FormDT1()
        {
            InitializeComponent();
            bt = new BaiTapDienTu();
        }
        public void FormDT1_Load(object sender, EventArgs e)
        {
            bt.Debai = "My grandfather was born in China. He came from a very poor family and was (1)________ of seven children. His parents lived(2) _____ a small farm. He didn't have a very good education. At the age of 17 he (3)________ home. First he went to Shanghai and (4)_______ he went to Hong Kong. He worded (5)_______ a waiter and then as a cook. When he was 21, he (6) ________ my grandmother and had four children.My mother was (7) _____oldest. My grandmother died recently, and my grandfather lives alone now. He is almost 80, (8)_______he is still very active and interested in everything (9)_____ is going on. He reads the papes and (10)________ televison even though his eyesight is fairly poor.\r\n";
            List<string> lists = new List<string>();
            lists.Add("one");
            lists.Add("on");
            lists.Add("left");
            lists.Add("then");
            lists.Add("as");
            lists.Add("maried");
            lists.Add("the");
            lists.Add("but");
            lists.Add("that");
            lists.Add("watches");
            bt.Dapantungcau = lists;
            txtContent.Text = (bt.Debai);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int diem = 0;
            for (int i = 0; i < 10; i++)
            {
                TextBox currentTextBox = (TextBox)this.Controls.Find("txt" + (i + 1), true).FirstOrDefault();
                string currentAnswer = currentTextBox.Text;

                if (currentAnswer.Equals(bt.Dapantungcau[i]))
                {
                    currentTextBox.BackColor = Color.Green;
                    diem++;
                } else
                {
                    currentTextBox.BackColor = Color.Red;
                }
            }
            MessageBox.Show("Điểm của bạn là: " + diem, "Thông báo");
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            string answers = string.Join(Environment.NewLine, bt.Dapantungcau);
            txtContent.Text = answers;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtContent.Text = bt.Debai;
            for(int i = 0; i < 10; i++)
            {
                TextBox currentTextBox = (TextBox)this.Controls.Find("txt" + (i + 1), true).FirstOrDefault();
                currentTextBox.Text = null;
                currentTextBox.BackColor = Color.White;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
