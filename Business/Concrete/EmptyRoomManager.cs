using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class EmptyRoomManager : IEmptyRoomService
    {
        IEmptyRoomDal _emptyRoomDal;
        public EmptyRoomManager(IEmptyRoomDal emptyRoomDal)
        {
            _emptyRoomDal = emptyRoomDal;
        }

        public IResult Add(EmptyRoom emptyRoom)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(EmptyRoom emptyRoom)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<EmptyRoom>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<EmptyRoom>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(EmptyRoom emptyRoom)
        {
            throw new NotImplementedException();
        }
    }
}
