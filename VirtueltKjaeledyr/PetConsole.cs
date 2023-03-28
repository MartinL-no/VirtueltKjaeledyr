namespace VirtueltKjaeledyr
{
    internal class PetConsole
    {
        public static string Ask(string prompt)
        {
            Console.WriteLine(prompt);
            var command = Console.ReadLine();

            return command;
        }
        public static (string, int, string) GetPetDetails(string petNameFirstCharachter)
        {
            var petType = petNameFirstCharachter == "d" ? "dog" : petNameFirstCharachter == "c" ? "cat" : petNameFirstCharachter == "r" ? "rabbit" : "goldfish";
            while (true)
            {
                var petDetails = Ask($"Enter your {petType}'s details (name, age, favorite food )seperated by commas (eg fido, 24, favorite food) ");

                try
                {
                    var petName = petDetails.Split(',')[0];
                    var petAge = Convert.ToInt32(petDetails.Split(',')[1]);
                    var petsFavoriteFood = petDetails.Split(',')[2];

                    return (petName, petAge, petsFavoriteFood);
                }
                catch
                {
                    ShowTemporaryMessage("Incorrect input, try again");
                }
            }
        }

        internal static void ShowTemporaryMessage(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}