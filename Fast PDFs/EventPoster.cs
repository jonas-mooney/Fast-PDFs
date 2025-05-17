namespace Fast_PDFs
{
    public class EventPoster
    {
        string Title { get; set; }
        string Description { get; set; }
        string ImageFile { get; set; }
        string FileName { get; set; }

        public EventPoster(string title, string description, string imageFile, string fileName)
        {
            Title = title;
            Description = description;
            ImageFile = imageFile;
            FileName = fileName;
        }
    }
}
