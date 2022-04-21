using System;

namespace MyWorkApplication
  {
    class Program
    {
      class Employee  // Base class (parent object) 
      {
        string getLastName = "Smith";
        char lastName; //declares type
        string getFirstName = "John";
        char firstName;//declares type 
        string getTypeSalary = "Salary";
      static void Main(string[] args)      
          // public virtual void hourlyRate()
        {
          Employee lastName = new Employee(); //last name object 
          Employee firstName = new Employee(); //first name object 
          Employee typeSalary = new Employee(); //salary type object 
        
          //outputs the lines using objects
          Console.WriteLine("Employee's Last name: " + lastName.getLastName);
          Console.WriteLine("First name: " + firstName.getFirstName);
          Console.WriteLine("Reinbursement type: " + typeSalary.getTypeSalary);
        }
      }
 
    }//end class
}//end main 




    