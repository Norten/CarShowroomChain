namespace CarShowroomChain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("polsl_agatek_bd.client_order")]
    public partial class client_order
    {
        public int id { get; set; }

        [Required]
        [StringLength(250)]
        public string comment { get; set; }

        public decimal cost { get; set; }

        public int is_done { get; set; }

        public int id_car_shop { get; set; }

        public int id_client { get; set; }

        public int id_user { get; set; }

        public int id_service { get; set; }

        [Column(TypeName = "date")]
        public DateTime date_order { get; set; }

        [Column(TypeName = "date")]
        public DateTime date_done { get; set; }

        public virtual car_shop car_shop { get; set; }

        public virtual client client { get; set; }

        public virtual user_data user_data { get; set; }

        public virtual dict_service dict_service { get; set; }
    }
}
