using QuestPDF.Companion;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using Document = QuestPDF.Fluent.Document;

namespace Fast_PDFs
{
    public class BuildJobPoster
    {

        public static void Build(JobPoster jobDetails)
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
                        .Text(jobDetails.CompanyName)
                        .SemiBold().FontSize(36).FontColor(Colors.Blue.Medium);

                    page.Content()
                        .PaddingVertical(1, Unit.Centimetre)
                        .Column(x =>
                        {
                            x.Spacing(20);

                            x.Item().Text(jobDetails.JobDescription);
                            x.Item().Text(jobDetails.Compensation.Type);
                            //x.Item().Image(jobDetails.Compensation);
                        });
                });
            })
//.GeneratePdf(eventDetails.FileName);
.ShowInCompanion();
        }

    }
}
