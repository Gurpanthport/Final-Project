using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
        public virtual string Name { get; set; }
        public virtual int StoreTypeId { get; set; }
        public virtual List<StoreItem> StoreItems { get; set; }

    }
}