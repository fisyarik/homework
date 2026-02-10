using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace encapcsulation
{
    class Student//1 адание
    {
        public string name;
    }
    class Car//2 задание  
    {
        public int year;
    }
    class Point//3 задание
    {
        public int x;
    }
    class Person//4 задание
    {
        public int age;
        public void Print()
        {
            Console.WriteLine($"Возраст: {age}");
        }
    }
    class Table//5 задание
    {
        public int rows, cols;

        public void Display()
        {
            Console.WriteLine($"Строки: {rows}, Столбцы: {cols}");
        }
    }
    class Manager//6 задание
    {
        public int age;
        public string name;
        public void GetAge()
        {
            Console.WriteLine($"Возраст: {age}");
        }
        public void GetName()
        {
            Console.WriteLine($"Имя: {name}");
        }

    }
    class Point3D//7 задание
    { 
        public int x, y, z;
        public void Show()
        {
            Console.WriteLine($"X:{x}, Y:{y}, Z:{z}");
        }
    }
    class Shop//8 задание
    {
        public string name, newname;
        public void GetName()
        {
            Console.WriteLine($"Название магазина: {name}");
        }
        public void SetName()
        {
            name = newname;
            Console.WriteLine($"Новое название магазина: {name}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();//4 задание
            person1.age = 11;
            person1.Print();

            Table tab1 = new Table();//5 Задание
            tab1.rows = 12;
            tab1.cols = 21;
            tab1.Display();

            Manager manager1 = new Manager();//6 задание
            manager1.age = 34;
            manager1.name = "иван";
            manager1.GetAge();
            manager1.GetName();

            Point3D kek = new Point3D();//7 Задание
            kek.x = 1;
            kek.y = 2;
            kek.z = 3;
            kek.Show();

            Shop shop1 = new Shop();//8 задание
            shop1.name = "Магнолия";
            shop1.newname = "Гвоздика";
            shop1.GetName();
            shop1.SetName();
        }
    }
}
