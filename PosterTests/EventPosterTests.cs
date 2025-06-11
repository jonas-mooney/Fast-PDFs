using Fast_PDFs;

namespace PosterTests
{
    [TestClass]
    public class EventPosterTests
    {
        [TestMethod]
        public void EventPosterBuild()
        {
            string title = "Party at Jake's";
            string description = "It's gonna be fun, bring marshmallows and graham crackers.";
            string imageFile = "./images/eventPoster.jpg";
            string fileName = "partyPoster.pdf";

            EventPoster eventPoster = new EventPoster(title, description, imageFile, fileName);

            string actualTitle = "Party at Jake's";

            Assert.AreEqual(actualTitle, eventPoster.Title, false, "The actualTitle strings did not match");
        }
    }
}
