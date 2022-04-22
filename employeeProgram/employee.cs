using System;

namespace MyWorkApplication
    {


    //use inhertance here to move name/salarytype/ into the child classes 
    
        class Employee  // Base class (parent object) 
        {
            string getLastName = "Smith";
            char lastName; //declares type?
            string getFirstName = "John";
            char firstName;//declares type?
            string getTypeSalary = "Salary";

            string getTypeHourly = "Hourly";
        static void Main(string[] args)      
            // public virtual void hourlyRate()
            {
            Employee lastName = new Employee(); //last name object
            Employee firstName = new Employee(); //first name object 
            Employee typeSalary = new Employee(); //salary type object
            Employee typeHourly = new Employee(); //hourly type object 
            
            //outputs the lines using objects
            Console.WriteLine("Employee's Last name: " + lastName.getLastName);
            Console.WriteLine("First name: " + firstName.getFirstName);
            Console.WriteLine("Reinbursement salary: " + typeSalary.getTypeSalary);
            Console.WriteLine("Reinbursement hourly: " + typeHourly.getTypeHourly);
            }
        }
        
        
        

    //end class employee

    
    }