using Student_Usinge_Entity.Models;

namespace Student_Usinge_Entity.Service
{
    public interface IEmployeeService
    {
        List<Employee> GetAllEmployee();
        Employee GetEmployeeById(int id);
        Employee GetEmployeeByName(string name);
        Employee SaveEditEmployee(Employee employee);
        Response DeleteEmployee(int id);

    }
}
