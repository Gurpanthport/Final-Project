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
            var types = new List<CategoryType>
            {
                new CategoryType { Name = "Appetizer"},
                new CategoryType { Name = "Main Course"},
                new CategoryType { Name = "Desserts"}
            };

            new List<Items>
            {
                new Items {ProductName = "Gulab Jamun",description="Gulab jamun, or gulaab jamun, is a milk-solids-based sweet mithai, popular in countries of South Asia, in particular in India", Price=5.99M, ProductType = types.Single(g => g.Name == "Appetizer")},
                new Items {ProductName = "Chicken Biryani", description="", Price=10.25M, ProductType = types.Single(g => g.Name == "Main Course") },
                new Items {ProductName = "Dal Makhani", description = "Dal makhani or dal makhni Buttery Lentil is a popular dish originating from the Punjab region of the Indian Subcontinent. The primary ingredients in dal makhani are whole black lentil with red kidney beans, butter and cream.", Price=13.99M, ProductType= types.Single(g => g.Name == "Main Course")},
                new Items {ProductName = "Naan Bread", description ="Naan, nan or khamiri is a leavened, oven-baked flatbread[1] found in the cuisines of West, Central and South Asia", Price=23.55M, ProductType= types.Single(g => g.Name == "Main Course"), FoodUrl="/Assets/images/naan.jpg" },
                new Items {ProductName = "Chicken Kebab", description="Honey chicken kabobs with veggies. You can marinate overnight and make these kabobs for an outdoor barbecue as a tasty alternative to the usual barbecue fare!", Price=27.24M, ProductType= types.Single(g => g.Name == "Main Course") },
                new Items {ProductName = "Chicken Butter Masala", description="Easy creamy and delicious chicken masala in onion tomato gravy", Price=24.21M, ProductType= types.Single(g => g.Name == "Main Course")},
                new Items {ProductName = "Kulfi", description="Indian Matka kulfi with many flavours", Price=1.99M, ProductType = types.Single(g => g.Name == "Desserts")}

            }.ForEach(a => context.ProductItems.Add(a));
        }
    }
}