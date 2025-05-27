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
                        .Text(missingPetDetails.TypeOfPet)
                        .SemiBold().FontSize(36).FontColor(Colors.Blue.Medium);

                    page.Content()
                        .PaddingVertical(1, Unit.Centimetre)
                        .Column(x =>
                        {
                            x.Spacing(20);

                            x.Item().Text(missingPetDetails.Description);
                            x.Item().Text(missingPetDetails.PetName);                            x.Item().Text(missingPetDetails.RewardIfFound);
                            if (missingPetDetails.RewardAmount != "")
                            {
                                x.Item().Text(missingPetDetails.RewardAmount);
                            }
                            x.Item().Image(missingPetDetails.ImageFilePath);
                        });
                });
            })
//.GeneratePdf(eventDetails.FileName);
.ShowInCompanion();
        }
    }
}
