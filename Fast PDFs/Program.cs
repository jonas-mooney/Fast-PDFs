using System.Diagnostics;
using System.Reflection.Metadata;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using Document = QuestPDF.Fluent.Document;

QuestPDF.Settings.License = LicenseType.Community;


Console.WriteLine("Welcome to Fast PDF! \n Please enter the name of your file:");
string chosenFileName = Console.ReadLine();
Console.WriteLine("Please enter the header text for your poster:");
string headerText = Console.ReadLine();
Console.WriteLine("Please enter the text content for your main information:");
string contentText = Console.ReadLine();


var fileName = "hello.pdf";

Document.Create(container =>
{
    container.Page(page =>
    {
        page.Size(PageSizes.A4);
        page.Margin(2, Unit.Centimetre);
        page.PageColor(Colors.White);
        page.DefaultTextStyle(x => x.FontSize(20));

        page.Header()
            .Text(headerText)
            .SemiBold().FontSize(36).FontColor(Colors.Blue.Medium);

        page.Content()
            .PaddingVertical(1, Unit.Centimetre)
            .Column(x =>
            {
                x.Spacing(20);

                x.Item().Text(contentText);
                x.Item().Image(Placeholders.Image(200, 100));
            });

        page.Footer()
            .AlignCenter()
            .Text(x =>
            {
                x.Span("Page ");
                x.CurrentPageNumber();
            });
    });
})
.GeneratePdf($"{chosenFileName}.pdf");

//.GeneratePdf($"Users/jonas_gcsfmp0/Downloads/{chosenFileName}.pdf");
// https://github.com/QuestPDF/QuestPDF/discussions/1004

var p = new Process();
p.StartInfo = new ProcessStartInfo(Path.Combine(Directory.GetCurrentDirectory(), $"{chosenFileName}.pdf"))
{
    UseShellExecute = true
};
p.Start();