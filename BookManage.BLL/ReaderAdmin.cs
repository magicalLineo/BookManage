using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManage.Model;
using BookManage.DAL;
using System.Data;

namespace BookManage.BLL
{
    public class ReaderAdmin
    {
        public Reader GetReader(int rdID)
        {
            return (ReaderDAL.GetObjectByID(rdID));
        }
        public DataTable GetAllReaderType()
        {
            return (ReaderTypeDAL.GetAll());
        }
        public DataTable GetReader(int rdType, string rdDept, string rdName)
        {
            return ReaderDAL.GetReader(rdType, rdDept, rdName);
        }

        public int Loss(Reader reader)
        {
            return (ReaderDAL.Loss(reader));
        }

        public int UnLoss(Reader reader)
        {
            return (ReaderDAL.UnLoss(reader));
        }

        public int Delete(Reader reader)
        {
            return (ReaderDAL.Delete(reader));
        }
        public int Insert(Reader reader)
        {
            return (ReaderDAL.Insert(reader));
        }
        public int Update(Reader reader)
        {
            return (ReaderDAL.Update(reader));
        }
    }
}
