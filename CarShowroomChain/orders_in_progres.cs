namespace CarShowroomChain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("polsl_agatek_bd.orders_in_progres")]
    public partial class orders_in_progres
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int order_id { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "date")]
        public DateTime date_reservation { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime date_reservation_expired { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(250)]
        public string car_model { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(250)]
        public string car_color { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(250)]
        public string car_engine { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(250)]
        public string car_gearbox { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(250)]
        public string car_fuel { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(250)]
        public string car_body { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(10)]
        public string car_cost { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(250)]
        public string shop_address_with_car { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(250)]
        public string client_first_name { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(250)]
        public string client_last_name { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(250)]
        public string client_address { get; set; }

        [StringLength(20)]
        public string client_phone { get; set; }

        [StringLength(250)]
        public string client_email { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(250)]
        public string user_first_name { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(250)]
        public string user_last_name { get; set; }

        [StringLength(20)]
        public string user_phone { get; set; }

        [StringLength(250)]
        public string user_email { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(250)]
        public string shop_address_with_seller { get; set; }

        [Key]
        [Column(Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int user_is_active { get; set; }
    }
}
