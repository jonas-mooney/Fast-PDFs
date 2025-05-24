using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;

namespace Fast_PDFs.Missing_Pet_Poster
{
    public class MissingPetPosterInput
    {
        public static MissingPetPoster GetMissingPetDetails()
        {
            Console.WriteLine("What type of animal is your pet?");
            string typeOfPet = Console.ReadLine();

            Console.WriteLine("What is your pet's name?");
            string petName = Console.ReadLine();

            Console.WriteLine($"Please drag and drop an image of {petName}:");
            string imageFilePath = Console.ReadLine();

            Console.WriteLine($"Please describe details about {petName}, their appearance and characteristics:");
            string description = Console.ReadLine();

            var rewardIfFound = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title($"Would you like to offer a reward if {petName} is found?")
                .PageSize(10)
                .AddChoices(new[] {
                                "Yes", "No",
                }));

            string rewardAmount;
            if (rewardIfFound == "Yes")
            {
                Console.WriteLine("What amount in dollars will be rewarded?");
                rewardAmount = Console.ReadLine();
            } else
            {
                rewardAmount = "";
            }

            return new MissingPetPoster(typeOfPet, petName, imageFilePath, description, rewardIfFound, rewardAmount);
        }
    }
}
