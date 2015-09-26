namespace CarShowroomChain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("polsl_agatek_bd.client")]
    public partial class client
    {
        public client()
        {
            car_sell = new HashSet<car_sell>();
            client_order = new HashSet<client_order>();
            reservation = new HashSet<reservation>();
        }

        public int id { get; set; }

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

        public virtual ICollection<car_sell> car_sell { get; set; }

        public virtual ICollection<client_order> client_order { get; set; }

        public virtual ICollection<reservation> reservation { get; set; }
    }
}
