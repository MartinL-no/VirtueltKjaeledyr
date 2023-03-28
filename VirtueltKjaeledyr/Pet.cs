namespace VirtueltKjaeledyr
{
    internal class Pet
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        private string _favoriteFood;

        public Pet(string name, int age, string favoriteFood)
        {
            Name = name;
            Age = age;
            _favoriteFood = favoriteFood;
        }
        public string Feed(string foodType)
        {
            if (foodType == _favoriteFood) return "Hooray this is the best thing I know, thank you very much for the food!";

            else return "Thank you for the food";
        }
    }
}