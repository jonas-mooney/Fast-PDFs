using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_PDFs
{
    public class MissingPetPoster
    {
        public string TypeOfPet { get; set; }
        public string PetName { get; set; }
        public string ImageFilePath { get; set; }
        public string Description { get; set; }
        public string RewardIfFound { get; set; }
        public string RewardAmount { get; set; }

        public MissingPetPoster(string typeOfPet, string petName, string imageFilePath, string description, string rewardIfFound, string rewardAmount)
        {
            TypeOfPet = typeOfPet;
            PetName = petName;
            ImageFilePath = imageFilePath;
            Description = description;
            RewardIfFound = rewardIfFound;
            RewardAmount = rewardAmount;
        }
    }
}

// Add phone number