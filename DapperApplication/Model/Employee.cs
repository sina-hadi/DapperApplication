namespace DapperApplication.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int Age { get; set; }
        public required string Position { get; set; }
        public int CompanyId { get; set; }
    }
}
