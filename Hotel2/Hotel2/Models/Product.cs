using Hotel2.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel2.Models
{
    public class Product : EntityBase
    {
        public double Value { get; set; }
        public string Name { get; set; }
    }
}