namespace DapperApplication.Model.DTOs
{
    public class CompanyCreateDto
    {
        public required string Name { get; set; }
        public required string Address { get; set; }
        public required string Country { get; set; }
    }
}
