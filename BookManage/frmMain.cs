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
using BookManage.Model;

namespace BookManage
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            InitMenu();
        }

        public void InitMenu()
        {
            Reader reader = frmLogin.reader;
            图书管理ToolStripMenuItem.Enabled = (reader.IsBookAdmin() && reader.IsLoginAdmin());
            读者管理ToolStripMenuItem.Enabled = ((reader.IsReaderAdmin() | reader.IsSystemAdmin()) && reader.IsLoginAdmin());
            借阅管理ToolStripMenuItem.Enabled = (reader.IsBorrowAdmin() && reader.IsLoginAdmin());
            用户管理ToolStripMenuItem.Enabled = (reader.IsLoginAdmin());
            授权管理ToolStripMenuItem.Enabled = (reader.IsSystemAdmin() && reader.IsLoginAdmin());

            textBox1.Text = Convert.ToString(reader.rdID);
            textBox2.Text = reader.rdName;
            textBox3.Text = reader.rdPwd;
            textBox4.Text = reader.rdSex;
            textBox5.Text = Convert.ToString(reader.rdBorrowQty);
            textBox6.Text = reader.rdStatus;
            textBox7.Text = Convert.ToString(reader.rdAdminRoles);
            textBox8.Text = Convert.ToString(reader.rdType);
            textBox9.Text = reader.rdDept;
            textBox10.Text = reader.rdPhone;
            textBox11.Text = reader.rdEmail;
            textBox12.Text = Convert.ToString(reader.rdDateReg); ;
            if (reader.rdPhoto == null)
            {
                pictureBox1.Image = null;
            }
            else
            {
                MemoryStream ms = new MemoryStream(reader.rdPhoto);
                Image imgPhoto = Bitmap.FromStream(ms, true);
                pictureBox1.Image = imgPhoto;
            }
        }

        private void 读者类型管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmReaderType();
            form.Show();
            this.Hide();
        }

        private void 办理借书证ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmReader();
            form.Show();
            this.Hide();
        }

        private void 借书证信息变更ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmReader();
            form.Show();
            this.Hide();
        }

        private void 新书入库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmBook();
            form.Show();
            this.Hide();
        }

        private void 借书证挂失和解除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmReader();
            form.Show();
            this.Hide();
        }

        private void 注销借书证ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmReader();
            form.Show();
            this.Hide();
        }

        private void 图书信息维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmBook();
            form.Show();
            this.Hide();
        }

        private void 借书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmBorrow();
            form.Show();
            this.Hide();
        }

        private void 续借ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmBorrow();
            form.Show();
            this.Hide();
        }

        private void 还书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmBorrow();
            form.Show();
            this.Hide();
        }

        private void 密码修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmPwd();
            form.Show();
            this.Hide();
        }
    }
}
