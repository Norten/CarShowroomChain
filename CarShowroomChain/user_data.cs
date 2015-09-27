namespace CarShowroomChain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("polsl_agatek_bd.user_data")]
    public partial class user_data
    {
        public user_data()
        {
            car_sell = new HashSet<car_sell>();
            client_order = new HashSet<client_order>();
            reservation = new HashSet<reservation>();
            role = new HashSet<role>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(250)]
        public string login { get; set; }

        [Required]
        [StringLength(250)]
        public string password { get; set; }

        [Required]
        [StringLength(250)]
        public string first_name { get; set; }

        [Required]
        [StringLength(250)]
        public string last_name { get; set; }

        [Required]
        [StringLength(250)]
        public string address { get; set; }

        [StringLength(20)]
        public string phone { get; set; }

        [StringLength(250)]
        public string email { get; set; }

        public int id_car_shop { get; set; }

        public int is_active { get; set; }

        public virtual ICollection<car_sell> car_sell { get; set; }

        public virtual car_shop car_shop { get; set; }

        public virtual ICollection<client_order> client_order { get; set; }

        public virtual ICollection<reservation> reservation { get; set; }

        public virtual ICollection<role> role { get; set; }
    }
}
