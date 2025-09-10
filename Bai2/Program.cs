using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentLINQ
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>()
            {
                new Student { Id = 1, Name = "Toan", Age = 15 },
                new Student { Id = 2, Name = "Binh", Age = 17 },
                new Student { Id = 3, Name = "Anh", Age = 19 },
                new Student { Id = 4, Name = "Huy", Age = 20 },
                new Student { Id = 5, Name = "Tu", Age = 14 }
            };

            //a
            Console.WriteLine("a. Danh sách toan bo hoc sinh:");
            foreach (var s in students)
            {
                Console.WriteLine($"ID: {s.Id}, Name: {s.Name}, Age: {s.Age}");
            }

            //b
            Console.WriteLine("\nb. Hoc sinh co tuoi tu 15 den 18:");
            var tuoi1518 = students.Where(s => s.Age >= 15 && s.Age <= 18);
            foreach (var s in tuoi1518)
            {
                Console.WriteLine($"ID: {s.Id}, Name: {s.Name}, Age: {s.Age}");
            }

            //c
            Console.WriteLine("\nc. Hoc sinh co ten bat dau bang chu A:");
            var tenA = students.Where(s => s.Name.StartsWith("A"));
            foreach (var s in tenA)
            {
                Console.WriteLine($"ID: {s.Id}, Name: {s.Name}, Age: {s.Age}");
            }

            //d
            Console.WriteLine("\nd. Tong tuoi tat ca hoc sinh:");
            int tongTuoi = students.Sum(s => s.Age);
            Console.WriteLine($"Tổng tuổi = {tongTuoi}");

            //e
            Console.WriteLine("\ne. Hoc sinh co tuoi lon nhat:");
            int tuoiMax = students.Max(s => s.Age);
            var hsMax = students.Where(s => s.Age == tuoiMax);
            foreach (var s in hsMax)
            {
                Console.WriteLine($"ID: {s.Id}, Name: {s.Name}, Age: {s.Age}");
            }
            //f
            Console.WriteLine("\nf. Danh sach hoc sinh sau khi sap xep tuoi tang dan:");
            var sapxep = students.OrderBy(s => s.Age);
            foreach (var s in sapxep)
            {
                Console.WriteLine($"ID: {s.Id}, Name: {s.Name}, Age: {s.Age}");
            }
            Console.ReadLine();
        }
    }
}

