using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace final_project.Models
{
    public class Items
    {
        public Items()
        {

        }

        public Items(string ProductName)
        {
            this.ProductName = ProductName;
        }
        [Display(Name = "Product Item")]
        public virtual int ProductItemId { get; set; }
        public virtual int ProductTypeId { get; set; }
        public virtual CategoryType ProductType { get; set; }
        [Display(Name = "Product Type")]
        public virtual string ProductName { get; set; }
        public virtual string description { get; set; }
        public virtual decimal Price { get; set; }
        [Display(Name = "Food Url")]
        public virtual string FoodUrl { get; set; }

    }
}