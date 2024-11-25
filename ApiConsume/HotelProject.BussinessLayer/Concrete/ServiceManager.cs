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
    public class ServiceManager : IServiceService
    {
        private readonly IServicesDal _service;

        public ServiceManager(IServicesDal daş)
        {
            _service = daş;
        }
        public void TDelete(Service entity)
        {
            _service.Delete(entity);
        }

        public Service TGetById(int id)
        {
            return _service.GetByID(id);
        }

        public List<Service> TGetList()
        {
            return _service.GetList();
        }

        public void TInsert(Service entity)
        {
             _service.insert(entity);
        }

        public void TUpdate(Service entity)
        {
            _service.Update(entity);
        }
    }
}
