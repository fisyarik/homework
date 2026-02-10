using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructors
{    
        class Student { public Student() { } } //1 задание

        class Child { public Child() { } }//2 задание

        class Car//3 - 4 задание
        {
            public int year;
            public string name;
            public string color;

            public Car(int year) { this.year = year; }//3 задание
            public Car(string name, string color) { this.name = name; this.color = color; }//4 адание
        }

        class Product//5 задание
        {
            protected string name;
            public Product(string name) { this.name = name; }
            public Product(Product other) { this.name = other.name; }
        }

        class Person//6 задание
        {
            private int age;
            public Person() { age = 18; }
            public void Print() { Console.WriteLine(age); }
        }

        class Manager//7 задание
        {
            private int age;
            private string name;
            public Manager(int age, string name) { this.age = age; this.name = name; }
            public Manager(Manager other) { this.age = other.age; this.name = other.name; }
        }

        class Program
        {
            static void Main()
            {
                Child child1 = new Child();//2 задание

                Car car = new Car(2025);//3 задание

                Car lada = new Car("LADA VESTA", "black");//4 задание
                Car bmw = new Car("BMW X5", "white");

                Product p1 = new Product("первый товар");//5 задание
                Product p2 = new Product(p1);

                Person person = new Person();//6 задание
                person.Print();

                Manager manager1 = new Manager(20, "Дамир");//7 задание
                Manager manager2 = new Manager(18, "Сара");
            }
        }
    }

