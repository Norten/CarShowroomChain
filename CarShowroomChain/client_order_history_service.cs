namespace CarShowroomChain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("polsl_agatek_bd.client_order_history_service")]
    public partial class client_order_history_service
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(250)]
        public string first_name { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(250)]
        public string last_name { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(250)]
        public string address { get; set; }

        [StringLength(20)]
        public string phone { get; set; }

        [StringLength(250)]
        public string email { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "date")]
        public DateTime date_order { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(10)]
        public string cost { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal final_cost { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(250)]
        public string service { get; set; }

        [StringLength(250)]
        public string comment { get; set; }
    }
}
