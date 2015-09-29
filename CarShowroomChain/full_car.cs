namespace CarShowroomChain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("polsl_agatek_bd.full_car")]
    public partial class full_car
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(250)]
        public string model { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(250)]
        public string series { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(250)]
        public string color { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(250)]
        public string engine { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(250)]
        public string gearbox { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(250)]
        public string fuel { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(250)]
        public string body { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(10)]
        public string cost { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(250)]
        public string name { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }
    }
}
