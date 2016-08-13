using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
/**Created By Gurpanth Singh 200299024
 * Sakib Patel 200307608
 * Dilpreet Singh 200306382
 * The site depicts the structure of an ecommerce store*/
namespace final_project.Models
{
    public class StoreItem
    {
        public StoreItem()
        {

        }

        public StoreItem(string Name)
        {
            this.Name = Name;
        }
        [Display(Name = "Store Item")]
        public virtual int StoreItemId { get; set; }
        [Display(Name = "Store Type")]
        public virtual int StoreTypeId { get; set; }
        public virtual StoreType StoreType { get; set; }
        public virtual string Name { get; set; }
        public virtual string description { get; set; }
        public virtual decimal Price { get; set; }
        [Display(Name = "Store Art Url")]
        public virtual string StoreLink { get; set; }
    }
}