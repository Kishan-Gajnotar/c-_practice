using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Vehicle  // base class (parent) 
{
    public string brand = "Ford";  // Vehicle field
    public void honk()             // Vehicle method 
    {
        Console.WriteLine("Tuut, tuut!");
    }
}

class Car : Vehicle
{
    // Class members

    public string color;        // field
    public int maxSpeed = 200;          // field

    public string model;
    public int year;
    public string modelName = "Mustang";

    // Create a class constructor with multiple parametersCw    
    public Car()
    {
        color = "red";
        Console.WriteLine("Constructor called");
    }
    public Car(string modelName, string modelColor, int modelYear)
    {
        model = modelName;
        color = modelColor;
        year = modelYear;
    }
    public void fullThrottle()   // method
    {
        Console.WriteLine("The car is going as fast as it can!");
    }
}

