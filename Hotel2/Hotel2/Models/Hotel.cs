using Hotel2.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel2.Models
{
    public class Hotel : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public int ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public virtual IList<Client> Clients { get; set; }
    }
}