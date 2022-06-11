using System; 
class Sample
{
    static void Main()
    {
        Employee.OrganizationName = "UNR Inc.";
        Console.WriteLine("Welcome to " + Employee.OrganizationName);
       

        for (int i = 1; i < 11; i++)
        {
            int EmployeeNumber = i;
            
            Console.WriteLine("Employee Number : " + EmployeeNumber);

            Employee employee = new Employee();
            Console.Write("Enter EmpId : ");
            employee.EmpId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter EmpName : ");
            employee.EmpName = Console.ReadLine();


            Console.Write("Enter SalaryPerHour : ");
            employee.SalaryPerHour = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter NoOfWorkingHours : ");
            employee.NoOfWorkingHours = Convert.ToInt32(Console.ReadLine());

            int NetSalary = employee.SalaryPerHour * employee.NoOfWorkingHours;

            Console.WriteLine("\nEmpID = " + employee.EmpId);
            Console.WriteLine("EmpName = " + employee.EmpName);
            Console.WriteLine("SalaryPerHour = " + employee.SalaryPerHour);
            Console.WriteLine("NoOfWorkingHours = " + employee.NoOfWorkingHours);
            Console.WriteLine("NetSalary = " + NetSalary);
            Console.WriteLine("Organization Name = " + Employee.OrganizationName);
            Console.WriteLine("Type of Employee = " + Employee.TypeOfEmployee);
            Console.WriteLine("Department Name = " + employee.DepartmentName);

            Console.WriteLine("Do you want to continue to the next Employee : Y/N? ");
            string choice = Console.ReadLine();

            if (!(choice == "Y" || choice == "Yes"))
            {
                break;
            }
            Console.WriteLine("-------------------------");
        }
        Console.WriteLine("Thank you!");
        Console.ReadKey();
                
    }

 }
    



     
