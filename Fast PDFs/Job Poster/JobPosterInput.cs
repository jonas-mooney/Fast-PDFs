using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;

namespace Fast_PDFs
{
    public class JobPosterInput
    {
        public GetJobPosterInput()
        {
            Console.WriteLine("Name of company:\n");
            string companyName = Console.ReadLine();

            Console.WriteLine("Job title:\n");
            string jobTitle = Console.ReadLine();

            Console.WriteLine("Job description:\n");
            string description = Console.ReadLine();

            var salaryOrHourly = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title($"Will compensation be listed by salary or hourly?")
                .PageSize(10)
                .AddChoices(new[] {
                                "Salary", "Hourly",
            }));

            Console.WriteLine($"{salaryOrHourly} amount:\n");
            string compensation = Console.ReadLine();


            var fullOrPartTime = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title($"Is this role full time or part time?")
                .PageSize(10)
                .AddChoices(new[] {
                                "Full time", "Part time",
            }));

            Console.WriteLine("Please list job qualifications one at a time, hitting enter after each entry (max 10):\n");
            string[] jobQualifications = [];
            bool enteringJobQualifications = true;
            while ( enteringJobQualifications &&  jobQualifications.Length <= 10)
            {
                string newEntry = Console.ReadLine();
                jobQualifications = jobQualifications.Append(newEntry).ToArray();
            }

            return new JobPoster()
        }
    }
}
