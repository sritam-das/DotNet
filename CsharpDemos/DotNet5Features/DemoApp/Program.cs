/*using DemoApp;
using System;

Person personObj = new() { Name="John Smith",Age=30};

Console.WriteLine($"{personObj.Name}'s " +
    $"age is {personObj.Age}");*/

/*Shape Check(bool b) => b ? new Square() : new Circle();
System.Console.WriteLine(Check(false));
public class Shape { }
public class Square : Shape { }
public class Circle : Shape { }*/

/*public class Program
{
    public static void Main()
    {
        var toyFactory = new HorseFactory();
        var horse = toyFactory.Create("black beauty");
        System.Console.WriteLine(horse.Name);
    }
}
class ToyFactory
{
    public virtual Toy Create(string name) 
        => new Toy();
}
class HorseFactory:ToyFactory
{
    public override Horse Create(string name) 
        => new Horse() { Name = name };
}
public class Toy { }
public class Horse:Toy { public string Name 
    { get; set; } }*/

/*static string LifeStagesAtAge1(int age)
{
    if (age < 2) return "Infant";
    if (age < 4) return "Toddler";
    if (age < 6) return "Early Childhood";
    if (age < 12) return "Middle Childhood";
    if (age < 20) return "Adolscent";
     return "Adult";
}

static string LifeStagesAtAge(int age) => age switch
{
    < 2 => "Infant",
    < 4 => "Toddler",
    < 6 => "Early Childhood",
    < 12 => "Middle Childhood",
    < 20 => "Adolscent",
    _ => "Adult"
};

System.Console.WriteLine(LifeStagesAtAge(20));
*/

var person1 = new Person { Name = "Mary", Age = 30 };
var person2 = person1 with { Age = 32 };
var person3= new Person { Name = "Mary", Age = 30 };

System.Console.WriteLine("Person1=Person2:"+person1.Equals(person2));
System.Console.WriteLine("Person1=Person3:"+person1.Equals(person3));

public record Employee(int Id, string Name,int Age,string City);


public record Person
{
    public string Name { get; init; }
    public int Age { get; init; }
}

