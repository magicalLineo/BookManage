using System;

namespace BookManage.Model
{
    public class Borrow
    {
        public long BorrowID { get; set; }
        public int rdID { get; set; }
        public int bkID { get; set; }
        public int IdContinueTimes { get; set; }
        public DateTime IdDateOut { get; set; }
        public DateTime IdDateRetPlan { get; set; }
        public DateTime IdDateRetAct { get; set; }
        public int IdOverDay { get; set; }
        public float IdOverMoney { get; set; }
        public float IdPunishMoney { get; set; }
        public bool IsHasReturn { get; set; }
        public string OperatorLend { get; set; }
        public string OperatorRet { get; set; }
        public Borrow()
        {

        }
        public Borrow(Borrow rt)
        {
            this.BorrowID = rt.BorrowID;
            this.rdID = rt.rdID;
            this.bkID = rt.bkID;
            this.IdContinueTimes = rt.IdContinueTimes;
            this.IdDateOut = rt.IdDateOut;
            this.IdDateRetPlan = rt.IdDateRetPlan;
            this.IdDateRetAct = rt.IdDateRetAct;
            this.IdOverDay = rt.IdOverDay;
            this.IdOverDay = rt.IdOverDay;
            this.IdOverMoney = rt.IdOverMoney;
            this.IdPunishMoney = rt.IdPunishMoney;
            this.IsHasReturn = rt.IsHasReturn;
            this.OperatorLend = rt.OperatorLend;
            this.OperatorRet = rt.OperatorRet;
        }
        public static string ColumnTitle(string columnName)
        {
            string sTitle;
            sTitle = columnName;
            switch (columnName)
            {
                case "bkID": sTitle = "图书序号"; break;
                case "bkName": sTitle = "图书名称"; break;
                case "bkAuthor": sTitle = "图书作者"; break;
                case "IdContinueTimes": sTitle = "续借次数"; break;
                case "IdDateOut": sTitle = "借书日期"; break;
                case "IdDateRetPlan": sTitle = "应还日期"; break;
                case "IdOverDay": sTitle = "超期天数"; break;
                case "IdOverMoney": sTitle = "超期金额"; break;
            }
            return sTitle;
        }
    }
}