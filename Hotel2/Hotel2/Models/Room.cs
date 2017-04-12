using Hotel2.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel2.Models
{
    public class Room : EntityBase
    {
        public RoomType Type { get; set; }
        public double Value { get; set; }
    }

    public enum RoomType
    {
        Casal,
        Solteiro
    }
}