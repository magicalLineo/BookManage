using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookManage.BLL;
using BookManage.Model;

namespace BookManage
{
    public partial class frmLogin : Form
    {
        private int loginTimes = 0;
        private ReaderAdmin readerBLL = new ReaderAdmin();
        public static Reader reader = null;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginTimes++;

            int rdID;
            rdID = Convert.ToInt32(textBox1.Text.Trim());
            reader = readerBLL.GetReader(rdID);

            if (reader == null)
            {
                textBox1.Focus();
                label3.Text = "登录信息：查无此人..{" + loginTimes.ToString() + "}";
            }
            else
            {
                if (reader.rdPwd == textBox2.Text)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    textBox2.Text = "";
                    textBox2.Focus();
                    label3.Text = "登录信息：..密码错误！{" + loginTimes.ToString() + "}";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
