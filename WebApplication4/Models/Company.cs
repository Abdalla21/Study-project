using WebApplication4.Models;

namespace StudyProject.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyDescription { get; set; }
        public Employee? Employees { get; set; }
    }
}
