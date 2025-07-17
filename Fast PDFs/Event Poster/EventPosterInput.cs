using System.Text.RegularExpressions;

namespace Fast_PDFs
{
    public class EventPosterInput
    {
        public static EventPoster GetEventDetails()
        {
            string title = CheckValidInput.Checkinput("Please enter the event title:");

            string invalidChars = new string(Path.GetInvalidFileNameChars());
            string pattern = $"[{Regex.Escape(invalidChars)}]";
            string titleSanitizedFileName = Regex.Replace(title, pattern, "");

            string description = CheckValidInput.Checkinput("Please enter the event description:");

            string address = CheckValidInput.Checkinput("Please enter the address of the event:");

            string time = CheckValidInput.Checkinput("Please enter the time of the event:");

            string imageFilePath = CheckValidInput.Checkinput("Please drag and drop an image file for your poster:");

            return new EventPoster(title, description, address, time, imageFilePath, titleSanitizedFileName);
        }
    }
}