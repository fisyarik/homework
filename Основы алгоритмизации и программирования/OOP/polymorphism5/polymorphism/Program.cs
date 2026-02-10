using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Strategy//1 задание
    {
        public virtual void Display() => Console.WriteLine("Strategy");
    }

    class Weather//2 задание
    {
        public virtual void Show() => Console.WriteLine("My Weather");
    }

    class ConservativeStrategy : Strategy//3 задание
    {
        public override void Display() => Console.WriteLine("Conservative Strategy");
    }

    class Animal//4 задание
    {
        private string type;
        public Animal() { type = "My Type"; }
        public virtual void Print() => Console.WriteLine(type);
    }

    class Cat : Animal
    {
        private int age;
        public Cat() { age = 5; }
        public override void Print() => Console.WriteLine(age);
    }

    abstract class Entity//5 задание
    {
        public abstract void Display();
    }

    class Product : Entity//6 задание
    {
        public override void Display() => Console.WriteLine("My Product");
    }

    // 5.7
    interface IPrintable
    {
        void Display();
    }

    class ConsolePrinting : IPrintable
    {
        public void Display() => Console.WriteLine("My Console");
    }

    class Program
    {
        static void Main()
        {
            Weather weather = new Weather();//2 задание
            weather.Show();

            Strategy strategy = new ConservativeStrategy();//3 задание
            strategy.Display();

            Animal animal = new Animal();//4 задание
            Cat cat = new Cat();
            animal.Print();
            cat.Print();

            Product product = new Product();//5 задание
            product.Display();

            ConsolePrinting printer = new ConsolePrinting();//7 задание
            printer.Display();
        }
    }
}
