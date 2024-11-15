using DapperApplication.Model;

namespace DapperApplication.Service.IService
{
    public interface IEmployeeRepository
    {
        public Task<IEnumerable<Employee>> GetEmployees();
    }
}
