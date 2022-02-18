
namespace CSharp10;

internal class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Department? Department { get; set; } = new Department();
}

internal class Department
{
    public int Id { get; set; }
    public string Location { get; set; }  = "Multan";
}

