namespace CarShowroomChain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("polsl_agatek_bd.dict_series")]
    public partial class dict_series
    {
        public dict_series()
        {
            car = new HashSet<car>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(250)]
        public string series { get; set; }

        public virtual ICollection<car> car { get; set; }
    }
}
