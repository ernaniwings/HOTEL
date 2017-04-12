using Hotel2.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel2.Models
{
    public class Client : EntityBase
    {
        public virtual Hotel Hotel { get; set; }
        public int HotelId { get; set; }

        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}