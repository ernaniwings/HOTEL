using Hotel2.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel2.Models
{
    public class Reservation : EntityBase
    {
        public virtual Client Client { get; set; }
        public int ClientId { get; set; }

        public virtual Room Room { get; set; }
        public int RoomId { get; set; }

        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }
    }
}