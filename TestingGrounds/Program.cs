// See https://aka.ms/new-console-template for more information
using System;

int a = 100;
Console.WriteLine($"Original value of a: {a}");
int b = a;
Console.WriteLine($"Original value of b: {b}");
b += 100;
Console.WriteLine($"Value of 'a' after modifying b: {a}");
Console.WriteLine($"Value of 'b' after modifying b: {b}");

Console.WriteLine("\n\n");

var car = new Car();
car.Name = "Honda Civic 2015";
car.GearType = "Manual";
Console.WriteLine($"This is your current config: {car.Name} with gear type {car.GearType}");
UpgradeGearType(car);
Console.WriteLine($"You have upgraded your car {car.Name} with gear type {car.GearType}");

void UpgradeGearType(Car car)
{
    car.GearType = "Automatic";
}

class Car
{
    public string Name { get; set; }
    public string GearType { get; set; }
}