using System;
using System.Data;
using System.Data.SqlClient;
using BookManage.Model;

namespace BookManage.DAL
{
    public class ReaderTypeDAL
    {
        public static int Insert(ReaderType readertype) {
            int rows = 0;
            string sql = "insert into ReaderType(rdType, rdTypeName, CanLendQty, CanLendDay, CanContinueTimes, PunishRate, DateValid) "
                + "values (@rdType, @rdTypeName, @CanLendQty, @CanLendDay, @CanContinueTimes, @PunishRate, @DateValid)";
            SqlParameter[] parameters = {
                new SqlParameter("@rdType", readertype.rdType),
                new SqlParameter("@rdTypeName", readertype.rdTypeName),
                new SqlParameter("@CanLendQty", readertype.CanLendQty),
                new SqlParameter("@CanLendDay", readertype.CanLendDay),
                new SqlParameter("@CanContinueTimes", readertype.CanContinueTimes),
                new SqlParameter("@PunishRate", readertype.PunishRate),
                new SqlParameter("@DateValid", readertype.DateValid)
            };
            try {
                rows = SqlHelper.ExecuteNonQuery(sql, parameters);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return rows;
        }
        public static int Delete(ReaderType readertype)
        {
            int rows = 0;
            string sql = "delete from ReaderType where rdType=@rdType";
            SqlParameter[] parameters = { new SqlParameter("@rdType", readertype.rdType) };
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
        public static int Update(ReaderType readertype)
        {
            int rows = 0;
            string sql = "update ReaderType set "
                + "rdType=@rdType, "
                + "rdTypeName=@rdTypeName, "
                + "CanLendQty=@CanLendQty, "
                + "CanLendDay=@CanLendDay, "
                + "CanContinueTimes=@CanContinueTimes, "
                + "PunishRate=@PunishRate, "
                + "DateValid=@DateValid "
                + "where rdType=@rdType";
            SqlParameter[] parameters ={
                new SqlParameter ("@rdType",readertype.rdType),
                new SqlParameter("@rdTypeName",readertype.rdTypeName),
                new SqlParameter("@CanLendQty",readertype.CanLendQty),
                new SqlParameter("@CanLendDay",readertype.CanLendDay),
                new SqlParameter("@CanContinueTimes",readertype.CanContinueTimes),
                new SqlParameter("@PunishRate", readertype.PunishRate),
                new SqlParameter("@DateValid", readertype.DateValid)
            };
            try
            {
                rows = SqlHelper.ExecuteNonQuery(sql, parameters);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return rows ;
        }
        public static DataRow GetDRByID(string rdType)
        {
            string sql = "select * from ReaderType where rdType=@rdType";
            SqlParameter[] parameters =
            {
                new SqlParameter("@rdType", rdType)
            };
            DataTable dt = null;
            dt = SqlHelper.GetDataTable(sql, parameters, "ReaderType");
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
        public static ReaderType GetObjectByID(string rdType)
        {
            DataRow dr = GetDRByID(rdType);
            return SqlHelper.DataRowToT<ReaderType>(dr);
        }
        public static DataTable GetAll()
        {
            string sql = "select * from ReaderType";
            return SqlHelper.GetDataTable(sql, null, "ReaderType");
        }
        public static DataTable GetReaderType()
        {
            string sql;
            sql = "select * from ReaderType";
            return SqlHelper.GetDataTable(sql, null, "ReaderType");
        }
    }
}