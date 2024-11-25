using HotelProject.BussinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BussinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutdal;

        public void TDelete(About entity)
        {
            _aboutdal.Delete(entity);
        }

        public About TGetById(int id)
        {
            return _aboutdal.GetByID(id);
        }

        public List<About> TGetList()
        {
           return _aboutdal.GetList();
        }

        public void TInsert(About entity)
        {
            _aboutdal.insert(entity);
        }

        public void TUpdate(About entity)
        {
            _aboutdal.Update(entity);
        }
    }
}
