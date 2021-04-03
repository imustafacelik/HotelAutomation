using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IFullRoomService
    {
        IDataResult<List<FullRoom>> GetAll();
        IDataResult<List<FullRoom>> GetById(int id);
        IResult Add(FullRoom fullRoom);
        IResult Update(FullRoom fullRoom);
        IResult Delete(FullRoom fullRoom);
    }
}
