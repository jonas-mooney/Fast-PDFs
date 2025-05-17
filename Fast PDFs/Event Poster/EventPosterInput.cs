namespace Fast_PDFs
{
    public class EventPosterInput
    {
        public static EventPoster GetEventDetails()
        {
            Console.WriteLine("Please enter the header text for your poster:");
            string title = Console.ReadLine();

            Console.WriteLine("Please enter the text content for your main information:");
            string description = Console.ReadLine();

            Console.WriteLine("Please drag and drop an image file for your poster:");
            string imageFilePath = Console.ReadLine();

            Console.WriteLine("Welcome to Fast PDF! \n Please enter the name of your file (including a trailing .pdf):");
            string chosenFileName = Console.ReadLine();

            return new EventPoster(title, description, imageFilePath, chosenFileName);
        }
    }
}
