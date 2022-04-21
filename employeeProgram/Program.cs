using System;

namespace MyWorkApplication
{
  class Employee  // Base class (parent) 
  {
    public virtual void hourlyRate()
    {
      Console.WriteLine("These are the pay types: ");
    }
  }

  class Hourly : Employee  // Derived class (child) 
  {
    public override void hourlyRate()
    {
      Console.WriteLine("$35.50 hr");
    }
  }

  class Salary : Employee  // Derived class (child) 
  {
    public override void hourlyRate()
    {
      Console.WriteLine("$65k a year");
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Employee myEmployee = new Employee();  // Create an Employee object
      Employee myHourly = new Hourly();  // Create a Hourly rate object
      Employee mySalary = new Salary(); //Create a salary rate object 
      
      myEmployee.hourlyRate();
      myHourly.hourlyRate();
      mySalary.hourlyRate();
      //myPig.animalSound();
      //myDog.animalSound();
    }
  }
}