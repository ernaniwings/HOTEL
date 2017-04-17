using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel2.Models
{
    public class Billing
    {
        public virtual Client Client { get; set; }
        public int ClientId { get; set; }

    }
}