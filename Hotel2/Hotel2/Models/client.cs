namespace Hotel2.Models
{
    using Base;
    using System;
    using System.Collections.Generic;

    public class Client : EntityBase
    {
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public int HotelId { get; set; }
        public virtual Hotel Hotel { get; set; }
    }
}
