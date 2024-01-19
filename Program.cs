
using ComposicaoExercicio1.Entities;
using ComposicaoExercicio1.Entities.Enums;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Globalization;

namespace ComposicaoExercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter department's name: ");
            string department = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel workerLevel1 = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("How many contracts to this worker?");
            int manyContracts = int.Parse(Console.ReadLine());

            Department department1 = new Department(department);

            Worker worker = new Worker(name, workerLevel1, baseSalary, department1);



            for (int i = 1; i <= manyContracts; i++)
            {


                Console.WriteLine("Enter #" + i + " contract data:");


                Console.Write("Date(DD/ MM / YYYY): ");
                DateTime dataContract = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duration(hours): ");
                int duraction = int.Parse(Console.ReadLine());

                HourContract hourContract = new HourContract(dataContract, valuePerHour, duraction);

                worker.AddContract(hourContract);

            }

            Console.Write("Enter month and year to calculate income(MM / YYYY):");
            string monthYear = Console.ReadLine();
            int month = int.Parse(monthYear.Substring(0, 2));
            int year = int.Parse(monthYear.Substring(3));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Departament: " + worker.Department.Name);
            Console.WriteLine("Income for " + monthYear + ": " + worker.Income(year, month));



            //            Enter #1 contract data:
            //Date(DD/ MM / YYYY): 20 / 08 / 2018
            //Value per hour: 50.00
            //Duration(hours): 20
            //Enter #2 contract data:
            //Date(DD/ MM / YYYY): 13 / 06 / 2018
            //Value per hour: 30.00
            //Duration(hours): 18
            //Enter #3 contract data:
            //Date(DD/ MM / YYYY): 25 / 08 / 2018
            //Value per hour: 80.00
            //Duration(hours): 10
            //Enter month and year to calculate income(MM / YYYY):


        }
    }
}
