namespace HungryHuman
{
    class Food
    {
        public string Name;
        public int Calories;
        // Foods can be Spicy and/or Sweet
        public bool IsSpicy; 
        public bool IsSweet;
        public string PrintInfo()
        {
            return $"Food: {Name}, Calories: {Calories}, Spicy?: {IsSpicy}, Sweet?: {IsSweet}";
        } 
        // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet
        public Food(string name, int calories, bool isSpicy, bool isSweet)
        {
            Name = name;
            Calories = calories;
            IsSpicy = isSpicy;
            IsSweet = isSweet;
        }
    }
}
