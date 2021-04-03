﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IEmptyRoomService
    {
        IDataResult<List<EmptyRoom>> GetAll();
        IDataResult<List<EmptyRoom>> GetById(int id);
        IResult Add(EmptyRoom emptyRoom);
        IResult Update(EmptyRoom emptyRoom);
        IResult Delete(EmptyRoom emptyRoom);
    }
}