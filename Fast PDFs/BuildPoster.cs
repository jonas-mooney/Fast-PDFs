namespace Fast_PDFs
{
    public class BuildPoster
    {
        public BuildPoster(string posterSelect)
        {
            if (posterSelect == "Event")
            {
                EventPosterInput.GetEventDetails();
            }
        }
    }
}
