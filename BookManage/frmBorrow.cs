using BookManage.BLL;
using BookManage.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace BookManage
{
    public partial class frmBorrow : Form
    {
        private DataTable dt = null;
        private DataTable dm = null;
        private BorrowAdmin borrowBLL = new BorrowAdmin();
        public frmBorrow()
        {
            InitializeComponent();
        }

        private void ShowBorrowData()
        {
            dgvBorrow.DataSource = dt;
            foreach (DataColumn dc in dt.Columns)
            {
                dgvBorrow.Columns[dc.ColumnName].HeaderText = Borrow.ColumnTitle(dc.ColumnName);
            }
        }
        private void ShowReaderData()
        {
            dgvReader.DataSource = dt;
            foreach (DataColumn dc in dt.Columns)
            {
                dgvReader.Columns[dc.ColumnName].HeaderText = Reader.ColumnTitle(dc.ColumnName);
            }
        }
        private void ShowData()
        {
            dgvBook.DataSource = dt;
            foreach (DataColumn dc in dt.Columns)
            {
                dgvBook.Columns[dc.ColumnName].HeaderText = Book.ColumnTitle(dc.ColumnName);
            }
        }

        private void btnSelectID_Click(object sender, EventArgs e)
        {
            int bkID;
            if (txtbkID.Text.Trim() == "")
            {
                bkID = 0;
            }
            else
            {
                int i = txtbkID.Text.IndexOf("--");
                if (i > 0)
                {
                    bkID = Convert.ToInt32(txtbkID.Text.Substring(0, i));
                }
                else
                {
                    bkID = Convert.ToInt32(txtbkID.Text);
                }
            }
            dt = borrowBLL.GetBookID(bkID);
            ShowData();
        }
        private void btnSelectName_Click(object sender, EventArgs e)
        {
            string bkName;
            if (txtbkName.Text.Trim() == "")
            {
                bkName = null;
            }
            else
            {
                bkName = txtbkName.Text;
            }
            dt = borrowBLL.GetBookName(bkName);
            ShowData();
        }
        private void btnSelectbkID_Click(object sender, EventArgs e)
        {
            int rdID;
            if (txtrdID.Text.Trim() == "")
            {
                rdID = 0;
            }
            else
            {
                int i = txtrdID.Text.IndexOf("--");
                if (i > 0)
                {
                    rdID = Convert.ToInt32(txtrdID.Text.Substring(0, i));
                }
                else
                {
                    rdID = Convert.ToInt32(txtrdID.Text);
                }
            }
            dt = borrowBLL.GetReader(rdID);
            ShowReaderData();
            dt = borrowBLL.GetBorrow(rdID);
            ShowBorrowData();
        }


        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            int rdID, rdType, bkID;
            int CanLendQty, CanLendDay, rdBorrowQty;
            string rdStatus, bkStatus;
            Borrow borrow = new Borrow();
            Reader reader = new Reader();
            DataRow dr = null;
            DataRow ds = null;
            dr = (dgvBook.CurrentRow.DataBoundItem as DataRowView).Row;
            ds = (dgvReader.CurrentRow.DataBoundItem as DataRowView).Row;

            rdID = Convert.ToInt32(txtrdID.Text);
            rdType = Convert.ToInt32(ds.ItemArray[3]);

            dt = borrowBLL.GetReaderType(rdType);
            CanLendQty = Convert.ToInt32(dt.Rows[0][0]);
            CanLendDay = Convert.ToInt32(dt.Rows[0][1]);

            dm = borrowBLL.GetrdStatus(rdID);
            rdStatus = Convert.ToString(dm.Rows[0][0]);
            rdBorrowQty = Convert.ToInt32(dm.Rows[0][1]);

            bkStatus = Convert.ToString(dr.ItemArray[15]);

            if (rdStatus != "有效")
            {
                MessageBox.Show("借书证无效，无法借书，无法借书！");
            }
            else
            {
                if (bkStatus != "在馆")
                {
                    MessageBox.Show("对不起，该书已不在馆！！");
                }
                else
                {
                    if (rdBorrowQty >= CanLendQty)
                    {
                        MessageBox.Show("已借书数超出最大可借书量，无法借书！");
                    }
                    else
                    {
                        borrow.rdID = rdID;
                        borrow.bkID = Convert.ToInt32(dr.ItemArray[0]);
                        borrow.IdContinueTimes = 0;
                        borrow.IdDateOut = DateTime.Now;
                        borrow.IdDateRetPlan = DateTime.Now.AddDays(CanLendDay);
                        borrow.IdDateRetAct = DateTime.Now;
                        borrow.IdOverDay = 0;
                        borrow.IdOverMoney = 0;
                        borrow.IdPunishMoney = 0;
                        borrow.IsHasReturn = false;
                        borrow.OperatorLend = Convert.ToString(ds.ItemArray[1]);
                        borrow.OperatorRet = Convert.ToString(ds.ItemArray[1]);
                        borrowBLL.Insert(borrow);
                        txtbkName.Text = Convert.ToString(borrow.rdID);
                        borrowBLL.UpdateBook(borrow);
                        reader.rdID = rdID;
                        borrowBLL.UpdateBorrowNum(reader);
                        MessageBox.Show("借书成功！！！");
                    }
                }
            }
        }

        //续借
        private void btnConBorrow_Click(object sender, EventArgs e)
        {
            int rdType, CanLendDay, CanContinueTimes;
            Borrow borrow = new Borrow();
            DataRow dr = null;
            DataRow ds = null;
            for (int i = 0; i < dgvBorrow.SelectedRows.Count; i++)
            {
                dr = (dgvBorrow.SelectedRows[i].DataBoundItem as DataRowView).Row;
            }
            for (int j = 0; j < dgvReader.SelectedRows.Count; j++)
            {
                ds = (dgvReader.SelectedRows[j].DataBoundItem as DataRowView).Row;
            }
            rdType = Convert.ToInt32(ds.ItemArray[3]);
            dt = borrowBLL.GetReaderType(rdType);
            CanLendDay = Convert.ToInt32(dt.Rows[0][1]);
            CanContinueTimes = Convert.ToInt32(dt.Rows[0][2]);
            if (Convert.ToInt32(dr.ItemArray[4]) >= CanContinueTimes)
            {
                MessageBox.Show("对不起，您的续借次数已超出最大可续借次数！");
            }
            else
            {
                borrow.BorrowID = Convert.ToInt32(dr.ItemArray[0]);
                borrow.IdContinueTimes = Convert.ToInt32(dr.ItemArray[4]);
                borrow.IdDateOut = DateTime.Now;
                borrow.IdDateRetPlan = DateTime.Now.AddDays(CanLendDay);
                borrowBLL.UpdateContinue(borrow);
                MessageBox.Show("续借成功！");
            }
        }

        private void btnRetBook_Click(object sender, EventArgs e)
        {
            int rdType, CanLendDay;
            int OverDay;
            float PunishRate;
            float OverMoney;
            Borrow borrow = new Borrow();
            DataRow dr = null;
            DataRow ds = null;
            for (int i = 0; i < dgvBorrow.SelectedRows.Count; i++)
            {
                dr = (dgvBorrow.SelectedRows[i].DataBoundItem as DataRowView).Row;
            }
            for (int j = 0; j < dgvReader.SelectedRows.Count; j++)
            {
                ds = (dgvReader.SelectedRows[j].DataBoundItem as DataRowView).Row;
            }
            rdType = Convert.ToInt32(ds.ItemArray[3]);
            dt = borrowBLL.GetReaderType(rdType);
            PunishRate = Convert.ToSingle(dt.Rows[0][3]);
            CanLendDay = Convert.ToInt32(dt.Rows[0][1]);

            DateTime d1 = Convert.ToDateTime(dr.ItemArray[6]);
            DateTime d2 = DateTime.Now;
            System.TimeSpan d3 = d2 - d1;
            OverDay = d3.Days;
            if (OverDay >= CanLendDay)
            {
                OverMoney = (float)(OverDay) * PunishRate;
            }
            else
            {
                OverMoney = 0;
            }

            borrow.BorrowID = Convert.ToInt32(dr.ItemArray[0]);
            borrow.bkID = Convert.ToInt32(dr.ItemArray[1]);
            borrow.IdDateRetAct = DateTime.Now;
            borrow.IdOverDay = OverDay;
            borrow.IdOverMoney = OverMoney;
            borrowBLL.UpdateBack(borrow);
            borrowBLL.UpdateBk(borrow);
            MessageBox.Show("还书成功！");
        }
    }
}
