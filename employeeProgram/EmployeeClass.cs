using System;

namespace MyWorkApplication
{
  class Employee  // Base class (parent object) 
  {
    string lastName = "Smith";

    static void Main(string[] args)      
       // public virtual void hourlyRate()
    {
      Employee myObj1 = new Employee();
    

    
      Console.WriteLine("Employee last name: " + myObj1.lastName);
      
      
     

       //employee type method
      


    //first name
    //Employee type
    //hourly rate or salary 
  


    }

    /*
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
      */
    /*  
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
      }*/
       

  }//end class employee


}//end main 