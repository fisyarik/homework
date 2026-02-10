using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Person { }//1 задание
    class Student : Person { }

    class Animal { }//2 задание
    class Cat : Animal { }
    class Dog : Animal { }

    class Entity { }//3 задание
    class Product : Entity { }

    class Dishes { }//4 задание
    class Cup : Dishes { }

    class Entity2 { }//5 задание
    class Staff : Entity2 { }
    class Manager : Staff { }

    class Animal2//6 задание
    {
        protected int age;
    }
    class Predator : Animal2
    {
        public void SetAge(int value) { age = value; }
        public int GetAge() { return age; }
    }

    class Transport//7 задание
    {
        protected string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
    class SpaceShuttle : Transport
    {
        public void DisplayInfo()
        {
            Console.WriteLine("дерижабль: " + name);
        }
    }

    class Program
    {
        static void Main()
        {
            Predator predator = new Predator();//6 задание
            predator.SetAge(5);
            Console.WriteLine(predator.GetAge());

            SpaceShuttle shuttle = new SpaceShuttle();//7 задание
            shuttle.Name = "Enterprise";
            shuttle.DisplayInfo();
        }
    }

}
