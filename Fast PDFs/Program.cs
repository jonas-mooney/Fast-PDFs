using Fast_PDFs;
using QuestPDF.Infrastructure;

QuestPDF.Settings.License = LicenseType.Community;

string downloadsPath = Path.Combine(
    Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
    "Downloads"
);

//MissingPetPoster testPoster = new MissingPetPoster("Dog", "Roofus", "C:\\Users\\jonas_gcsfmp0\\Downloads\\pexels-katlovessteve-551628.jpg", "Brown, fluffy dog. Roofus has been lost for 2 weeks. He has a small black collar with a bell. He loves bacon and is probably very thirsty. Please call us at 555-1234", "Yes", "$800");
MissingPetPoster testPetPoster = new MissingPetPoster("Dog", "Roofus", "C:\\Users\\jonas\\Downloads\\pexels-katlovessteve-551628.jpg", "Brown, fluffy dog. Roofus has been lost for 2 weeks. He has a small black collar with a bell. He loves bacon and is probably very thirsty. Please call us at 555-1234", "Yes", "$800");
BuildMissingPetPoster.Build(testPetPoster);

EventPoster testEventPoster = new EventPoster("Party at Jake's", "It's gonna be fun. Chips and dip provided.", "C:\\Users\\jonas\\Downloads\\pexels-katlovessteve-551628.jpg", "party.pdf");
BuildEventPoster.Build(testEventPoster);

JobPoster testJobPoster = new JobPoster("The Company, LLC", "Software Engineer", "")

//string posterSelect = PosterSelect.UserPosterSelection();

//BuildPoster.BuildPosterByType(posterSelect);







// The above is valid
///////////////////////////////////////





//UserPreference preference = UserPreferenceInput.GetUserPreferenceFromConsole();

//string filePath = Path.Combine(downloadsPath, preference.ChosenFileName);

//Document.Create(container =>
//{
//    container.Page(page =>
//    {
//        page.Size(PageSizes.A4);
//        page.Margin(2, Unit.Centimetre);
//        page.PageColor(Colors.White);
//        page.DefaultTextStyle(x => x.FontSize(20));

//        page.Header()
//            .Text(preference.HeaderText)
//            .SemiBold().FontSize(36).FontColor(Colors.Blue.Medium);

//        page.Content()
//            .PaddingVertical(1, Unit.Centimetre)
//            .Column(x =>
//            {
//                x.Spacing(20);

//                x.Item().Text(preference.ContentText);
//                x.Item().Image(preference.ImageFilePath);
//            });
//    });
//})
//.GeneratePdf(filePath);



/*

Class for poster type select
Classes for each type of poster



 */