using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace final_project.Models
{
    public class StoreType
    {
        public StoreType()
        {

        }

        public StoreType(string Name)
        {
            this.Name = Name;
        }

        public virtual int StoreTypelsId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual string imageUrl { get; set; }
        public virtual List<StoreItem> StoreItems { get; set; }
    }
}