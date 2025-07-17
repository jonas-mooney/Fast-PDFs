using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using Document = QuestPDF.Fluent.Document;

namespace Fast_PDFs
{
    public class BuildEventPoster
    {

        public static void Build(EventPoster eventDetails, string downloadsPath)
        {
            string fileNameForDownload = eventDetails.FileName + ".pdf";
            string fullPath = Path.Combine(downloadsPath, fileNameForDownload);

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(20));

                    page.Header()
                        .Text(eventDetails.Title)
                        .SemiBold().FontSize(36).FontColor(Colors.Blue.Medium)
                        .AlignCenter();

                    page.Content()
                        .PaddingVertical(1, Unit.Centimetre)
                        .Column(x =>
                        {
                            x.Spacing(20);

                            x.Item().Image(eventDetails.ImageFile);
                            x.Item().Text("When: " + eventDetails.Time);
                            x.Item().Text("Where: " + eventDetails.Address);
                            x.Item().Text(eventDetails.Description);
                        });
                });
            })
            //.GeneratePdf(eventDetails.FileName);
            .GeneratePdf(fullPath);
            //.ShowInCompanion();
        }

    }
}
