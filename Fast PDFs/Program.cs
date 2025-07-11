using Fast_PDFs;
using QuestPDF.Infrastructure;

QuestPDF.Settings.License = LicenseType.Community;

string downloadsPath = Path.Combine(
    Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
    "Downloads"
);

MissingPetPoster testPoster = new MissingPetPoster("Dog", "Roofus", "C:\\Users\\jonas_gcsfmp0\\Downloads\\pexels-katlovessteve-551628.jpg", "Brown, fluffy dog. Roofus has been lost for 2 weeks. He has a small black collar with a bell. He loves bacon and is probably very thirsty. Please call us at 555-1234", "Yes", "$800");
//MissingPetPoster testPetPoster = new MissingPetPoster("Dog", "Roofus", "C:\\Users\\jonas\\Downloads\\pexels-katlovessteve-551628.jpg", "Brown, fluffy dog. Roofus has been lost for 2 weeks. He has a small black collar with a bell. He loves bacon and is probably very thirsty. Please call us at 555-1234", "Yes", "$800");
//BuildMissingPetPoster.Build(testPoster);

EventPoster testEventPoster = new EventPoster("Party at Jake's", "It's gonna be fun. Chips and dip provided.", "C:\\Users\\jonas_gcsfmp0\\Downloads\\pexels-katlovessteve-551628.jpg", "party.pdf");
//EventPoster testEventPoster = new EventPoster("Party at Jake's", "It's gonna be fun. Chips and dip provided.", "C:\\Users\\jonas\\Downloads\\pexels-katlovessteve-551628.jpg", "party.pdf");
//BuildEventPoster.Build(testEventPoster);

Compensation testCompensation = new Compensation("Salary", "90,000");
JobPoster testJobPoster = new JobPoster("The Company, LLC", "Software Engineer", "Take the lead of projects to improve and optimize The Company's APIs", testCompensation, "Full time", ["Self starter", "5 years experience in Java and C#"], ["Remote position, 9-5", "Daily team standups"], "801-555-5555", "teamlead@thecompanyllc.com", "thecompany.com");
//BuildJobPoster.Build(testJobPoster);

string posterSelect = PosterSelect.UserPosterSelection();

BuildPoster.BuildPosterByType(posterSelect);



// UP NEXT
// 1) Data sanitization and null checks in input classes.
// 2) Create checks to ensure something was entered in each required field.
// 3) Finalize pdf designs of each.
// 4) Build binaries and post on website / github with README!