namespace ProductMvc.Entity.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public int UserID { get; set; }

        [Required]
        
        public string UserName { get; set; }

        [Required]
        
        public string Password { get; set; }

        [StringLength(50)]
        [Display(Name ="Địa chỉ")]
        public string Address { get; set; }

        [StringLength(50)]
        [Display(Name = "Họ và tên")]
        public string FullName { get; set; }

        [Display(Name = "Giới tính")]
        public bool? Sex { get; set; }

        [StringLength(20)]
        [Display(Name = "Điện thoại")]
        public string Phone { get; set; }

        public int? RoleID { get; set; }

        public bool? Lock { get; set; }
    }
}
