namespace DapperApplication.Model
{
    public class Company
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Address { get; set; }
        public required string Country { get; set; }
        public List<Employee> Employees { get; set; } = [];
    }
}
