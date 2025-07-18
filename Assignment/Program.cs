using Assignment;
using System.Reflection.Emit;
using System.Reflection;
using System.Xml.Linq;

namespace Assignment
{
    //struct point
    //{
    //    public double x;
    //    public double y;
    //}

    //struct person
    //{

    //    public string name;
    //    public int age;
    //}

    public enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            #region Q1 [part 1]
            //point p1, p2;

            //Console.WriteLine("Enter X for poin 1 : ");
            //p1.x = Convert.ToDouble(Console.ReadLine());

            // Console.WriteLine("Enter Y for poin 1 : ");
            //p1.y = Convert.ToDouble(Console.ReadLine());

            // Console.WriteLine("Enter X for poin 2 : ");
            //p2.x = Convert.ToDouble(Console.ReadLine());

            // Console.WriteLine("Enter Y for poin 2 : ");
            //p2.y = Convert.ToDouble(Console.ReadLine());

            //double dx = p1.x - p2.x; 
            //double dy = p1.y - p2.y; 

            //double distance = dx * dx + dy * dy;
            //Console.WriteLine("Distance = " + distance);



            #endregion

            #region Q2 [part 1]
            //person p1, p2, p3;

            //Console.WriteLine("Enter name of person 1 :");
            //p1.name = Console.ReadLine() + "0";

            //Console.WriteLine("Enter Age of person 1 :");
            //p1.age =Convert.ToInt32 (Console.ReadLine());


            //Console.WriteLine("Enter name of person 2 :");
            //p2.name = Console.ReadLine() + "0";

            //Console.WriteLine("Enter Age of person 2 :");
            //p2.age =Convert.ToInt32 (Console.ReadLine());


            //Console.WriteLine("Enter name of person 3 :");
            //p3.name = Console.ReadLine() + "0";

            //Console.WriteLine("Enter Age of person 3 :");
            //p3.age =Convert.ToInt32 (Console.ReadLine());

            // person oldest = p1;

            //if (p2.age > oldest.age) 
            //      oldest = p2;

            //if (p3.age > oldest.age) 
            //      oldest = p3;

            //Console.WriteLine("Oldest person: " + oldest.name);
            //Console.WriteLine("Age: " + oldest.age);
            #endregion


            #region Q3 [part 2]
            Employee[] EmpArr = new Employee[3];

            EmpArr[0] = new Employee(1, "Anas", 'M', SecurityLevel.DBA, 12000, new HiringDate(10, 5, 2020));

            EmpArr[1] = new Employee(2, "Mohamed", 'F', SecurityLevel.Guest, 7000, new HiringDate(15, 7, 2021));

            EmpArr[2] = new Employee(3, "Omar", 'M', SecurityLevel.Developer, 9000, new HiringDate(1, 1, 2022));

            foreach (var emp in EmpArr)
            {
                Console.WriteLine(emp);
            }
            #endregion


        }
    }
}

    
    

