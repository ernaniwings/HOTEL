//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hotel2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class appUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public appUser()
        {
            this.hotels = new HashSet<hotel>();
        }
    
        public int idUser { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string card { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hotel> hotels { get; set; }
    }
}