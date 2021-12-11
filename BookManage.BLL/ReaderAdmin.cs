using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManage.Model;

namespace BookManage.BLL
{
    public class ReaderAdmin
    {
        public Reader GetReader(int rdID)
        {
            return (DAL.ReaderDAL.GetObjectByID(rdID));
        }
    }
}
