namespace CarShowroomChain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("polsl_agatek_bd.dict_fuel")]
    public partial class dict_fuel
    {
        public dict_fuel()
        {
            car = new HashSet<car>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required]
        [StringLength(250)]
        public string fuel { get; set; }

        public virtual ICollection<car> car { get; set; }
    }
}
