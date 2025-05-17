namespace Fast_PDFs
{
    public class EventPoster
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageFile { get; set; }
        public string FileName { get; set; }

        public EventPoster(string title, string description, string imageFile, string fileName)
        {
            Title = title;
            Description = description;
            ImageFile = imageFile;
            FileName = fileName;
        }
    }
}
