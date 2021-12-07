using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14_var2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat catty = new Cat();
            Dog doggy = new Dog();
            catty.ShowInfo();
            doggy.ShowInfo();

            Console.ReadKey();
        }
    }

    abstract class Animal
    {
        public abstract string Name { get; set; }

        public Animal()
        {

        }

        public abstract void Say();
        public void ShowInfo()
        {
            Console.WriteLine("Имя {0}", Name);
            Say();
        }
    }
    class Cat : Animal
    {
        string catName;
        string name;

        public override string Name
        {
            get
            {
                return catName;
            }
            set
            {
                catName = "кошка";
            }
        }

        public Cat()
        {
            Name = name;
        }

        public override void Say()
        {
            Console.WriteLine("МЯУ");
        }


    }
    class Dog : Animal
    {
        string dogName;
        string name;

        public override string Name
        {
            get
            {
                return dogName;
            }
            set
            {
                dogName = "сцобака";
            }
        }

        public Dog()
        {
            Name = name;
        }


        public override void Say()
        {
            Console.WriteLine("ГАВ");

        }
    }
}

