using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class FullRoomManager : IFullRoomService
    {
        IFullRoomDal _fullRoomDal;
        public FullRoomManager(IFullRoomDal fullRoomDal)
        {
            _fullRoomDal = fullRoomDal;
        }

        public IResult Add(FullRoom fullRoom)
        {
            _fullRoomDal.Add(fullRoom);
            return new SuccessResult();
        }

        public IResult Delete(FullRoom fullRoom)
        {
            _fullRoomDal.Delete(fullRoom);
            return new SuccessResult();
        }

        public IDataResult<List<FullRoom>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<FullRoom>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(FullRoom fullRoom)
        {
            throw new NotImplementedException();
        }
    }
}
