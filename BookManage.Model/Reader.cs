using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManage.Model
{
    public class Reader
    {
        public int rdID { get; set; }
        public string rdName { get; set; }
        public string rdSex { get; set; }
        public int rdType { get; set; }
        public string rdDept { get; set; }
        public string rdPhone { get; set; }
        public string rdEmail { get; set; }
        public DateTime rdDateReg { get; set; }
        public byte[] rdPhoto { get; set; }
        public string rdStatus { get; set; }
        public int rdBorrowQty { get; set; }
        public string rdPwd { get; set; }
        public int rdAdminRoles { get; set; }
        public Reader()
        {

        }
        public Reader(Reader rt)
        {
            this.rdID = rt.rdID;
            this.rdName = rt.rdName;
            this.rdSex = rt.rdSex;
            this.rdType = rt.rdType;
            this.rdDept = rt.rdDept;
            this.rdphone = rt.rdphone;
            this.rdEmail = rt.rdEmail;
            this.rdDateReg = rt.rdDateReg;
            this.rdPhoto = rt.rdPhoto;
            this.rdStatus = rt.rdStatus;
            this.rdBorrowQty = rt.rdBorrowQty;
            this.rdPwd = rt.rdPwd;
            this.rdAdminRoles = rt.rdAdminRoles;
        }
        public static string ColumnTitle(string columnName)
        {
            string sTitle;
            sTitle = columnName;
            switch (columnName)
            {
                case "rdID":
                    sTitle = "借书证号";
                    break;
                case "rdName":
                    sTitle = "姓名";
                    break;
                case "rdSex":
                    sTitle = "性别";
                    break;
                case "rdType":
                    sTitle = "读者类别";
                    break;
                case "rdDept":
                    sTitle = "单位";
                    break;
                case "rdPhone":
                    sTitle = "电话";
                    break;
                case "rdEmail":
                    sTitle = "邮箱";
                    break;
                case "rdDateReg":
                    sTitle = "办证日期";
                    break;
                case "rdPhoto":
                    sTitle = "照片";
                    break;
                case "rdStatus":
                    sTitle = "证件状态";
                    break;
                case "rdBorrowQty":
                    sTitle = "已借书";
                    break;
                case "rdPwd":
                    sTitle = "密码";
                    break;
                case "rdAdminRoles":
                    sTitle = "管理员角色";
                    break;
            }
            return sTitle;
        }
    }
}