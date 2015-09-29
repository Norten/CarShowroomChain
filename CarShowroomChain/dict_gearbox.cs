namespace CarShowroomChain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("polsl_agatek_bd.dict_gearbox")]
    public partial class dict_gearbox
    {
        public dict_gearbox()
        {
            car = new HashSet<car>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(250)]
        public string gearbox { get; set; }

        public virtual ICollection<car> car { get; set; }
    }
}
