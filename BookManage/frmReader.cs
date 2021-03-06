using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookManage.Model;
using BookManage.BLL;
using System.IO;

namespace BookManage
{
    internal enum opStatus
    {
        inSelect = 0,
        inNew = 1,
        inChange = 2
    };
    public partial class frmReader : Form
    {
        private DataTable dt = null;
        private Reader reader = new Reader();
        private ReaderAdmin readerBLL = new ReaderAdmin();
        private opStatus ops;

        public frmReader()
        {
            InitializeComponent();
            dt = readerBLL.GetAllReaderType();
            foreach (DataRow dr in dt.Rows)
            {
                toolStripComboBox1.Items.Add(dr["rdType"].ToString() + "--" + dr["rdTypeName"].ToString());
                comboBox2.Items.Add(dr["rdType"].ToString() + "--" + dr["rdTypeName"].ToString());
            }

            SetStatus(opStatus.inSelect);
            UpdateView();
        }

        private void UpdateView()
        {
            dt = readerBLL.GetReader(0, "", "");
            ShowData();
        }
        private void ShowData()
        {
            dataGridView1.DataSource = dt;
            foreach (DataColumn dc in dt.Columns)
            {
                dataGridView1.Columns[dc.ColumnName].HeaderText = Reader.ColumnTitle(dc.ColumnName);
            }
        }
        private void SetStatus(opStatus opst)
        {
            ops = opst;
            switch (ops)
            {
                case opStatus.inSelect:
                    toolStrip1.Enabled = true;
                    groupBox1.Enabled = true;
                    groupBox2.Enabled = false;
                    break;
                case opStatus.inNew:
                    toolStrip1.Enabled = false;
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = true;
                    button8.Enabled = true;
                    button9.Enabled = false;
                    break;
                case opStatus.inChange:
                    toolStrip1.Enabled = false;
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = true;
                    button8.Enabled = false;
                    button9.Enabled = true;
                    break;

            }
        }

        private void SetReaderToText()
        {
            textBox1.Text = Convert.ToString(reader.rdID);
            textBox2.Text = reader.rdName;
            textBox4.Text = reader.rdPwd;
            comboBox1.Text = reader.rdSex;
            comboBox2.Text = Convert.ToString(reader.rdType);
            comboBox3.Text = reader.rdDept;
            textBox11.Text = reader.rdPhone;
            textBox10.Text = reader.rdEmail;
            dateTimePicker1.Value = reader.rdDateReg;
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
            textBox5.Text = reader.rdStatus;
            textBox6.Text = Convert.ToString(reader.rdBorrowQty);
            comboBox2.Text = Convert.ToString(reader.rdAdminRoles);
        }

        private void SetTextToReader()
        {
            reader.rdID = Convert.ToInt32(textBox1.Text);
            reader.rdName = textBox2.Text;
            reader.rdPwd = textBox4.Text;
            reader.rdSex = comboBox1.Text;
            int i = comboBox2.Text.IndexOf("--");
            if (i > 0)
            {
                reader.rdType = Convert.ToInt32(comboBox2.Text.Substring(0, i));
            }
            else
            {
                reader.rdType = Convert.ToInt32(comboBox2.Text);
            }
            reader.rdDept = comboBox3.Text;
            reader.rdPhone = textBox11.Text;
            reader.rdEmail = textBox10.Text;
            reader.rdDateReg = dateTimePicker1.Value;
            if (pictureBox1.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                reader.rdPhoto = ms.GetBuffer();
            }
            reader.rdStatus = textBox5.Text;
            reader.rdBorrowQty = Convert.ToInt32(textBox6.Text);
            reader.rdAdminRoles = Convert.ToInt32(comboBox2.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SetTextToReader();
            readerBLL.Insert(reader);
            label14.Text = "状态：办证成功！";
            UpdateView();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SetTextToReader();
            readerBLL.Update(reader);
            label14.Text = "状态：更改成功！";
            UpdateView();
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1["rdID", dataGridView1.CurrentCell.RowIndex].Value.ToString() == "")
                return;
            ReaderAdmin admin = new ReaderAdmin();
            reader = admin.GetReader((int)dataGridView1["rdID", dataGridView1.CurrentCell.RowIndex].Value);
            if (reader == null)
                return;
            SetReaderToText();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SetStatus(opStatus.inSelect);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetStatus(opStatus.inNew);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetStatus(opStatus.inChange);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetTextToReader();
            readerBLL.Loss(reader);
            label14.Text = "状态：已挂失！";
            UpdateView();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SetTextToReader();
            readerBLL.UnLoss(reader);
            label14.Text = "状态：已解除挂失！";
            UpdateView();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SetTextToReader();
            readerBLL.Delete(reader);
            label14.Text = "状态：已注销！";
            UpdateView();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form form = new frmMain();
            form.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            foreach (Control ctr1 in groupBox2.Controls)
            {
                if (ctr1 is TextBox)
                    ctr1.Text = "";
            }
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.Filter = "图片文件(*. jpg;*bmp;*. png;*. gif) | *. jpg; *bmp; png; gif*";
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                Image imgPhoto = Image.FromFile(ofd1.FileName);
                pictureBox1.Image = imgPhoto;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int rdType;
            string rdDept, rdName;
            if (toolStripComboBox1.Text.Trim() == "")
            {
                rdType = 0;
            }

            else
            {
                int i = toolStripComboBox1.Text.IndexOf("--");
                if (i > 0)
                {
                    rdType = Convert.ToInt32(toolStripComboBox1.Text.Substring(0, i));
                }
                else
                {
                    rdType = Convert.ToInt32(toolStripComboBox1.Text);
                }
            }
            rdDept = toolStripComboBox2.Text;
            rdName = toolStripTextBox1.Text;
            dt = readerBLL.GetReader(rdType, rdDept, rdName);
            ShowData();
        }
    }
}
