using Spectre.Console;

namespace Fast_PDFs
{
    public class JobPosterInput
    {
        public JobPoster GetJobPosterInput()
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
            string compensationAmount = Console.ReadLine();
            Compensation compensation = new Compensation(salaryOrHourly, compensationAmount);


            var fullOrPartTime = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title($"Is this role full time or part time?")
                .PageSize(10)
                .AddChoices(new[] {
                                "Full time", "Part time",
            }));

            Console.WriteLine("Please list job qualifications one at a time, hitting enter after each entry (max 10):\n Hit enter without typing to exit.");
            Console.ReadLine();
            string[] jobQualifications = [];
            bool enteringJobQualifications = true;
            while (enteringJobQualifications && jobQualifications.Length <= 10)
            {
                string newQualEntry = Console.ReadLine();
                if (newQualEntry != "")
                {
                    jobQualifications = jobQualifications.Append(newQualEntry).ToArray();
                }
                else
                {
                    enteringJobQualifications = false;
                }
            }

            Console.WriteLine("Please list job requirements one at a time, hitting enter after each entry (max 10):\n Hit enter without typing to exit.");
            Console.ReadLine();
            string[] jobRequirements = [];
            bool enteringJobRequirements = true;
            while (enteringJobRequirements && jobRequirements.Length <= 10)
            {
                string newReqEntry = Console.ReadLine();
                if (newReqEntry != "")
                {
                    jobRequirements = jobRequirements.Append(newReqEntry).ToArray();
                }
                else
                {
                    enteringJobRequirements = false;
                }
            }

            Console.WriteLine("What phone number should be listed as a contact for this job listing?");
            string phone = Console.ReadLine();

            Console.WriteLine("What email should be listed as a contact for this job listing?");
            string email = Console.ReadLine();

            Console.WriteLine("What website should be listed as a contact for this job listing?");
            string url = Console.ReadLine();

            return new JobPoster(companyName, jobTitle, description, compensation, fullOrPartTime, jobQualifications, jobRequirements, phone, email, url);
        }
    }
}
