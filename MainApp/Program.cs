using Domain.Model;
using Infrastructure.Services;

EmployeeService employeeService = new EmployeeService();
DepartmentService departmentService = new DepartmentService();
for (int i = 1; i <= 5; i++)
{
    System.Console.WriteLine($"Employee {i}");
    Employee employee = new Employee();
    System.Console.Write("Enter your name: ");
    employee.FirstName = Console.ReadLine();
    System.Console.Write("Enter your surname: ");
    employee.LastName = Console.ReadLine();
    System.Console.Write("Enter your birthdate: ");
    employee.BirthDate = Convert.ToDateTime(Console.ReadLine());
    System.Console.Write("Enter your salary: ");
    employee.Salary = Convert.ToDecimal(Console.ReadLine());
    System.Console.Write("Enter your department name: ");
    employee.Department = new Department();
    employee.Department.Name = Console.ReadLine();
    System.Console.Write("Enter your department description: ");
    employee.Department.Description = Console.ReadLine();
    employeeService.AddEmployees(employee);
    departmentService.AddDepartments(employee.Department);
}
Employee employee1 = new Employee();
System.Console.WriteLine("Method update");
System.Console.Write("Enter ID: ");
employee1.Id = int.Parse(Console.ReadLine());
System.Console.Write("Enter name: ");
employee1.FirstName = Console.ReadLine();
System.Console.Write("Enter surname: ");
employee1.LastName = Console.ReadLine();
System.Console.Write("Enter birthdate: ");
employee1.BirthDate = Convert.ToDateTime(Console.ReadLine());
System.Console.Write("Enter salary: ");
employee1.Salary = Convert.ToDecimal(Console.ReadLine());
System.Console.Write("Enter department name: ");
employee1.Department = new Department();
employee1.Department.Name = Console.ReadLine();
System.Console.Write("Enter department description: ");
employee1.Department.Description = Console.ReadLine();
employeeService.UpdateEmployee(employee1);
System.Console.Write(employeeService.UpdateEmployee(employee1).Id);
for (int i = 1; i <= 7 - employeeService.UpdateEmployee(employee1).Id.ToString().Length; i++)
{
    System.Console.Write(" ");
}
System.Console.Write(employeeService.UpdateEmployee(employee1).FirstName);
for (int i = 1; i <= 15 - employeeService.UpdateEmployee(employee1).FirstName.Length; i++)
{
    System.Console.Write(" ");
}
System.Console.Write(employeeService.UpdateEmployee(employee1).LastName);
for (int i = 1; i <= 15 - employeeService.UpdateEmployee(employee1).LastName.Length; i++)
{
    System.Console.Write(" ");
}
System.Console.Write(employeeService.UpdateEmployee(employee1).BirthDate.ToShortDateString());
for (int i = 1; i <= 14 - employeeService.UpdateEmployee(employee1).BirthDate.ToShortDateString().Length; i++)
{
    System.Console.Write(" ");
}
System.Console.Write("$");
System.Console.Write(employeeService.UpdateEmployee(employee1).Salary);
for (int i = 1; i <= 10 - employeeService.UpdateEmployee(employee1).Salary.ToString().Length; i++)
{
    System.Console.Write(" ");
}
System.Console.Write(employeeService.UpdateEmployee(employee1).Department.Name);
for (int i = 1; i <= 15 - employeeService.UpdateEmployee(employee1).Department.Name.Length; i++)
{
    System.Console.Write(" ");
}
System.Console.Write(employeeService.UpdateEmployee(employee1).Department.Description);
for (int i = 1; i <= 15 - employeeService.UpdateEmployee(employee1).Department.Description.Length; i++)
{
    System.Console.Write(" ");
}
System.Console.WriteLine();
// System.Console.WriteLine(employeeService.DeleteEmployee(employee1));


System.Console.WriteLine("------------------------------------------------------------------------------------------");
System.Console.WriteLine("ID     Name           Surname        Birthdate     Salary     DepName        DepDesc        ");
foreach (var emp in employeeService.GetEmployees())
{
    System.Console.Write(emp.Id);
    for (int i = 1; i <= 7 - emp.Id.ToString().Length; i++)
    {
        System.Console.Write(" ");
    }
    System.Console.Write(emp.FirstName);
    for (int i = 1; i <= 15 - emp.FirstName.Length; i++)
    {
        System.Console.Write(" ");
    }
    System.Console.Write(emp.LastName);
    for (int i = 1; i <= 15 - emp.LastName.Length; i++)
    {
        System.Console.Write(" ");
    }
    System.Console.Write(emp.BirthDate.ToShortDateString());
    for (int i = 1; i <= 14 - emp.BirthDate.ToShortDateString().Length; i++)
    {
        System.Console.Write(" ");
    }
    System.Console.Write("$");
    System.Console.Write(emp.Salary);
    for (int i = 1; i <= 10 - emp.Salary.ToString().Length; i++)
    {
        System.Console.Write(" ");
    }
    System.Console.Write(emp.Department.Name);
    for (int i = 1; i <= 15 - emp.Department.Name.Length; i++)
    {
        System.Console.Write(" ");
    }
    System.Console.Write(emp.Department.Description);
    for (int i = 1; i <= 15 - emp.Department.Description.Length; i++)
    {
        System.Console.Write(" ");
    }
    System.Console.WriteLine();
}

System.Console.WriteLine("------------------------------------------------------------------------------------------");
System.Console.WriteLine("ID   DepartmentName    DepartmentDescription ");
foreach (var dep in departmentService.GetDepartments())
{
    System.Console.Write(dep.ID);
    for (int i = 1; i <= 5 - dep.ID.ToString().Length; i++)
    {
        System.Console.Write(" ");
    }
    for (int i = 1; i <= 6 - dep.Name.Length / 2; i++)
    {
        System.Console.Write(" ");
    }
    System.Console.Write(dep.Name);
    for (int i = 1; i <= 12 - dep.Name.Length / 2 - dep.Name.Length % 2; i++)
    {
        System.Console.Write(" ");
    }
    for (int i = 1; i <= 10 - dep.Description.Length / 2; i++)
    {
        System.Console.Write(" ");
    }
    System.Console.Write(dep.Description);
    for (int i = 1; i <= 12 - dep.Description.Length / 2 - dep.Description.Length % 2; i++)
    {
        System.Console.Write(" ");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine("------------------------------------------------------------------------------------------");