namespace ConsoleApp64
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Employee emp1 = new Employee("John Doe", "Developer", 80000);
        Employee emp2 = new Employee("Jane Smith", "Manager", 90000);

      
        emp1.DisplayInformation();
        emp2.DisplayInformation();

       
        emp1.IncreaseSalary(5000);
        emp2.ChangePosition("Senior Manager");

      
        emp1.DisplayInformation();
        emp2.DisplayInformation();
        }
    }
}