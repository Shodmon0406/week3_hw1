namespace Domain.Model;

public class Department
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Employee Manager { get; set; }
}
