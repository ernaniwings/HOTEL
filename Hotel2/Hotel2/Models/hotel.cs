using Hotel2.Models.Base;
using System.Collections.Generic;

namespace Hotel2.Models
{

    public class Hotel : EntityBase
    {
        public Hotel()
        {
            Rooms = new List<Room>();
            Clients = new List<Client>();
        }
        public string Name { get; set; }
        public string Description { get; set; }

        public int ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        public virtual IList<Room> Rooms { get; set; }
        public virtual IList<Client> Clients { get; set; }
    }
}
