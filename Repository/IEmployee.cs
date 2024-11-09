using AspCoreWebAppMVC.Models;

namespace AspCoreWebAppMVC.Repository
{
    public interface IEmployee
    {
        List<Employee> getAllEmployees();
        Employee getEmployeeById(int id);
    }
}
