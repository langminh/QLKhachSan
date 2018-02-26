namespace ProductMvc.Entity.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Room")]
    public partial class Room
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Room()
        {
            InOuts = new HashSet<InOut>();
        }

        public int RoomId { get; set; }

        [Required]
        public string RoomName { get; set; }

        public int FloorId { get; set; }

        public bool Status { get; set; }

        public bool IsDouble { get; set; }

        public virtual Floor Floor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InOut> InOuts { get; set; }
    }
}
