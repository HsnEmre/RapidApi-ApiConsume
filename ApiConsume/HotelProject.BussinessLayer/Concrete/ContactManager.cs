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
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }
        public void TDelete(Contact entity)
        {
           
        }

        public Contact TGetById(int id)
        {
            return _contactDal.GetByID(id);
        }

        public List<Contact> TGetList()
        {
            return _contactDal.GetList();
        }

        public void TInsert(Contact entity)
        {
            _contactDal.insert(entity);
        }

        public void TUpdate(Contact entity)
        {
            throw new NotImplementedException();
        }
    }
}
