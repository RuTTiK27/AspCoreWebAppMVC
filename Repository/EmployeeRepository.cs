using AspCoreWebAppMVC.Models;

namespace AspCoreWebAppMVC.Repository
{
    public class EmployeeRepository : IEmployee
    {
        public List<Employee> getAllEmployees()
        {
            return DataSource();
        }

        public Employee getEmployeeById(int id)
        {
            return DataSource().Where(e=>e.EmpId==id).FirstOrDefault();
        }
        private List<Employee> DataSource() 
        {
            return new List<Employee>
            {
                new Employee {EmpId = 1,Name="John",Job="Manager",Salary=50000},
                new Employee {EmpId = 2,Name="Alice",Job="Developer",Salary=45000},
                new Employee {EmpId = 3,Name="Bob",Job="Designer",Salary=40000},
                new Employee {EmpId = 4,Name="Eve",Job="Analyst",Salary=42000},
                new Employee {EmpId = 5,Name="Charlie",Job="Tester",Salary=38000}
            };
        }
    }
}
