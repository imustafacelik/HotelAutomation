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
            _emptyRoomDal.Delete(emptyRoom);
            return new SuccessResult();
        }

        public IDataResult<List<EmptyRoom>> GetAll()
        {
            return new SuccessDataResult<List<EmptyRoom>>(_emptyRoomDal.GetAll());
        }

        public IDataResult<EmptyRoom> GetById(int emptyId)
        {
            return new SuccessDataResult<EmptyRoom>(_emptyRoomDal.Get(e => e.Id == emptyId));
        }

        public IResult Update(EmptyRoom emptyRoom)
        {
            throw new NotImplementedException();
        }

        public void Delete(int v)
        {
            
        }

        public void Delete(string v)
        {
            throw new NotImplementedException();
        }
    }
}
