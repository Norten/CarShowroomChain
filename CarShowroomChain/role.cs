namespace CarShowroomChain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("polsl_agatek_bd.role")]
    public partial class role
    {
        public role()
        {
            user_data = new HashSet<user_data>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(250)]
        public string name { get; set; }

        public virtual ICollection<user_data> user_data { get; set; }
    }
}
