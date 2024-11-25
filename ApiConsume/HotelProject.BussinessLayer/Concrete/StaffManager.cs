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
    public class StaffManager : IStaffService
    {

        private readonly IStaffDal _staffdal;
        public StaffManager(IStaffDal staffDal)
        {
                _staffdal=staffDal;
        }
        public void TDelete(Staff entity)
        {
            _staffdal.Delete(entity);
        }

        public Staff TGetById(int id)
        {
            return _staffdal.GetByID(id);
        }

        public List<Staff> TGetList()
        {
           return _staffdal.GetList();
        }

        public void TInsert(Staff entity)
        {
            _staffdal.insert(entity);
        }

        public void TUpdate(Staff entity)
        {
            _staffdal.Update(entity);
        }
    }
}
