using Spectre.Console;

namespace Fast_PDFs
{
    internal class PosterSelect
    {
        public static string UserPosterSelection()
        {
            var posterSelection = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Select poster type")
                .PageSize(10)
                .MoreChoicesText("[grey](Move up and down to reveal more fruits)[/]")
                .AddChoices(new[] {
                    "Event", "Missing Pet", "Job Post",
                }));

            return posterSelection;
        }
    }
}
