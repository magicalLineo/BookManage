﻿namespace BookManage.Model
{
    public class ReaderType
    {
        public int rdType { get; set; }
        public string rdTypeName { get; set; }
        public int CanLendQty { get; set; }
        public int CanLendDay { get; set; }
        public int CanContinueTimes { get; set; }
        public float PunishRate { get; set; }
        public int DateValid { get; set; }
        public ReaderType()
        {

        }
        public ReaderType(ReaderType rt)
        {
            this.rdType = rt.rdType;
            this.rdTypeName = rt.rdTypeName;
            this.CanLendQty = rt.CanLendQty;
            this.CanLendDay = rt.CanLendDay;
            this.CanContinueTimes = rt.CanContinueTimes;
            this.PunishRate = rt.PunishRate;
            this.DateValid = rt.DateValid;
        }
        public static string ColumnTitle(string columnName)
        {
            string sTitle;
            sTitle = columnName;
            switch (columnName)
            {
                case "rdType":
                    sTitle = "读者类别";
                    break;
                case "rdTypeName":
                    sTitle = "类型名称";
                    break;
                case "CanLendQty":
                    sTitle = "可借书数量";
                    break;
                case "CanLendDay":
                    sTitle = "可借书天数";
                    break;
                case "CanContinueTimes":
                    sTitle = "可续借次数";
                    break;
                case "PunishRate":
                    sTitle = "罚款率";
                    break;
                case "DateValid":
                    sTitle = "证件有效期";
                    break;
            }
            return sTitle;
        }
    }
}
