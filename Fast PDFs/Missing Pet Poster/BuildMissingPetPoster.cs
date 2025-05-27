using QuestPDF.Companion;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using Document = QuestPDF.Fluent.Document;

namespace Fast_PDFs
{
    public class BuildMissingPetPoster
    {
        public static void Build(MissingPetPoster missingPetDetails)
        {
            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(20));

                    page.Header()
                        .Text(("LOST " + missingPetDetails.TypeOfPet).ToUpper())
                        .SemiBold().FontSize(50).FontColor(Colors.Red.Medium)
                        .AlignCenter();

                    page.Content()
                        .PaddingVertical(1, Unit.Centimetre)
                        .Column(x =>
                        {
                            x.Spacing(20);

                            x.Item().Image(missingPetDetails.ImageFilePath);

                            x.Item().Text((missingPetDetails.PetName).ToUpper())
                            .SemiBold().FontSize(30).FontColor(Colors.Red.Medium)

                            .FontSize(30)
                            .AlignCenter();

                            x.Item().Text(missingPetDetails.Description)
                            .FontSize(18);


                        });

                    if (missingPetDetails.RewardAmount != "")
                    {
                        //x.Item().Text("Reward if found: " + missingPetDetails.RewardAmount);

                        page.Footer()
                            .Text($"{missingPetDetails.RewardAmount} REWARD | 555-1234")
                            .AlignCenter()
                            .FontSize(20);
                    }


                });
            })
//.GeneratePdf(eventDetails.FileName);
.ShowInCompanion();
        }
    }
}
