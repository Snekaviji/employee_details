namespace my_tech_bk.Models
{
    public class EmployeeModels
    {
        public int Id { get; set; }
        public string EmpId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string? Role { get; set; }
        public string? Location { get; set; }
    }
}
