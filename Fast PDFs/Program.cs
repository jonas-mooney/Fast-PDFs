using System.Diagnostics;
using System.Reflection.Metadata;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using Document = QuestPDF.Fluent.Document;

QuestPDF.Settings.License = LicenseType.Community;


Console.WriteLine("Welcome to Fast PDF! \n Please enter the name of your file (including a trailing .pdf):");
string chosenFileName = Console.ReadLine();
Console.WriteLine("Please enter the header text for your poster:");
string headerText = Console.ReadLine();
Console.WriteLine("Please enter the text content for your main information:");
string contentText = Console.ReadLine();
Console.WriteLine("Please drag and drop an image file for your poster:");
string imageFilePath = Console.ReadLine();
Console.WriteLine("Your pdf has been saved to the Downloads folder!");


string downloadsPath = Path.Combine(
    Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
    "Downloads"
);

string filePath = Path.Combine(downloadsPath, chosenFileName);


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
                //x.Item().Image(Placeholders.Image(200, 100));
                x.Item().Image(imageFilePath);
            });
    });
})
.GeneratePdf(filePath);