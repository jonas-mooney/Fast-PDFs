namespace Fast_PDFs
{
    public class BuildPoster
    {
        public static void BuildPosterByType(string posterSelect)
        {
            if (posterSelect == "Event")
            {
                EventPoster poster = EventPosterInput.GetEventDetails();
                BuildEventPoster.Build(poster);
            }
        }
    }
}
