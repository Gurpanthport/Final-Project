namespace final_project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Store")]
    public partial class Store
    {
        public virtual int storeId { get; set; }

        [Required]
        public virtual string productName { get; set; }

        [Required]
        public virtual string ShortDescription { get; set; }

        [Required]
        public virtual string LongDescription { get; set; }

        public virtual int Price { get; set; }

        [Required]
        [StringLength(50)]
        public virtual string ThumbImage { get; set; }

        [Required]
        [StringLength(50)]
        public virtual string LargeImage { get; set; }
    }


}

