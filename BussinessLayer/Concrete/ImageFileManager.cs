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
    public class ImageFileManager : IImageFileService
    {
        IImageFileDal _ımagefileDal;

        public ImageFileManager(IImageFileDal ımagefileDal)
        {
            _ımagefileDal = ımagefileDal;
        }

        public List<ImageFile> GetList()
        {
            return _ımagefileDal.List();
        }
    }
}
