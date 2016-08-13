using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace final_project.Models
{/**Created By Gurpanth Singh 200299024
 * Sakib Patel 200307608
 * Dilpreet Singh 
 * The site depicts the structure of an ecommerce store*/
    public class StoreType
    {
        public StoreType()
        {

        }

        public StoreType(string Name)
        {
            this.Name = Name;
        }

        public virtual int StoreTypeId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual string imageUrl { get; set; }
        public virtual List<StoreItem> StoreItems { get; set; }
    }
}