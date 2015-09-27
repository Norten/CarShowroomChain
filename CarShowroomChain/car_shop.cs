namespace CarShowroomChain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("polsl_agatek_bd.car_shop")]
    public partial class car_shop
    {
        public car_shop()
        {
            car = new HashSet<car>();
            client_order = new HashSet<client_order>();
            user_data = new HashSet<user_data>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(250)]
        public string name { get; set; }

        [Required]
        [StringLength(250)]
        public string address { get; set; }

        [Required]
        [StringLength(250)]
        public string phone { get; set; }

        [Required]
        [StringLength(250)]
        public string www { get; set; }

        public virtual ICollection<car> car { get; set; }

        public virtual ICollection<client_order> client_order { get; set; }

        public virtual ICollection<user_data> user_data { get; set; }
    }
}
