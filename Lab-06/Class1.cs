using Lab_06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
    public class Animal
    {
        public virtual string PublicMember { get; set; }
        protected virtual string ProtectedMember { get; set; }
        private virtual string PrivateMember { get; set; }

        public const string Kingdom = "Animalia";
        public virtual string Sound { get; }
        public void Move()
        {
            Console.WriteLine("Moving...");
        }
    }
}

public class Dog : Animal
{
    public override string Sound => "Woof";
    public override void Move()
    {
        Console.WriteLine("Running like a dog...");
    }
    public void FetchBall()
    {
        Console.WriteLine("Just throw the ball and I'll fetch it!");
    }
}

public class Cat : Animal
{
    public override string Sound => "Meow";
    public static void Move()
    {
        Console.WriteLine("Walking like a cat...");
    }
    public static void ThrowOfTheTable()
    {
        Console.WriteLine("Just throw the ball and i ignore it");
    }
}
public abstract class Mammal : Animal
{
    public void ProduceMilk()
    { Console.WriteLine("Milk...."); }
}

public class Dog : Mammal, IWalkable
{
    public void Walk()
    {
        Console.WriteLine("I walk on a leash.");
    }
}
public class Dog : Mammal, Iswimmable
{
    public void Swim()
    {
        Console.WriteLine("I swim poorly...");
    }
}


public class Cat : Mammal, IWalkable
{
    public void Walk()
    {
        Console.WriteLine("I like walking on furniture and tables");
    }
}

public class Salmon : Animal
{
    public override string Sound => "Blup";
    public static void Move()
    {
        Console.WriteLine("I can Swim ");
    }
  
}