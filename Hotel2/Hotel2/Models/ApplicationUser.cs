using Hotel2.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel2.Models
{
    public class ApplicationUser : EntityBase
    {
        public string Name { get; set; }
        public string CreditCardNumber { get; set; }
        public string Pass { get; set; }
        public string Email { get; set; }
        public virtual IList<Hotel> Hotels{ get; set; }
    }
}