namespace CarShowroomChain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("polsl_agatek_bd.dict_service")]
    public partial class dict_service
    {
        public dict_service()
        {
            client_order = new HashSet<client_order>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required]
        [StringLength(250)]
        public string name { get; set; }

        public string cost { get; set; }

        public virtual ICollection<client_order> client_order { get; set; }
    }
}
