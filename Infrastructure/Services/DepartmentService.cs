using Domain.Model;

namespace Infrastructure.Services;

public class DepartmentService
{
    public List<Department> Departments { get; set; }
    public DepartmentService()
    {
        Departments = new List<Department>();
    }
    public void AddDepartments(Department department)
    {
        department.ID = Departments.Count + 1;
        Departments.Add(department);
    }
    public List<Department> GetDepartments()
    {
        return Departments;
    }
    public Department UpdateDepartment(Department department)
    {
        foreach (var dep in Departments)
        {
            if (dep.ID == department.ID)
            {
                dep.Name = department.Name;
                dep.Description = department.Description;
                return dep;
            }
        }
        return null;
    }
    public string DeleteDepartment(Department department)
    {
        foreach (var dep in Departments)
        {
            if (dep.Name == department.Name)
            {
                Departments.Remove(dep);
                return "Deleted successfuly";
            }
        }
        return "Department notfound";
    }
    public int CountDepartments()
    {
        return Departments.Count;
    }
}
