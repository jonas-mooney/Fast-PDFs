﻿namespace Fast_PDFs
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
            else if (posterSelect == "Missing Pet")
            {
                MissingPetPoster poster = MissingPetPosterInput.GetMissingPetDetails();
                BuildMissingPetPoster.Build(poster);
            }
            else if (posterSelect == "Job Post")
            {
                JobPoster poster = JobPosterInput.GetJobPosterInput();
                BuildJobPoster.Build(poster);
            }
        }
    }
}
