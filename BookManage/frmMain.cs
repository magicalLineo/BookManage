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

            
        }
    }
}
