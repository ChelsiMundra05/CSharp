using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nEnter 'i' to insert or 'q' to quit.");
                if (Convert.ToChar(Console.ReadLine())=='q')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nEnter Employee Id, Name, Department Name(in separate line):");
                    int Id=Int32.Parse(Console.ReadLine());
                    string Name=Console.ReadLine();
                    string DepartmentName=Console.ReadLine();
                    Employee emp = new Employee(Id, Name, DepartmentName);
                    emp.MethodCall+=OnMethodCall;
                    Console.WriteLine("\n\\\\Displaying entered data\\\\\n");
                    displayData(emp);
                    Console.WriteLine("\nEnter 'm' to update.");
                    if (Convert.ToChar(Console.ReadLine())=='m')
                    {
                        modifyData(emp);
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                    
                }
            }

        }

        private static void modifyData(Employee emp)
        {
            Console.WriteLine("\nEnter Employee Id, Name, Department Name to Update(in separate line):");
            int Id=Int32.Parse(Console.ReadLine());
            emp.modify(Id);
            string Name=Console.ReadLine();
            emp.modify(Name);
            string DepartmentName=Console.ReadLine();
            emp.modify(Id,DepartmentName);
            Console.WriteLine("\nSuccessfully Updated.");
            Console.WriteLine("\n\\\\Displaying updated data\\\\\n");
            displayData(emp);
        }

        private static void displayData(Employee emp)
        {
            Console.WriteLine($"Employee Id: {emp.GetId()}");
            Console.WriteLine($"Employee Name: {emp.GetName()}");
            Console.WriteLine($"Employee DeartmentName: {emp.GetDepartmentName()}");
        }
        static void OnMethodCall(object sender,EventArgs args,string functionName)
        {
            Console.WriteLine($"{functionName} method called");
        }
    }
}