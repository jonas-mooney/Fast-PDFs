using System.Text.RegularExpressions;

namespace Fast_PDFs
{
    public class EventPosterInput
    {
        public static EventPoster GetEventDetails()
        {
            Console.WriteLine("Please enter the event title:");
            string title = Console.ReadLine();
            string invalidChars = new string(Path.GetInvalidFileNameChars());
            string pattern = $"[{Regex.Escape(invalidChars)}]";
            string titleSanitizedFileName = Regex.Replace(title, pattern, "");

            Console.WriteLine("Please enter the event description:");
            string description = Console.ReadLine();

            Console.WriteLine("Please drag and drop an image file for your poster:");
            string imageFilePath = Console.ReadLine();

            //Console.WriteLine("Please enter the name for your pdf to be saved as (including a trailing .pdf):");
            //string chosenFileName = Console.ReadLine();

            return new EventPoster(title, description, imageFilePath, titleSanitizedFileName);
        }
    }
}


// Loop until valid
// Helper method
// Optional parameters