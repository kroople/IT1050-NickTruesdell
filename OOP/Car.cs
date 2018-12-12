using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Car
    {
        private string Make;
        private string Model;
        private int Year;
        private int Speed;

    }
    public Car(string make, string model, int year, int speed)
    {
        this.Make = make;
        this.Model = model;
        this.Year = year;
        this.Speed = speed;
    }

    public Car(string make, string model, int year)
    {
        this.Make = make;
        this.Model = model;
        this.Year = year;
        
    }
    

    public void SpeedUp()
    {
        this.Speed++;
    }

    public void SlowDown()
    {
        this.Speed - 10; 
        
        // I cannot figure this out!!!! I also do not get why I am getting errors for all of my properties and methods...
    }

    public void Display()
    {
        Console.WriteLine(Year + " " + Make + " " + Model + " is going " + Speed + " MPH.");
    }
}
