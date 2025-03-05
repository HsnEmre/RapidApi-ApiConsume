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
    public class MessageCategoryManager : IMessageCategoryService
    {

        private readonly IMessageCategoryDal _messageCategoryDal;

        public MessageCategoryManager(IMessageCategoryDal messageCategoryDal)
        {
            _messageCategoryDal= messageCategoryDal;
        }

        public void TDelete(MessageCategory entity)
        {
           
        }

        public MessageCategory TGetById(int id)
        {
          return _messageCategoryDal.GetByID(id);
        }

        public List<MessageCategory> TGetList()
        {
            return _messageCategoryDal.GetList();
        }

        public void TInsert(MessageCategory entity)
        {
           
        }

        public void TUpdate(MessageCategory entity)
        {
           
        }
    }
}
