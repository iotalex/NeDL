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
            string getTypeSalary = "Salary || hourly?";

            string getTypeBonus = "Calcuated bonus: goes here $$$";
        static void Main(string[] args)      
            // public virtual void hourlyRate()
            {
            Employee lastName = new Employee(); //last name object
            Employee firstName = new Employee(); //first name object 
            Employee typeSalary = new Employee(); //salary type object
            Employee typeBonus = new Employee(); //hourly type object 
            
            //outputs the lines using objects
            Console.WriteLine("Reinbursement hourly: " + typeBonus.getTypeBonus);
            Console.WriteLine("Emplyee name: " + lastName.getLastName + ", " + firstName.getFirstName);
            Console.WriteLine("Reinbursement type: " + typeSalary.getTypeSalary);
            Console.WriteLine("Bonus: " + typeBonus.getTypeBonus); 
            
            }
        }
        
        
        

    //end class employee

    
    }