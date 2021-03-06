//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaMotors.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Inventory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Inventory()
        {
            this.Photos = new HashSet<Photo>();
        }
    
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<int> Miles { get; set; }
        public Nullable<int> Price { get; set; }
        public string Transmission { get; set; }
        public string Engine { get; set; }
        public string Fuel { get; set; }
        public string Body { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Photo> Photos { get; set; }
    }
}
