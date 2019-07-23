using System;
using System.Collections.Generic;

namespace HungryHuman
{
    class Buffet
    {
        public List<Food> Menu;
     
        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Pizza", 305, false, false),
                new Food("Cookie", 100, false, true),
                new Food("Burger", 460, false, false),
                new Food("Fried Chicken", 560, true, false),
                new Food("Cake", 369, false, true),
                new Food("Ice Cream", 396, false, false),
                new Food("Sushi", 330, true, false),
                new Food("Teriyaki Chicken",408, false, true),
            };
        }
        
        public Food Serve()
        {
            Random rand = new Random();
            int num = rand.Next(Menu.Count);
            return Menu[num];
        }
    }
}
