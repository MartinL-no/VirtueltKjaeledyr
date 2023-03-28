namespace VirtueltKjaeledyr
{
    internal class Pets
    {
        private List<Pet> _pets;
        public string[] PetNames => _pets.Select(pet => pet.Name).ToArray();

        public Pets()
        {
            _pets = new List<Pet>();
        }
        public void AddNewPet(string typeOfPet, string name, int age, string favoriteFood)
        {
            switch (typeOfPet)
            {
                case "d":
                    _pets.Add(new Dog(name, age, favoriteFood));
                    break;
                case "c":
                    _pets.Add(new Cat(name, age, favoriteFood));
                    break;
                case "r":
                    _pets.Add(new Cat(name, age, favoriteFood));
                    break;
                case "g":
                    _pets.Add(new Cat(name, age, favoriteFood));
                    break;
                default:
                    break;
            }
        }
        public bool IsValidPetName(string petName)
        {   
            return _pets.Exists(pet => pet.Name == petName);
        }

        public string FeedPet(string petName, string foodType)
        {
            var pet = _pets.FirstOrDefault(pet => pet.Name == petName);

            return pet.Feed(foodType);
        }
    }
}