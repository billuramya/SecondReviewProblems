using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularExpresions
{

    //Create a program to manage a list of students. Each student has properties such
    //as Name, Age, and Grade. Implement functionalities to add new students, remove students,
    //and find students belonging to a particular grade using LINQ.
    internal class Student
    {
        public string name { get; set; }
        public int Age { get; set; }
        public char Grade { get; set; }

        public void getStudentDetails()
        {
            List<Student> students = new List<Student>()
        {
            new Student {name= " Ramya",Age=22, Grade='A'},
            new Student {name= " ravi",Age=22, Grade='B'},
            new Student {name= " siva",Age=22, Grade='C'},
            new Student {name= " nandu",Age=22, Grade='A'},
        };

            students.Add(new Student { name = "priya", Age = 25, Grade = 'A' });

            char grade = 'A';

            //remove
            var removeParticular = students.SkipWhile(s => s.name == "ramya");

            var result = students.Where(s => s.Grade == grade);
            foreach (var std in result)
            {
                Console.WriteLine(std.name);
            }

        }

    }

    //Develop a program to manage a catalog of products. Each product has properties like Name,
    //Price, and Category. Implement functionalities to filter products based on price range and
    //category using LINQ.
    internal class Products
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Categary { get; set; }

        public void getProductDetalis()
        {
            List<Products> product = new List<Products>()
            {
                new Products {Name="Ramya",Price=2000,Categary="Watch"},
                new Products {Name="Ramya",Price=5000,Categary="Cloths"},
                new Products {Name="Ramya",Price=2000,Categary="Grocesries"},
                new Products {Name="Ramya",Price=2500,Categary="Makeup"},
                new Products {Name="Ramya",Price=4000,Categary="Watch"},
            };

            var result = product.Where(s => s.Price > 2000);

            foreach (var item in result)
            {
                Console.WriteLine(item.Name + "\t" + item.Categary);
            }
        }

    }


    //Build a generic calculator that can perform arithmetic operations (addition, subtraction,
    //multiplication, division) on numeric types (int, float, double). Ensure type safety and handle
    //edge cases appropriately.
    //class ArthematicOperations
    //{
    //public void operations()
    //{
    //    int intval = 24;
    //    float floatval = 43.5f;
    //    double doubleval = 2345;

    //    var addition = intval+floatval+doubleval;
    //    Console.WriteLine("Addition of 3 type numberics :{0}",addition);
    //    var sub = intval - floatval - doubleval;
    //    Console.WriteLine("sub of 3 type numberics :{0}", sub);
    //    var mul = intval * floatval * doubleval;
    //    Console.WriteLine("mul of 3 type numberics :{0}", mul);
    //    var div = intval / floatval / doubleval;
    //    Console.WriteLine("div of 3 type numberics :{0}", div);

    //}    
    // }

    class Calculations<T>
    {
        public T Add(T num1, T num2)
        {
            dynamic operand1 = num1;
            dynamic operand2 = num2;
            return operand1 + operand2;
        }
        public T Sub(T num1, T num2)
        {
            dynamic operand1 = num1;
            dynamic operand2 = num2;
            return operand1 - operand2;
        }
        public T Mul(T num1, T num2)
        {
            dynamic operand1 = num1;
            dynamic operand2 = num2;
            return operand1 * operand2;
        }
        public T Div(T num1, T num2)
        {
            dynamic operand1 = num1;
            dynamic operand2 = num2;
            if (operand2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }

            return operand1 / operand2;
        }

    }
    class GetSollution
    {
        public void calculations()
        {
            Calculations<int> calculations = new Calculations<int>();
            Console.WriteLine("Addition of int :{0}", calculations.Add(23, 4));
            Console.WriteLine(calculations.Sub(23, 4));
            Console.WriteLine(calculations.Mul(23, 4));
            Console.WriteLine(calculations.Div(23, 4));
            Calculations<float> floatcalculations = new Calculations<float>();
            Console.WriteLine("Addition of float :{0}", floatcalculations.Add(23f, 4f));
            Console.WriteLine(floatcalculations.Sub(23f, 4f));
            Console.WriteLine(floatcalculations.Mul(23f, 4f));
            Console.WriteLine(floatcalculations.Div(23f, 4f));
            Calculations<double> doublecalculator = new Calculations<double>();
            Console.WriteLine("Addition of double :{0}", doublecalculator.Add(23, 4));
            Console.WriteLine(doublecalculator.Sub(23, 4));
            Console.WriteLine(doublecalculator.Mul(23, 4));
            Console.WriteLine(doublecalculator.Div(23, 4));

        }
    }
}

