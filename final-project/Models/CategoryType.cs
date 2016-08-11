using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace final_project.Models
{
    public class CategoryType
    {
        public CategoryType()
        {

        }

        public CategoryType(string Name)
        {
            this.Name = Name;
        }
        public virtual string Name { get; set; }
        public virtual int CategoryTypeId { get; set; }
        public virtual List<Items> CategoryItem { get; set; }

    }
}