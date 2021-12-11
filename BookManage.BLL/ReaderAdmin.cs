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
    }
}
