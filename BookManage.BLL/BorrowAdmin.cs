using System.Data;
using BookManage.Model;
using BookManage.DAL;

namespace BookManage.BLL
{
    public class BorrowAdmin
    {
        public static Borrow GetBookInformation(int bkID)
        {
            return (BorrowDAL.GetObjectByID(bkID));
        }

        public DataTable GetBookID(int bkID)
        {
            return (BorrowDAL.GetBookID(bkID));
        }
        public DataTable GetBookName(string bkName)
        {
            return (BorrowDAL.GetBookName(bkName));
        }
        public int Insert(Borrow borrow)
        {
            return (BorrowDAL.Insert(borrow));
        }
        public DataTable GetBorrow(int rdID)
        {
            return (BorrowDAL.GetBorrow(rdID));
        }
        public DataTable GetReader(int rdID)
        {
            return (BorrowDAL.GetReader(rdID));
        }
        public int UpdateBook(Borrow borrow)
        {
            return (BorrowDAL.UpdateBook(borrow));
        }
        public int UpdateBorrowNum(Reader reader)
        {
            return (BorrowDAL.UpdateBorrowNum(reader));
        }

        public int UpdateContinue(Borrow borrow)
        {
            return (BorrowDAL.UpdateContinue(borrow));
        }
        public int UpdateBack(Borrow borrow)
        {
            return (BorrowDAL.UpdateBack(borrow));
        }
        public int UpdateBk(Borrow borrow)
        {
            return (BorrowDAL.UpdateBk(borrow));
        }
        public DataTable GetReaderType(int rdType)
        {
            return (BorrowDAL.GetReaderType(rdType));
        }
        public DataTable GetrdStatus(int rdID)
        {
            return (BorrowDAL.GetrdStatus(rdID));
        }
        public DataTable GetbkStatus(int bkID)
        {
            return (BorrowDAL.GetbkStatus(bkID));
        }
    }
}
