/*  1. Not need to add Namespace, which we are using globally, these namespaces already define
       in globally.cs
    2. Curly Braces are Removed for namespace 
*/
namespace CSharp10;

internal class Program
{
    public static void Main(string[] args)
    {
        int a = 5, b = 3;
        int sum = Calculator.Add(a, b);

        // 3. New way to check Null Parameter 
        ArgumentNullException.ThrowIfNull(sum);
        
         Employee employee = new Employee();
        
        if(employee is Employee { Department.Location: "Multan" })
        {
            Console.WriteLine(employee.Department.Location);
        }

    }
}