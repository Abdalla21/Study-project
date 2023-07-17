using StudyProject.Models;

namespace WebApplication4.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Title { get; set; }
        public int companyId { get; set; }
        public required Company Companies { get; set; }
    }
}
