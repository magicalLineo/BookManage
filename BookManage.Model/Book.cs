using System;

namespace BookManage.Model
{
    public class Book
    {
        public int bkID { get; set; }
        public string bkCode { get; set; }
        public string bkName { get; set; }
        public string bkAuthor { get; set; }
        public string bkPress { get; set; }
        public DateTime bkDatePress { get; set; }
        public string bkISBN { get; set; }
        public string bkCatalog { get; set; }
        public int bkLanguage { get; set; }
        public int bkPages { get; set; }
        public float bkPrice { get; set; }
        public DateTime bkDateIn { get; set; }
        public int bkNum { get; set; }
        public string bkBrief { get; set; }
        public byte[] bkCover { get; set; }
        public string bkStatus { get; set; }
        public Book()
        {

        }
        public Book(Book rt)
        {
            this.bkID = rt.bkID;
            this.bkCode = rt.bkCode;
            this.bkName = rt.bkName;
            this.bkAuthor = rt.bkAuthor;
            this.bkPress = rt.bkPress;
            this.bkDatePress = rt.bkDatePress;
            this.bkISBN = rt.bkISBN;
            this.bkCatalog = rt.bkCatalog;
            this.bkLanguage = rt.bkLanguage;
            this.bkPages = rt.bkPages;
            this.bkPrice = rt.bkPrice;
            this.bkDateIn = rt.bkDateIn;
            this.bkNum = rt.bkNum;
            this.bkBrief = rt.bkBrief;
            this.bkCover = rt.bkCover;
            this.bkStatus = rt.bkStatus;
        }
        public static string ColumnTitle(string columnName)
        {
            string sTitle;
            sTitle = columnName;
            switch (columnName)
            {
                case "bkID":
                    sTitle = "图书序号";
                    break;
                case "bkCode":
                    sTitle = "图书编号";
                    break;
                case "bkName":
                    sTitle = "图书名称";
                    break;
                case "bkAuthor":
                    sTitle = "图书作者";
                    break;
                case "bkPress":
                    sTitle = "出版社名";
                    break;
                case "bkDatePress":
                    sTitle = "出版日期";
                    break;
                case "bkISBN":
                    sTitle = "标准ISBN";
                    break;
                case "bkCatalog":
                    sTitle = "名称分类";
                    break;
                case "bkLanguage":
                    sTitle = "所属语种";
                    break;
                case "bkPages":
                    sTitle = "图书页数";
                    break;
                case "bkPrice":
                    sTitle = "图书价格";
                    break;
                case "bkDateIn":
                    sTitle = "入馆日期";
                    break;
                case "bkNum":
                    sTitle = "图书本数";
                    break;
                case "bkBrief":
                    sTitle = "图书简介";
                    break;
                case "bkCover":
                    sTitle = "图书封面";
                    break;
                case "bkStatus":
                    sTitle = "图书状态";
                    break;
            }
            return sTitle;
        }
    }
}
