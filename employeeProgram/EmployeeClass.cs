using System;

namespace MyWorkApplication
{
  class Employee  // Base class (parent object) 
  {
    string getLastName = "Smith";
    string getFirstName = "John";

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

    
    class HourlyEmployee : Employee  // Derived class (child object) 
      {
        
      }
    class SalaryEmployee : Employee  // Derived class (child object) 
      {
        
      }
    
       

  }//end class employee


}//end main 