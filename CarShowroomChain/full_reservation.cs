namespace CarShowroomChain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("polsl_agatek_bd.full_reservation")]
    public partial class full_reservation
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "date")]
        public DateTime date_reservation { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime date_reservation_expired { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(250)]
        public string first_name { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(250)]
        public string last_name { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(250)]
        public string model { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(250)]
        public string series { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(250)]
        public string color { get; set; }
    }
}
