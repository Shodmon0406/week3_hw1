using Domain.Model;

namespace Infrastructure.Services;

public class EmployeeService
{
    public List<Employee> Employees { get; set; }
    public EmployeeService()
    {
        Employees = new List<Employee>();
    }
    public void AddEmployees(Employee employee)
    {
        employee.Id = Employees.Count + 1;
        Employees.Add(employee);
    }
    public List<Employee> GetEmployees()
    {
        return Employees;
    }
    public Employee UpdateEmployee(Employee employee)
    {
        foreach (var emp in Employees)
        {
            if (emp.Id == employee.Id)
            {
                emp.FirstName = employee.FirstName;
                emp.LastName = employee.LastName;
                emp.BirthDate = employee.BirthDate;
                emp.Salary = employee.Salary;
                emp.Department.Name = employee.Department.Name;
                emp.Department.Description = employee.Department.Description;
                return emp;
            }
        }
        return null;
    }
    public string DeleteEmployee(Employee employee)
    {
        foreach (var emp in Employees)
        {
            if (emp.Id == employee.Id)
            {
                Employees.Remove(emp);
                return "Employee deleted successfully";
            }
        }
        return null;
    }
    public int CountEmployees()
    {
        return Employees.Count;
    }
}
