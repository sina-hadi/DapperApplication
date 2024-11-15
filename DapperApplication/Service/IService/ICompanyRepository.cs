using DapperApplication.Model;
using DapperApplication.Model.DTOs;

namespace DapperApplication.Service.IService
{
    public interface ICompanyRepository
    {
        public Task<IEnumerable<Company>> GetCompanies();
        public Task<Company?> GetCompany(int id);
        public Task<Company> CreateCompany(CompanyCreateDto company);
        public Task UpdateCompany(int id, CompanyCreateDto company);
        public Task DeleteCompany(int id);
        public Task<Company?> GetCompanyByEmployeeId(int id);
        public Task<Company?> GetCompanyEmployeesMultipleResults(int id);
        public Task<List<Company>> GetCompaniesEmployeesMultipleMapping();
    }
}
