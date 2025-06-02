namespace Fast_PDFs
{
    public class JobPoster
    {
        public string CompanyName { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public Compensation Compensation { get; set; }
        public string FullOrPartTime { get; set; }
        public string[] Qualifications { get; set; }
        public string[] JobRequirements { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public string Url { get; set; }

        public JobPoster(string companyName, string jobTitle, string jobDescription, Compensation compensation, string fullOrPartTime, string[] qualifications, string[] jobRequirements, string contactPhone, string contactEmail, string url)
        {
            CompanyName = companyName;
            JobTitle = jobTitle;
            JobDescription = jobDescription;
            Compensation = compensation;
            FullOrPartTime = fullOrPartTime;
            Qualifications = qualifications;
            JobRequirements = jobRequirements;
            ContactPhone = contactPhone;
            ContactEmail = contactEmail;
            Url = url;
        }
    }

    public class Compensation
    {
        public string Type { get; set; }
        public decimal Amount { get; set; }

        public Compensation(string type, decimal amount)
        {
            Type = type;
            Amount = amount;
        }
    }
}
