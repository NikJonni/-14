using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Шелбик";
            Cat Shelby = new Cat(name);
            Shelby.ShowInfo(name);
            Console.ReadKey();
        }
    }
    abstract class Animal
    {
        public abstract string Name { get; set; }
        public Animal(string name) 
        {
            Name = name;
        }
        public abstract void Say();
        public void  ShowInfo(string Name)
        {
            Console.Write("{0}-", Name);
            Say();
        }
    }
    class Cat : Animal
    {
        string name;

        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Cat(string name):base(name)
        {
            Name = name;
        }
        public override void Say()
        {
            Console.WriteLine("Мяяуууу");
        }
    }
    class Dog : Animal
    {
        string name;
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }      
        }
        public Dog (string name) : base(name)
        {
            Name = name;
        }
        public override void Say()
        {
            Console.WriteLine("Гав");
        }
    }
}
