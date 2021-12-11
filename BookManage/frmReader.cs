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
                cmbTypeForQry.Items.Add(dr["rdType"].ToString() + "--" + dr["rdTypeName"].ToString());
                cmbType.Items.Add(dr["rdType"].ToString() + "--" + dr["rdTypeName"].ToString());

            }

            SetStatus(opStatus.inSelect);
            dt = readerBLL.GetReader(0, "", "");
            ShowData();
        }
        private void ShowData()
        {
            dgvReader.DataSource = dt;
            foreach (DataColumn dc in dt.Columns)
            {
                dgvReader.Columns[dc.ColumnName].HeaderText = Reader.ColumnTitle(dc.ColumnName);
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
                    btnAddReader.Enabled = true;
                    btnUpdateReader.Enabled = false;
                    break;
                case opStatus.inChange:
                    toolStrip1.Enabled = false;
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = true;
                    btnAddReader.Enabled = false;
                    btnUpdateReader.Enabled = true;
                    break;

            }
        }

        private void SetReaderToText()
        {
            txtID.Text = Convert.ToString(reader.rdID);
            txtName.Text = reader.rdName;
            txtPwd.Text = reader.rdPwd;
            cmbSex.Text = reader.rdSex;
            cmbType.Text = Convert.ToString(reader.rdType);
            cmbDept.Text = reader.rdDept;
            txtPhone.Text = reader.rdPhone;
            txtEmail.Text = reader.rdEmail;
            dtpDateReg.Value = reader.rdDateReg;

            txtStatus.Text = reader.rdStatus;
            txtBorrowQty.Text = Convert.ToString(reader.rdBorrowQty);
            txtAdminRoles.Text = Convert.ToString(reader.rdAdminRoles);
        }

        private void SetTextToReader()
        {
            reader.rdID = Convert.ToInt32(txtID.Text);
            reader.rdName = txtName.Text;
            reader.rdPwd = txtPwd.Text;
            reader.rdSex = cmbSex.Text;
            int i = cmbType.Text.IndexOf("--");
            if (i > 0)
            {
                reader.rdType = Convert.ToInt32(cmbType.Text.Substring(0, i));
            }
            else
            {
                reader.rdType = Convert.ToInt32(cmbType.Text);
            }
            reader.rdDept = cmbDept.Text;
            reader.rdPhone = txtPhone.Text;
            reader.rdEmail = txtEmail.Text;
            reader.rdDateReg = dtpDateReg.Value;
            reader.rdStatus = txtStatus.Text;
            reader.rdBorrowQty = Convert.ToInt32(txtBorrowQty.Text);
            reader.rdAdminRoles = Convert.ToInt32(txtAdminRoles.Text);
        }

        private void btnNewDoc_Click(object sender, EventArgs e)
        {
            SetStatus(opStatus.inNew);
        }

        private void btnChangeDoc_Click(object sender, EventArgs e)
        {
            SetStatus(opStatus.inChange);
        }

        private void btnLossDoc_Click(object sender, EventArgs e)
        {
            SetTextToReader();
            readerBLL.Loss(reader);
            labinformation.Text = "状态：已挂失！";


        }

        private void btnUnlossDoc_Click(object sender, EventArgs e)
        {
            SetTextToReader();
            readerBLL.UnLoss(reader);
            labinformation.Text = "状态：已解除挂失！";
        }

        private void btnCancelDoc_Click(object sender, EventArgs e)
        {
            SetTextToReader();
            readerBLL.Delete(reader);
            labinformation.Text = "状态：已注销！";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form form = new frmMain();
            form.Show();
            this.Hide();
        }

        private void btnAddReader_Click(object sender, EventArgs e)
        {
            SetTextToReader();
            readerBLL.Insert(reader);
            labinformation.Text = "状态：办证成功！";
        }

        private void btnUpdateReader_Click(object sender, EventArgs e)
        {
            SetTextToReader();
            readerBLL.Update(reader);
            labinformation.Text = "状态：更改成功！";
        }

        private void btnCancelChange_Click(object sender, EventArgs e)
        {
            foreach (Control ctr1 in groupBox2.Controls)
            {
                if (ctr1 is TextBox)
                    ctr1.Text = "";
            }
            cmbSex.Text = "";
            cmbType.Text = "";
            cmbDept.Text = "";
        }

        private void btnLoadPictureFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.Filter = "图片文件(*. jpg;*bmp;*. png;*. gif) I *. jpg; *bmp; png; gi f*";
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                Image imgPhoto = Image.FromFile(ofd1.FileName);
                picboxPhoto.Image = imgPhoto;
            }

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            int rdType;
            string rdDept, rdName;
            if (cmbTypeForQry.Text.Trim() == "")
            {
                rdType = 0;
            }

            else
            {
                int i = cmbTypeForQry.Text.IndexOf
            if (i > 0)
                {
                    rdType = Convert.ToInt32(cmbTypeForQry.Text.Substring(0, i));
                }
                else
                {
                    rdType = Convert.ToInt32(cmbTypeForQry.Text);
                }
            }
            rdDept = cmbDeptForQry.Text;
            rdName = txtNameForQry.Text;
            dt = readerBLL.GetReader(rdType, rdDept, rdName);
            ShowData();

        }
        private void dgvReader_CelIContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void cmbDept_SelectedlndexChanged(object sender, EventArgs e)
        {
        }
        private void frmReader_Load(object sender, EventArgs e)
        {
        }
        private void dgvReader_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReader.CurrentCell == null)
                return;
            reader = ReaderAdmin.GetReader((int)dgvReader["rdlD ", dgvReader.CurrentCell.RowIndex].Value);
            SetReaderToText();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SetStatus(opStatus.inSelect);
        }
    }
}
