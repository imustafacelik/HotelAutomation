using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int RoomId { get; set; }
        public string RoomDescription { get; set; }
    }
}
