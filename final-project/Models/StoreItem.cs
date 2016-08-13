using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

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
        [Display(Name = "Album Art Url")]
        public virtual string StoreLink { get; set; }
    }
}