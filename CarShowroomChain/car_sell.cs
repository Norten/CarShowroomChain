namespace CarShowroomChain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("polsl_agatek_bd.car_sell")]
    public partial class car_sell
    {
        public int id { get; set; }

        [Column(TypeName = "date")]
        public DateTime sell_date { get; set; }

        public decimal cost { get; set; }

        public int id_car { get; set; }

        public int id_client { get; set; }

        public int id_user { get; set; }

        public virtual car car { get; set; }

        public virtual client client { get; set; }

        public virtual user_data user_data { get; set; }
    }
}
