using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
/**Created By Gurpanth Singh 200299024
 * Sakib Patel 200307608
 * Dilpreet Singh 
 * The site depicts the structure of an ecommerce store*/
namespace final_project.Models
{
    /*Adding the sample data to the database*/
    public class SampleData : DropCreateDatabaseIfModelChanges<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            var types = new List<StoreType>
            {
                new StoreType { Name = "Cameras", Description="Something to get your Appetite up", imageUrl="/Content/Cameras.jpg"},
                new StoreType { Name = "Tablets", Description="The main Course", imageUrl="/Content/Tablets.jpg"},
                new StoreType { Name = "Samsung S7", Description="Something sweet that you have at the end.", imageUrl="/Content/Phones.jpg" },
                new StoreType { Name = "Laptops", Description="Something sweet that you have at the end.", imageUrl="/Content/Laptops.jpg" },
                new StoreType { Name = "Speakers", Description="Something sweet that you have at the end.", imageUrl="/Content/Speakers.jpg" }
            };

            new List<StoreItem>
            {
                new StoreItem {Name = "Panasonic Lumix TZ100",description="More interesting is the Panasonic Lumix TZ100, a new travel style camera with a 10x optical zoom lens and a larger than usual 1-inch sensor that should improve picture quality considerably. ", Price=8.99M, StoreType = types.Single(g => g.Name == "Cameras"), StoreLink = "/Content/Images/CameraPanasonic.png" },
                new StoreItem {Name = "Galaxy Tab S2", description="Watch your world come to life on the Super AMOLED® display. With deep contrast, rich colors and crisp details, you won’t miss a thing when you’re watching movies or playing games", Price=10.25M, StoreType = types.Single(g => g.Name == "Tablets"), StoreLink = "/Content/Images/Galaxy.jpg" },
                new StoreItem {Name = "Samsung Galaxy s7", description = "The Samsung Galaxy S7 is powered by 1.6GHz octa-core and it comes with 4GB of RAM. The phone packs 32GB of internal storage that can be expanded up to 200GB via a microSD card. ", Price=10.99M, StoreType= types.Single(g => g.Name == "Phones"), StoreLink = "/Content/Images/Tab.jpg" },
                new StoreItem {Name = "Lenovo A530 ", description ="The Lenovo A530 is a slim, space-saver that sports a widely adjustable screen, which tilts from -5° to 90° allowing use as a traditional PC or as a flat, table PC using the device’s 10-point multi-touch display for games and entertainment", Price=23.55M, StoreType= types.Single(g => g.Name == "Main Course"), StoreLink="/Content/Images/Laptop.jpg" },
                new StoreItem {Name = "Bose SoundTouch 10", description="Compact, portable, and easy to set up, the Bose SoundTouch 10 is the solution to enjoying music anywhere in your home.", Price=27.24M, StoreType= types.Single(g => g.Name == "Speakers"), StoreLink="/Content/Images/Speaker.png" },
                
            }.ForEach(a => context.StoreItems.Add(a));
        }
    }
}