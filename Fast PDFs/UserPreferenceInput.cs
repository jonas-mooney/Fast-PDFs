using System;

public class UserPreferenceInput
{
	public static UserPreference GetUserPreferenceFromConsole()
	{
        Console.WriteLine("Welcome to Fast PDF! \n Please enter the name of your file (including a trailing .pdf):");
        string chosenFileName = Console.ReadLine();

        Console.WriteLine("Please enter the header text for your poster:");
        string headerText = Console.ReadLine();

        Console.WriteLine("Please enter the text content for your main information:");
        string contentText = Console.ReadLine();

        Console.WriteLine("Please drag and drop an image file for your poster:");
        string imageFilePath = Console.ReadLine();

        Console.WriteLine("Your pdf has been saved to the Downloads folder!");

        return new UserPreference(chosenFileName, headerText, contentText, imageFilePath);
    }
}
