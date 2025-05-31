namespace Fast_PDFs
{
    public class JobPoster
    {
        // name of company, job title, option to include salary or hourly wage, full time or part time w/ hours, description, qualifications, job requirements, contact info

        public string CompanyName { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public string SalaryOrHourly { get; set; }
        public int Salary { get; set; }
        public int HourlyWage { get; set; }
        public string FullOrPartTime { get; set; }
        public string[] Qualifications { get; set; }
        public string[] JobRequirements { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public string Url { get; set; }

        public JobPoster(string companyName, string jobTitle, string jobDescription, string salaryOrHourly, int salary, int hourlyWage)
        {
            CompanyName = companyName;
        }
    }
}
