namespace VirtueltKjaeledyr
{
    internal class Menu
    {
        private Pets _pets;

        public Menu(Pets pets)
        {
            _pets = pets;
        }
        public void Run()
        {
            while (true)
            {
                var menuChoice = PetConsole.Ask(
                                "What would you like to do:\n" +
                                "1. add new Pet:\n" +
                                "2. see all Pets:\n" +
                                "3. feed Pet:\n" +
                                "x: close program"
                            );
                Console.Clear();
                if (menuChoice == "1")
                {
                    AddPetsMenu();
                }
                else if (menuChoice == "2")
                {
                    ShowPets();
                }
                else if (menuChoice == "3")
                {
                    FeedPetMenu();
                }
                else if (menuChoice == "x")
                {
                    break;
                }
                else
                {
                    PetConsole.ShowTemporaryMessage("Incorrect entry, please try again");
                }
            }
        }
        private void AddPetsMenu()
        {
            var petType = GetPetType();

            var (petName, petAge, petsFavoriteFood) = PetConsole.GetPetDetails(petType);

            _pets.AddNewPet(petType, petName, petAge, petsFavoriteFood);

            PetConsole.ShowTemporaryMessage($"You have added {petName} to your pets");
            
        }
        private string GetPetType()
        {
            while (true)
            {
                var petType = PetConsole.Ask("Select the pet you would like (d: dog, c: cat, r: rabbit, g: goldfish): ");
                Console.Clear();

                if (IsValidPetType(petType)) return petType;

                else PetConsole.ShowTemporaryMessage("Incorrect entry, please try again");
            }
        }
        private bool IsValidPetType(string petType)
        {
            if (petType == "d" || petType == "c" || petType == "r" || petType == "g")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void ShowPets()
        {
            if (_pets.PetNames.Length == 0)
            {
                PetConsole.ShowTemporaryMessage("You have no pets");
            }
            else
            {
                Console.WriteLine("Your Pets are:");
                foreach (var petName in _pets.PetNames)
                {
                    Console.WriteLine(petName);
                }
                Thread.Sleep(2000);
                Console.Clear();
            }
        }
        private void FeedPetMenu()
        {
            while (true)
            {
                var petName = PetConsole.Ask("Which pet which you like to feed: ");
                Console.Clear();

                if (_pets.IsValidPetName(petName))
                {
                    var food = PetConsole.Ask("Which type of food would you like to feed it?");
                    var petResponse =_pets.FeedPet(petName, food);

                    PetConsole.ShowTemporaryMessage(petResponse);
                    break;
                }
                else
                {
                    PetConsole.ShowTemporaryMessage("Invalid input, please try again");
                }
            }
        }
    }
}