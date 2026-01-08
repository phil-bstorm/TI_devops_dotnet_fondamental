// See https://aka.ms/new-console-template for more information
using Demo6_Structure.Models;

Console.WriteLine("Hello, World!");

Car c1;
c1.Brand = "Mazda";
c1.Model = "MX-5";
c1.Color = "Red";
c1.Power = 121;

Car c2 = new Car("Toyota", "Aygo", "Red", 90);
Car c3 = new Car(color:"Red", model:"Aygo",  power:90, brand:"Toyota");

Console.WriteLine($"{c1.Brand}, {c1.Model}");
c1.FaitDuBruit();
Console.WriteLine(Exemple());

string Exemple()
{
    return "Je suis un exemple.";
}