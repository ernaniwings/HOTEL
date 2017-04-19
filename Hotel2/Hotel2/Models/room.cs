namespace Hotel2.Models
{
    using Base;
    using System;
    using System.Collections.Generic;

    public class Room : EntityBase
    {
        public int Type { get; set; }
        public int HotelId { get; set; }
        public virtual Hotel Hotel { get; set; }
    }
}
