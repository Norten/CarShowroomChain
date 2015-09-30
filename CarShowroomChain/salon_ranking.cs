namespace CarShowroomChain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("polsl_agatek_bd.salon_ranking")]
    public partial class salon_ranking
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(250)]
        public string name { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(250)]
        public string address { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(250)]
        public string phone { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(250)]
        public string www { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long cars { get; set; }
    }
}
