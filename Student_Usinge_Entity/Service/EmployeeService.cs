using Student_Usinge_Entity.Data;
using Student_Usinge_Entity.Models;

namespace Student_Usinge_Entity.Service
{
    public class EmployeeService : IEmployeeService
    {
        private EmpDbContext _dbContext;
        public EmployeeService(EmpDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Response DeleteEmployee(int id)
        {
            Response response = new Response();
            Employee emp = GetEmployeeById(id);
            try
            {
                if(emp != null)
                {
                    _dbContext.Remove<Employee>(emp);
                    _dbContext.SaveChanges();
                    response.IsSucess = true;
                    response.Message = "Record is Deleted";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }

        public List<Employee> GetAllEmployee()
        {
            List<Employee> EmpList = new List<Employee>();
            try
            {
                EmpList = _dbContext.Set<Employee>().ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
            return EmpList;
           
        }

        public Employee GetEmployeeById(int id)
        {
            Employee Emp = new Employee();
            try
            {
                Emp = _dbContext.Find<Employee>(id);
            }
            catch
            {
                throw;
            }
            return Emp;
        }

        public Employee GetEmployeeByName(string name)
        {
            Employee Emp = new Employee();
            try
            {
                Emp = _dbContext.Find<Employee>(name);
            }
            catch
            {
                throw;
            }
            return Emp;
        }

        public Employee SaveEditEmployee(Employee employee)
        {
            Response response = new Response();
            Employee emp = GetEmployeeById(employee.ID);
            try
            {
                if (emp != null)
                {

                    emp.Name = employee.Name;
                    emp.Salary = employee.Salary;
                    emp.Address = employee.Address;
                    emp.MobNo = employee.MobNo;
                    emp.Designation = employee.Designation;

                    _dbContext.Update<Employee>(emp);
                    response.Message = "Employee id Updated";
                }
                else
                {
                    _dbContext.Add<Employee>(employee);
                    response.Message = "Employee Save SucessFully";
                }
                _dbContext.SaveChanges();
                response.IsSucess = true;

            }
            catch(Exception ex)
            {
                response.Message = ex.Message;
            }
           return employee;
        }
    }
}
