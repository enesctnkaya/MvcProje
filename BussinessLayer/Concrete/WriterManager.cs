using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class WriterManager : IWriterService
    //implement etmek tasarımı somut hale getirmek için kullanılır
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public Writer GetByID(int id)
        {
            return _writerDal.Get( x=>x.WriterID == id);
        }

        public List<Writer> GetList()
        {
            return _writerDal.List();
        }

        public void WriteAdd(Writer writer)
        {
            _writerDal.Insert(writer);
        }

        public void WriteDelete(Writer writer)
        {
            _writerDal.Delete(writer);
        }

        public void WriteUpdate(Writer writer)
        {
            _writerDal.Update(writer);
        }

        public void RegisterWriter(Writer writer)
        {
            _writerDal.Insert(writer);
        }
    }
}
