
using System.Collections.Generic;
using System.Net;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;

namespace MyCompiler
{

    class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Salary { get; set; }
    }


    class Departemets
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {


            // OBJECT AS AN ARRAY 
            var objects = new[] { "Pen", "Pencil", "Scale", "Box", "l" };

            // "employees" ACTS FOR ALL LINQ PROBELEMS
            var employees = new List<Employee>() {
            new Employee { Id = 1, Name = "Jhon", Salary = 4000 },
            new Employee { Id = 2, Name = "Peter", Salary = 50000 },
            new Employee { Id = 3, Name = "Reshi", Salary = 40000 },
            new Employee { Id = 4, Name = "JEEVA",  Salary = 40000 },
        };
            // "departments" ACTS FOR ALL LINQ PROBELEMS 

            var departments = new List<Departemets>() {
      new Departemets {Id = 101, Name = "HR        "},
      new Departemets {Id = 102, Name = "ACCOUNTS  "},
      new Departemets {Id = 103, Name = "SALES     "}
    };

            //Console.WriteLine(string.Join(",", objects.Length));

            // 1)  ------     order by length 

            //var store = from obj in objects orderby obj.Length select obj;
            //Console.WriteLine(string.Join(",", store));

            //----- output : -l,Pen,Box,Scale,Pencil

            // ------------------------------------------------
            // var store = from obj in objects select obj.Contains('a');
            // Console.WriteLine(string.Join (",", store));

            //----- output  :- False,False,True,False
            //2)
            //-----------------------------------------------------------------------------

            //   var store = from i in Enumerable.Range(0, objects.Length) select i;
            //   var selectors = objects.Select(i => i.Length > 3 ? i : null).ToList();
            //  var result = string.Join(",", objects.Select(i => i.Length > 3 ? i : null).Where(i => i != null));

            //   Console.WriteLine(string.Join(",", result));
            //   Console.WriteLine(string.Join(",", store));

            // 3)
            //-----------------------------------------------------------------------------

            //var store = string.Join(",", objects);
            //Console.WriteLine(string.Join(",", store));

            //var link = from obj in objects select obj.Length > 4;
            //Console.WriteLine(string.Join(",", link));
            // var result = from i in objects where i.Length > 3 select i;
            //   Console.WriteLine(string.Join(",", result));
            //-----------------------------------------------------------------------------
            // 4)

            //    var query = from obj in objects select obj.Length > 3;
            //   Console.WriteLine(string.Join(",", query.Max()));

            //  var cards = from obj in Enumerable.Range(0, objects.Length) select obj;
            //  Console.WriteLine(string.Join(",", cards.Max()));


            //---- program to sort a list of employees based on Id using LINQ
            //-----------------------------------------------------------------------------
            // 5)

            //var store = from x in employees where x.Id > 1 select x.Id;
            //// ----- C# program to sort a list of employees based on salary using LINQ
            //foreach (var values in store)
            //{
            //    Console.WriteLine(string.Join(",", values));
            //}

            // --- OUTPUT 2 , 3 , 4
            //-----------------------------------------------------------------------------
            // 6)
            //var TopPaiedEmp = from emp in objects select emp.Length;
            //Console.WriteLine(string.Join(",", TopPaiedEmp));


            // 7)
            //-----------------------------------------------------------------------------

            //-------------  Getting the IP Address

            //IPAddress[] ips;
            //IPHostEntry entry;
            //string HostName = "";

            //entry = Dns.GetHostEntry(HostName);
            //entry = Dns.GetHostEntry(HostName);
            //ips = entry.AddressList;

            //for (int i = 0; i < ips.Length; i++)
            //{
            //    Console.WriteLine("IP Address: " + ips[i]);
            //}
            //  IP Address: -e80::-1-a: fb2: 1179:dd2- % 8
            //IP Address: 19-5.1-.1.13-

            // Console.WriteLine(string.Join(",", objects));


            // GETTING THE BOOLAN VALUES FROM THE SELECT STATEMENT 
            //var result = employees.OrderBy(sal => sal.Salary);
            //foreach (var emps in result)
            //{
            //    Console.WriteLine(string.Join(",", emps.Salary > 30000));
            //}
            // OUTPUT --------  False,     True,    True,    True
            //-----------------------------------------------------------------------------
            // 8)  EMPLOYESS SALARY > 30000
            //var result = employees.Where(sal => sal.Salary > 35000);

            //Console.WriteLine("ID  Name   Salary");
            //Console.WriteLine("==================");
            //foreach (Employee emp in result)
            //{
            //    Console.WriteLine(string.Join(",", $" Id : {emp.Id} Name : {emp.Name} "));
            //}

            // OUTPUT : ----------
            // ID  Name   Salary
            //==================
            //Id : 2 Name : Peter
            //Id : 3 Name : Reshi
            //Id : 4 Name : JEEVA
            //-----------------------------------------------------------------------------


            // USING THE "WHERE" method
            // 9) SELECT NAME INDEDX OF 0 == 'R'
            //var students = new List<string>();
            //students.Add("Jeeva");
            //students.Add("Reshi");
            //students.Add("Ayan");
            //students.Add("Robot");

            //var fetcherOfChar = students.Where(i => i[0] == 'R');
            //Console.WriteLine(string.Join(",", fetcherOfChar));

            // OUTPUT : -------
            // Reshi,Robot
            //-----------------------------------------------------------------------------

            // 10 ) SELECT NAME LENGTH > 5

            //  var GetName = from s in students where s.Length > 4 select s;
            // Console.WriteLine(string.Join(",", GetName));

            // OUTPUT : ------- Jeeva,Reshi,Robot

            //-----------------------------------------------------------------------------

            // 11) SELECT THE DISTIENT NUMBER IN THE LIST;
            // USING THE "DISTINCT" method

            //List<int> Numbers = new List<int>() { 10, 20, 20, 30, 40, 10, 50, 60, 10 };
            //var selectTheUniqueNumbers = Numbers.Distinct().ToList();

            //Console.WriteLine(string.Join(",", selectTheUniqueNumbers));

            //  OUTPUT : -  10,20,30,40,50,60
            //-----------------------------------------------------------------------------

            // 12) Get the Sum using "Aggregate";

            //int[] values = { 10, 8, 2, 2, 7, 4 };
            //int SUM = 0;
            //int Total = values.Aggregate((x, y) => x + y);
            //Console.WriteLine(Total);
            // OUTPUT :--- 33

            //-----------------------------------------------------------------------------

            // 13 )  TOTAL OF EMPLOYEE'S SALARIES USING THE "AGGREGATE () " 


            //var TotalSalary = 0.0;
            //TotalSalary = employees.Aggregate<Employee, double>(0, (sum, e) => sum += e.Salary);

            //Console.WriteLine($"Total Salary: {TotalSalary}");
            // OUTPUT : Total Salary: 134000

            //-----------------------------------------------------------------------------

            //   var result = TwoSum(new[] { 1, 2, 3, 4, 6, 5 }, 3);
            // Console.WriteLine(string.Join(",", result));

            // TWO SUM QUESTION FROM LEET CODE

            //public static int[] TwoSum(int[] nums, int target)
            //{

            //    var query = from i in Enumerable.Range(0, nums.Length)
            //                from j in Enumerable.Range(i + 1, nums.Length - i - 1)
            //                where nums[i] + nums[j] == target
            //                select new int[] { i,j };

            //    return query.First();
            //}
            //-----------------------------------------------------------------------------

            // 14 )   FIND THE LONGEST COMMON PREFIX STRING

            //public static string Result(string[] ss)
            //{
            //    string shortest = ss.OrderBy(s => s.Length).First();

            //    for (int i = 0; i < shortest.Length; i++)
            //    {
            //        if (ss.Select(s => s[i]).Distinct().Count() > 1) return shortest[..i];
            //    }

            //    return shortest;


            // OUTPUT -- Output: "fl"

            //  Console.WriteLine(string.Join(",", Result(new[] { "flower", "flow", "flight" })));


            //-----------------------------------------------------------------------------

            // 15 ) JOIN EMPLOYEE AND DEPARTMENT CLASS USING "JOIN()" METHOD;

            //      var Result = employees.Join(departments,
            //emp => emp.Id,
            //dept => dept.Id,
            //(emp, dept) => new
            //{
            //    ID = emp.Id,
            //    Name = emp.Name,
            //    Salary = emp.Salary,
            //    DeptName = dept.Name

            //}).ToList();

            // Console.WriteLine("Employee Details: ");
            //  foreach (var e in Result)
            //  {
            //      Console.WriteLine("\tID: " + e.ID + ", Name: " + e.Name + ", Salary: " + e.Salary + ", Department: " + e.DeptName);
            // }

            // OUTPUT : - 
            //  Employee Details:
            //     ID: 101, Name: Amit  , Salary: 4000, Department: HR
            //   ID: 102, Name: Amit  , Salary: 3800, Department: ACCOUNTS
            //   ID: 103, Name: Salman, Salary: 3500, Department: SALES
            //   ID: 104, Name: Ram   , Salary: 2000, Department: HR
            //  ID: 105, Name: Shyam , Salary: 7000, Department: ACCOUNTS
            //  ID: 106, Name: Kishor, Salary: 5000, Department: SALES


            //  return shortLength;
            //   return ss.ElementAt(1);
            //
            //return ss[ss.Length - 1];
            //  return ss.OrderByDescending(x => x.Length).LastOrDefault();


            //-----------------------------------------------------------------------------

            // 15 ) JOIN EMPLOYEE AND DEPARTMENT CLASS USING "JOIN()" LINQ;
            //  var ResultQuery = (from emp in employees
            //                   join dept in departments on emp.DEPT_ID equals dept.DEPT_ID
            //                   select new
            //                  {
            //                       ID = emp.ID,
            //                     Name = emp.Name,
            //                     Salary = emp.Salary,
            //                     DeptName = dept.DEPT_Name
            //              }).ToList();

            //     Console.WriteLine("Employee Details: ");
            //    foreach (var e in ResultQuery)
            //     {
            //       Console.WriteLine("\tID: " + e.ID + ", Name: " + e.Name + ", Salary: " + e.Salary + ", Department: " + e.DeptName);


            // OUTPUT : --------------
            //   Employee Details:
            //   ID: 101, Name: Amit  , Salary: 4000, Department: HR
            //   ID: 102, Name: Amit  , Salary: 3800, Department: ACCOUNTS
            //   ID: 103, Name: Salman, Salary: 3500, Department: SALES
            //   ID: 104, Name: Ram   , Salary: 2000, Department: HR
            //   ID: 105, Name: Shyam , Salary: 7000, Department: ACCOUNTS
            //   ID: 106, Name: Kishor, Salary: 5000, Department: SALES
        }
    }
}
