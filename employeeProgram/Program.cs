using System;

namespace MyWorkApplication
{
  class Employee  // Base class (parent object) 
  {
    public virtual void hourlyRate()
    {
      Console.WriteLine("These are the pay types: ");
    //last name
    
    //first name
    //Employee type
    //hourly rate or salary 




    }

    
  }

  class HourlyEmployee : Employee  // Derived class (child object) 
  {
    public override void hourlyRate()
    {
      Console.WriteLine("$35.50 hr" + " " );
    }
  }

  class SalaryEmployee : Employee  // Derived class (child object) 
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
      Employee myHourly = new HourlyEmployee();  // Create a Hourly rate object
      Employee mySalary = new SalaryEmployee(); //Create a salary rate object 
      
      myEmployee.hourlyRate();
      myHourly.hourlyRate();
      mySalary.hourlyRate();
      //myPig.animalSound();
      //myDog.animalSound();
    }
  }
}