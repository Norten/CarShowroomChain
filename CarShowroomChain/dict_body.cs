namespace CarShowroomChain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("polsl_agatek_bd.dict_body")]
    public partial class dict_body
    {
        public dict_body()
        {
            car = new HashSet<car>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(250)]
        public string body { get; set; }

        public virtual ICollection<car> car { get; set; }
    }
}
