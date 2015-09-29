namespace CarShowroomChain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("polsl_agatek_bd.car")]
    public partial class car
    {
        public car()
        {
            car_sell = new HashSet<car_sell>();
            reservation = new HashSet<reservation>();
        }

        public int id { get; set; }

        public int id_model { get; set; }

        public int id_series { get; set; }

        public int id_color { get; set; }

        public int id_engine { get; set; }

        public int id_gearbox { get; set; }

        public int id_fuel { get; set; }

        public int id_body { get; set; }

        [Required]
        [StringLength(10)]
        public string cost { get; set; }

        public int id_car_shop { get; set; }

        public virtual car_shop car_shop { get; set; }

        public virtual model model { get; set; }

        public virtual dict_series dict_series { get; set; }

        public virtual dict_color dict_color { get; set; }

        public virtual dict_engine dict_engine { get; set; }

        public virtual dict_gearbox dict_gearbox { get; set; }

        public virtual dict_fuel dict_fuel { get; set; }

        public virtual dict_body dict_body { get; set; }

        public virtual ICollection<car_sell> car_sell { get; set; }

        public virtual ICollection<reservation> reservation { get; set; }
    }
}
