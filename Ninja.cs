using System;
using System.Collections.Generic;

namespace HungryHuman
{
    class Ninja
    {      
        private int calorieIntake;
        public List<Food> FoodHistory;
         
        // add a constructor
        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }
         
        // add a public "getter" property called "IsFull"
        public bool isFull 
        {
            get
            {
                if( calorieIntake >= 1200 )
                {
                    return true;
                }
                return false;
            }
        }

        public int currentCal
        {
            get { return calorieIntake; }
        }
         
        // build out the Eat method
        public void Eat(Food item)
        {
            if( isFull == false ){
                Console.WriteLine(item.Name + " - Spicy?: " + item.IsSpicy + ", Sweet?: " + item.IsSweet);
                calorieIntake += item.Calories;
                FoodHistory.Add(item);
            } else if ( isFull == true ){
                Console.WriteLine("Ninja is Full");
            }
        }
    }
}
