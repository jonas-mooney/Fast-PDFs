using Fast_PDFs;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using Document = QuestPDF.Fluent.Document;

QuestPDF.Settings.License = LicenseType.Community;

string posterSelect = PosterSelect.UserPosterSelection();



UserPreference preference = UserPreferenceInput.GetUserPreferenceFromConsole();




string downloadsPath = Path.Combine(
    Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
    "Downloads"
);

string filePath = Path.Combine(downloadsPath, preference.ChosenFileName);


Document.Create(container =>
{
    container.Page(page =>
    {
        page.Size(PageSizes.A4);
        page.Margin(2, Unit.Centimetre);
        page.PageColor(Colors.White);
        page.DefaultTextStyle(x => x.FontSize(20));

        page.Header()
            .Text(preference.HeaderText)
            .SemiBold().FontSize(36).FontColor(Colors.Blue.Medium);

        page.Content()
            .PaddingVertical(1, Unit.Centimetre)
            .Column(x =>
            {
                x.Spacing(20);

                x.Item().Text(preference.ContentText);
                x.Item().Image(preference.ImageFilePath);
            });
    });
})
.GeneratePdf(filePath);



/*

Class for poster type select
Classes for each type of poster



 */