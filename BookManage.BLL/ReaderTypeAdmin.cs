using BookManage.Model;
using BookManage.DAL;
using System.Data;

namespace BookManage.BLL
{
    public class ReaderTypeAdmin
    {
        public static ReaderType GetReaderType(string rdType)
        {
            return (ReaderTypeDAL.GetObjectByID(rdType));
        }
        public DataTable GetReaderType()
        {
            return (ReaderTypeDAL.GetReaderType());
        }
        public int Insert(ReaderType readertype)
        {
            return (ReaderTypeDAL.Insert(readertype));
        }
        public int Update(ReaderType readertype)
        {
            return (ReaderTypeDAL.Update(readertype));
        }
        public int Delete(ReaderType readertype)
        {
            return (ReaderTypeDAL.Delete(readertype));
        }
    }
}
