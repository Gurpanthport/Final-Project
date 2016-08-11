using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace final_project.Models
{
    public class SampleData : DropCreateDatabaseAlways<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            var types = new List<StoreType>
            {
                new StoreType { Name = "Appetizer"},
                new StoreType { Name = "Main Course"},
                new StoreType { Name = "Desserts"}
            };

            new List<StoreItem>
            {
                new StoreItem {StoreName = "Televison",description="Gulab jamun, or gulaab jamun, is a milk-solids-based sweet mithai, popular in countries of South Asia, in particular in India", Price=5.99M, StoreType = types.Single(g => g.Name == "Appetizer"), FoodUrl = "/Assets/images/gulabjamun.jpg" },
                new StoreItem {StoreName = "Cameras", description="", Price=10.25M, StoreType = types.Single(g => g.Name == "Main Course"), FoodUrl = "/Assets/images/Biryani.jpg" },
                new StoreItem {StoreName = "Asus Laptop", description = "Dal makhani or dal makhni Buttery Lentil is a popular dish originating from the Punjab region of the Indian Subcontinent. The primary ingredients in dal makhani are whole black lentil with red kidney beans, butter and cream.", Price=13.99M, StoreType= types.Single(g => g.Name == "Main Course"), FoodUrl = "/Assets/images/dal_makhani.jpg" },
                new StoreItem {StoreName = "Iphone 6", description ="Naan, nan or khamiri is a leavened, oven-baked flatbread[1] found in the cuisines of West, Central and South Asia", Price=23.55M, StoreType= types.Single(g => g.Name == "Main Course"), FoodUrl="/Assets/images/naan.jpg" },
                new StoreItem {StoreName = "Printers", description="Honey chicken kabobs with veggies. You can marinate overnight and make these kabobs for an outdoor barbecue as a tasty alternative to the usual barbecue fare!", Price=27.24M, StoreType= types.Single(g => g.Name == "Main Course"), FoodUrl="/Assets/images/kebab.jpg" },
                new StoreItem {StoreName = "Monitors", description="Easy creamy and delicious chicken masala in onion tomato gravy", Price=24.21M, StoreType= types.Single(g => g.Name == "Main Course"), FoodUrl="/Assets/images/chickenbuttermasala.jpg" },
                new StoreItem {StoreName = "Tablets", description="Indian Matka kulfi with many flavours", Price=1.99M, StoreType = types.Single(g => g.Name == "Desserts"), FoodUrl= "/Assets/images/Matkakulfi.jpg" }

            }.ForEach(a => context.StoreItems.Add(a));
        }
    }
}