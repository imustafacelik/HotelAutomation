﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class FullRoom:IEntity
    {
        public int Id { get; set; }
        public string RoomName { get; set; }
    }
}