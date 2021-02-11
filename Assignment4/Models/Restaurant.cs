using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    public class Restaurant
    {
        public Restaurant (int rank)
        {
            RestRank = rank;
        }

        public int RestRank { get; }
        public string RestName { get; set; }
        public string? FavDish { get; set; } = "It's all tasty!";
        public string RestAddy { get; set; }
        public string? RestPhone { get; set; }
        public string? WebLink { get; set; } = "Coming soon.";

        

        public static Restaurant[] GetRestaurants()
        {
            Restaurant r1 = new Restaurant(1)
            {
                RestName = "McDonalds",
                FavDish = "Spicy McChicken",
                RestAddy = "Cougar BLVD",
                RestPhone = "(123)-456-7890",
                WebLink = "https://mcdonalds.com/"
            };

            Restaurant r2 = new Restaurant(2)
            {
                RestName = "Chick-Fil-A",
                FavDish = "Spicy Chicken Sandwich",
                RestAddy = "Cougar BLVD",
                RestPhone = "(123)-456-7890",
                WebLink = "https://www.chick-fil-a.com/"
            };

            Restaurant r3 = new Restaurant(3)
            {
                RestName = "Taco Bell",
                FavDish = "Nacho Fries",
                RestAddy = "Cougar BLVD",
                RestPhone = "(123)-456-7890",
                WebLink = "https://www.tacobell.com/"
            };

            Restaurant r4 = new Restaurant(4)
            {
                RestName = "Don Joaquin",
                FavDish = "Tacos",
                RestAddy = "Cougar BLVD",
                RestPhone = "(123)-456-7890",
                WebLink = "https://stdonjoaquin.com/"
            };

            Restaurant r5 = new Restaurant(5)
            {
                RestName = "Little Ceasars",
                FavDish = "Pepperoni Pizza",
                RestAddy = "Cougar BLVD",
                RestPhone = "(123)-456-7890",
                WebLink = "https://littlecaesars.com/"
            };

            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }

    }
}
