using System;

namespace nombre_magique
{
    class Program
    {

        // Demander Nombre
        // afficher : rentrez un nombre
        // tester si ce nombre est valide --> erreur : ce nombre n'est pas valide
        // reboucler tant que le nombre n'est pas valide
        // considerer que 0 est invalide
        // retourner la valeur (int)

        static int AskNumber(int NUMBER_MIN, int NUMBER_MAX)
        {

            int selectedNumber = NUMBER_MIN - 1;

            // IF selectedNumber is smaller then 1 or bigger then 10 try again
            while (selectedNumber < NUMBER_MIN || selectedNumber > NUMBER_MAX)
            {
                try
                {
                    Console.WriteLine("_____________________________________________");
                    Console.WriteLine("");
                    Console.WriteLine();
                    Console.Write("Please select a number beetween " + NUMBER_MIN + " and " + NUMBER_MAX + " : ");

                    string selectedNum = Console.ReadLine();
                    selectedNum = selectedNum.Trim();
                    selectedNumber = int.Parse(selectedNum);

                }
                catch
                {
                    Console.WriteLine("\n Please enter a number !");
                }
            }

            return selectedNumber;

        }

        static void Main(string[] args)
        {
            const int NUMBER_MIN = 1;
            const int NUMBER_MAX = 10;

            int Number_Life = 4;

            // GET A RANDOM NUMBER 
            Random rand = new Random();
            int MAGIC_NUMBER = rand.Next(NUMBER_MIN, NUMBER_MAX + 1);

            int selNumber = 0;

            while (Number_Life > 0)
            {
                Console.WriteLine("IL vous reste " + Number_Life + " de vie.");
                selNumber = AskNumber(NUMBER_MIN, NUMBER_MAX);

                if (selNumber < MAGIC_NUMBER)
                {
                    Console.WriteLine("Le nombre magique est plus GRAND");
                }
                else if (selNumber > MAGIC_NUMBER)
                {
                    Console.WriteLine("Le nombre magique est plus PETIT");
                }
                else
                {
                    Console.WriteLine("Bravo vous avez trouvez le nombre magique !!!");
                    break;
                }

                Number_Life = Number_Life - 1;

            }

            if (Number_Life == 0)
            {
                Console.WriteLine("\n Vous avez perdu ! Le nombre magique etait le " + MAGIC_NUMBER);
            }
        }
    }
}
