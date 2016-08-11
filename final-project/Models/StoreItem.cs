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

        public StoreItem(string StoreName)
        {
            this.StoreName = StoreName;
        }
        [Display(Name = "Product Item")]
        public virtual int StoreItemId { get; set; }
        public virtual int StoreTypeId { get; set; }
        public virtual StoreType StoreType { get; set; }
        [Display(Name = "Product Type")]
        public virtual string StoreName { get; set; }
        public virtual string description { get; set; }
        public virtual decimal Price { get; set; }
        [Display(Name = "Food Url")]
        public virtual string FoodUrl { get; set; }

    }
}