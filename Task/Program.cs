using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part01
            #region Problem1
            //var x = 10;
            //var y = "Mohamed";
            //var z = 15.25;
            //var c = true;
            // var arr = new [] { 1, 2, 3  };
            //Console.WriteLine(x.GetType());
            //Console.WriteLine(y.GetType());
            //Console.WriteLine(z.GetType());
            //Console.WriteLine(c.GetType());
            //Console.WriteLine(arr.GetType()); 
            #endregion


            #region Problem2
            //int age = 25;
            //string name = "Mohamed";
            //double salary = 15000.50;
            //bool isActive = true;

            //var age2 = 25;
            //var name2 = "Mohamed";
            //var salary2 = 15000.50;
            //var isActive2 = true;

            //// The result is the same at compile time because the compiler
            //// infers the exact type of each variable from its assigned value. 
            #endregion



            #endregion

            #region Part2
            #region Problem3
            //var prod = new { name = "lab", price = 15000m, quantity = 5 };
            //Console.WriteLine($"Name = {prod.name} , Price = {prod.price} , Quantity = {prod.quantity}"); 
            #endregion

            #region Problem4
            //var stud = new[]
            //{
            //    new
            //    {
            //        name = "mohamed",
            //        grade = 65
            //    },
            //    new
            //    {
            //        name = "malak",
            //        grade = 70
            //    },
            //    new
            //    {
            //        name = "menna",
            //        grade = 85
            //    }

            //};


            //foreach (var item in stud)
            //{
            //    Console.WriteLine($"Name = {item.name} , Grade = {item.grade}");
            //} 
            #endregion

            #region Problem5
            //var OrderCustomer = new
            //{
            //    Name = "Laptop",
            //    Price = 1500m,

            //    Customer = new
            //    {
            //        Name = "Mohamed",
            //        City = "Mostiy"
            //    }
            //};

            //Console.WriteLine($"Order Name: {OrderCustomer.Name}");
            //Console.WriteLine($"Order Price: {OrderCustomer.Price}");
            //Console.WriteLine($"Customer Name: {OrderCustomer.Customer.Name}");
            //Console.WriteLine($"Customer City: {OrderCustomer.Customer.City}"); 
            #endregion
            #endregion

            #region Part03
            #region Problem6
            //string word1 = "madam";
            //string word2 = "hello";
            //string word3 = "level";

            //Console.WriteLine(word1.IsPalindrome()); // True
            //Console.WriteLine(word2.IsPalindrome()); // False
            //Console.WriteLine(word3.IsPalindrome()); // True 
            #endregion

            #region Problem7
            //Console.WriteLine(7.IsPrime());   // True
            //Console.WriteLine(10.IsPrime());  // False
            //Console.WriteLine(13.IsPrime());  // True
            //Console.WriteLine(15.IsPrime());  // False
            //Console.WriteLine(1.IsPrime());   // False 
            #endregion

            #region Problem8
            //var Arr = new int[]
            //{
            //    10, 20, 30, 40
            //};

            //Console.WriteLine(Arr.Sum()); //100 
            #endregion

            #endregion

            #region Part04

            #region Problem9
            //List<string> Emp = new List<string>();

            //Emp.Add("Malak");
            //Emp.Add("Menna");
            //Emp.Add("Sara");
            //Emp.Add("Salma");
            //Emp.Add("Azaa");

            //Console.WriteLine("Emp Before Remove Element");

            //foreach (var item in Emp)
            //{
            //    Console.WriteLine(item);
            //}

            //Emp.Remove("Sara");

            //Console.WriteLine();
            //Console.WriteLine("Enter Name To Search:");

            //string name = Console.ReadLine();

            //bool found = false;

            //foreach (var item in Emp)
            //{
            //    if (item == name)
            //    {
            //        found = true;
            //        break;
            //    }
            //}

            //if (found)
            //    Console.WriteLine("Name Is Found");
            //else
            //    Console.WriteLine("Name Is Not Found");

            //Console.WriteLine();
            //Console.WriteLine("Emp After Remove Element");

            //foreach (var item in Emp)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Problem10
            //List<Employee> Emp = new List<Employee>();
            //Console.WriteLine("All Employees");
            //Emp.Add(new Employee() { Name = "Mohamed", Salary = 15000m });
            //Emp.Add(new Employee() { Name = "Ahmed", Salary = 12000m });
            //Emp.Add(new Employee() { Name = "Ibrahiem", Salary = 17000m });
            //Emp.Add(new Employee() { Name = "Sabry", Salary = 9000m });
            //Emp.Add(new Employee() { Name = "Youssef", Salary = 9500m });
            //Emp.Add(new Employee() { Name = "Omer", Salary = 8500m });

            //foreach (var item in Emp)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            //Console.Write(" Enter Given Salary: ");
            //decimal GivenSalary = decimal.Parse(Console.ReadLine());
            //Console.WriteLine();
            //foreach (var item in Emp)
            //{
            //    if(item.Salary > GivenSalary)
            //        Console.WriteLine(item);
            //} 
            #endregion

            #region Problem11
            //Dictionary<string , decimal> product = new Dictionary<string , decimal>();
            //product.Add("Laptop" , 30000m);
            //product.Add("Mouse", 300m);
            //product.Add("Keyboard", 1500m);

            //foreach (var item in product)
            //{
            //    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
            //} 
            #endregion

            #region Problem12
            // Dictionary<int , string> students = new Dictionary<int , string>();
            // students.Add(120 , "Menna");
            // students.Add(107, "Malak");
            // students.Add(112, "Salma");
            // students.Add(101, "Azaa");
            // students.Add(115, "Sara");
            // Console.Write("Enter ID OF Student: ");
            // int ID = int.Parse(Console.ReadLine());
            ////var result =  students.GetValueOrDefault(ID);
            //// Console.WriteLine($"student: {result}");

            // if(students.TryGetValue(ID , out string name))
            // {
            //     Console.WriteLine($"Student: {name}");
            // }
            // else
            // {
            //     Console.WriteLine("Student ID Not Found");
            // } 
            #endregion


            #endregion

            Console.ReadKey();
        }

    }
}
            
        
    

