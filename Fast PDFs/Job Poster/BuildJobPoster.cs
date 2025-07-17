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

                            x.Item().Text(jobDetails.JobTitle + " | " + jobDetails.FullOrPartTime);
                            x.Item().Text(jobDetails.Compensation.Type + ": " + jobDetails.Compensation.Amount);
                            x.Item().Text(jobDetails.JobDescription).FontSize(16);
                            x.Item().Text("Qualifications:");
                            foreach (var i in jobDetails.Qualifications)
                            {
                                x.Item().Row(row =>
                                {
                                    //row.ConstantItem(26).Image("Resources/bulletpoint.png");
                                    row.ConstantItem(20);
                                    row.RelativeItem().Text(i).FontSize(16).LineHeight(.50f);
                                });
                            }
                            x.Item().Text("Job Requirements:");
                            foreach (var i in jobDetails.JobRequirements)
                            {
                                x.Item().Row(row =>
                                {
                                    //row.ConstantItem(26).Image("Resources/bulletpoint.png");
                                    row.ConstantItem(20);
                                    row.RelativeItem().Text(i).FontSize(16).LineHeight(.50f);
                                });
                            }
                            x.Item().Text("Contact us").Underline();
                            x.Item().Text(jobDetails.ContactPhone).FontSize(16).LineHeight(.50f);
                            x.Item().Text(jobDetails.ContactEmail).FontSize(16).LineHeight(.50f);
                            x.Item().Text(jobDetails.ContactEmail).FontSize(16).LineHeight(.50f);
                        });
                });
            })
            //.GeneratePdf(jobDetails.san);
            .ShowInCompanion();
        }

    }
}
