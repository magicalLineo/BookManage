using System;
using System.Data;
using System.Data.SqlClient;
using BookManage.Model;

namespace BookManage.DAL
{
    public class BorrowDAL
    {
        public static int Insert(Borrow borrow)
        {
            int rows = 0;
            string sql = "insert into Borrow(rdID, bkID, IdContinueTimes, IdDateOut, IdDateRetPlan, IdDateRetAct, IdOverDay, IdOverMoney, IdPunishMoney, IsHasReturn, OperatorLend, OperatorRet)"
                + "values (@rdID, @bkID, @IdContinueTimes, @IdDateOut, @IdDateRetPlan, @IdDateRetAct, @IdOverDay, @IdOverMoney, @IdPunishMoney, @IsHasReturn, @OperatorLend, @OperatorRet)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@rdID", borrow.rdID),
                new SqlParameter("@bkID", borrow.bkID),
                new SqlParameter("@IdContinueTimes", borrow.IdContinueTimes),
                new SqlParameter("@IdDateOut", borrow.IdDateOut),
                new SqlParameter("@IdDateRetPlan", borrow.IdDateRetPlan),
                new SqlParameter("@IdDateRetAct", borrow.IdDateRetAct),
                new SqlParameter("@IdOverDay", borrow.IdOverDay),
                new SqlParameter("@IdOverMoney", borrow.IdOverMoney),
                new SqlParameter("@IdPunishMoney", borrow.IdPunishMoney),
                new SqlParameter("@IsHasReturn", borrow.IsHasReturn),
                new SqlParameter("@OperatorLend", borrow.OperatorLend),
                new SqlParameter("@OperatorRet", borrow.OperatorRet)
            };
            try
            {
                rows = SqlHelper.ExecuteNonQuery(sql, parameters);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return rows;
        }
        public static int UpdateBook(Borrow borrow)
        {
            int rows = 0;
            string sql = "update Book set bkNum=bkNum-1, bkStatus='借出' where bkID=@bkID";
            SqlParameter[] parameters = { new SqlParameter("@bkID", borrow.bkID) };
            try
            {
                rows = SqlHelper.ExecuteNonQuery(sql, parameters);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return rows;
        }
        public static int UpdateBorrowNum(Reader reader)
        {
            int rows = 0;
            string sql = "update Reader set rdBorrowQty=rdBorrowQty+1 where rdID=@rdID";
            SqlParameter[] parameters = { new SqlParameter("@rdID", reader.rdID) };
            try
            {
                rows = SqlHelper.ExecuteNonQuery(sql, parameters);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return rows;
        }
        public static int UpdateContinue(Borrow borrow)
        {
            int rows = 0;
            string sql = "update Borrow set "
                + "IdContinueTimes=@IdContinueTimes+1, "
                + "IdDateOut=@IdDateOut, "
                + "IdDateRetPaln=@IdDateRetPlan "
                + "where BorrowId=@BorrowId";
            SqlParameter[] parameters =
            {
                new SqlParameter("@BorrowId", borrow.BorrowID),
                new SqlParameter("@IdContinueTimes", borrow.IdContinueTimes),
                new SqlParameter("@IdDateOut", borrow.IdDateOut),
                new SqlParameter("@IdDateRetPlan", borrow.IdDateRetPlan)
            };
            try
            {
                rows = SqlHelper.ExecuteNonQuery(sql, parameters);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return rows;
        }
        public static int UpdateBack(Borrow borrow)
        {
            int rows = 0;
            string sql = "update Borrow set "
                + "IdContinueTimes=0. "
                + "IdDateRetAct=@IdDateRetAct, "
                + "IdOverDay=@IdOverDay, "
                + "IdOverMoney=@IdOverMoney, "
                + "IsHasReturn=1 "
                + "where BorrowId=@BorrowId";
            SqlParameter[] parameters =
            {
                new SqlParameter("@BorrowID", borrow.BorrowID),
                new SqlParameter("@IdDateRetAct", borrow.IdDateRetAct),
                new SqlParameter("@IdOverDay", borrow.IdOverDay),
                new SqlParameter("@IdOverMoney", borrow.IdOverMoney)
            };
            try
            {
                rows = SqlHelper.ExecuteNonQuery(sql, parameters);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return rows;
        }
        public static int UpdateBk(Borrow borrow)
        {
            int rows = 0;
            string sql = "update Book set bkNum=bkNum+1, bkStatus='在馆' where bkID=@bkID";
            SqlParameter[] parameters = { new SqlParameter("@bkID", borrow.bkID) };
            try
            {
                rows = SqlHelper.ExecuteNonQuery(sql, parameters);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return rows;
        }
        public static int Delete(Borrow borrow)
        {
            int rows = 0;
            string sql = "delete from Borrow where BorrowID=@BorrowID";
            SqlParameter[] parameters = { new SqlParameter("@BorrowID", borrow.BorrowID) };
            try
            {
                rows = SqlHelper.ExecuteNonQuery(sql, parameters);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return rows;
        }
        public static DataTable GetBookID(int bkID)
        {
            string sql = "select * from Book where bkID=@bkID";
            SqlParameter[] parameters = { new SqlParameter("@bkID", bkID) };
            return SqlHelper.GetDataTable(sql, parameters, "Book");
        }
        public static DataTable GetBookName(string bkName)
        {
            bkName = (bkName == "") ? ("%") : ("%" + bkName + "%");
            string sql = "select * from Book where bkName like @bkName";
            SqlParameter[] parameters = { new SqlParameter("@bkName", bkName) };
            return SqlHelper.GetDataTable(sql, parameters, "Book");
        }
        public static DataRow GetDRByID(int BorrowID)
        {
            string sql = "select * from Borrow where BorrowID=@BorrowId";
            SqlParameter[] parameters = { new SqlParameter("@BorrowID", BorrowID) };
            DataTable dt = null;
            dt = SqlHelper.GetDataTable(sql, parameters, "Borrow");
            DataRow dr = null;
            if (dt == null || dt.Rows.Count == 0)
            {
                return dr;
            }
            else
            {
                dr = dt.Rows[0];
                return dr;
            }
        }
        public static Borrow GetObjectByID(int BorrowID)
        {
            DataRow dr = GetDRByID(BorrowID);
            return SqlHelper.DataRowToT<Borrow>(dr);
        }
        public static DataTable GetBorrow(int rdID)
        {
            string sql;
            if (rdID == 0)
            {
                return null;
            }
            else
            {
                sql = "select Borrow.BorrowId, Book.bkID, Book.bkName, Book.bkAuthor, Borrow.IdContinueTimes, Borrow.IdDateOut, Borrow.IdDateRetAct"
                    + "from Book, Borrow where Book.bkID=Borrow.bkID and Borrow.rdID=@rdID and Borrow.IsHasReturn=0";
                SqlParameter[] parameters = { new SqlParameter("@rdID", rdID) };
                return SqlHelper.GetDataTable(sql, parameters, "Book");
            }
        }
        public static DataTable GetReader(int rdID)
        {
            string sql;
            if (rdID == 0)
            {
                return null;
            }
            else
            {
                sql = "select * from Reader where rdID=@rdID";
                SqlParameter[] parameters = { new SqlParameter("@rdID", rdID) };
                return SqlHelper.GetDataTable(sql, parameters, "Reader");
            }
        }
        public static DataTable GetBorrowBook(int rdID)
        {
            string sql = "select * from Borrow where rdID=@rdID";
            SqlParameter[] parameters = { new SqlParameter("@rdID", rdID) };
            return SqlHelper.GetDataTable(sql, parameters, "ReaderType");
        }

        public static DataTable GetrdStatus(int rdID)
        {
            string sql = "select rdStatus, rdBorrowQty from Reader where rdID=@rdID";
            SqlParameter[] parameters = { new SqlParameter("@rdID", rdID) };
            return SqlHelper.GetDataTable(sql, parameters, "Reader");
        }

        public static DataTable GetbkStatus(int bkID)
        {
            string sql = "select bkStatus from Book where bkID=@bkID";
            SqlParameter[] parameters = { new SqlParameter("@bkID", bkID) };
            return SqlHelper.GetDataTable(sql, parameters, "Book");
        }
    }
}
