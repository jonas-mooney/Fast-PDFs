namespace Fast_PDFs
{
    public class BuildPoster
    {
        public BuildPoster(string posterSelect)
        {
            if (posterSelect == "Event")
            {
                EventPoster poster = EventPosterInput.GetEventDetails();
            }
        }
    }
}
