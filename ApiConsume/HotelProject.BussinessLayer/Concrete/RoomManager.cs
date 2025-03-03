﻿using HotelProject.BussinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BussinessLayer.Concrete
{
    public class RoomManager : IRoomService
    {
        private readonly IRoomDal _roomDal;

        public RoomManager(IRoomDal roomDal)
        {
                _roomDal=roomDal;
        }
        public Room TGetById(int id)
        {
            return _roomDal.GetByID(id);
        }

        public void TDelete(Room entity)
        {
            _roomDal.Delete(entity);
        }

        public List<Room> TGetList()
        {
            return _roomDal.GetList();
        }

        public void TInsert(Room entity)
        {
            _roomDal.insert(entity);
        }

        public void TUpdate(Room entity)
        {
            _roomDal.Update(entity);
        }
    }
}
