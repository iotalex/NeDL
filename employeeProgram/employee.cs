using System;

namespace MyWorkApplication
    {


    //use inhertance here to move name/salarytype/ into the child classes 
    
        

        class Employee  // Base class (parent object) 
        {
        
       
            /*
        public string RName
        {get; set;}

        public Employee()
        {
           getLastName = null; 
        }

        public string GetContactInfo()
        {
            return "Last name: " + getLastName; 
        }
        */

            string getLastName = "Smith";
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
            Console.WriteLine("Emplyee name: " + lastName.getLastName + ", " + firstName.getFirstName); //main object class employee 
            Console.WriteLine("Reinbursement type: " + typeSalary.getTypeSalary); //employeeHourly.cs & employeeSalary.cs
            Console.WriteLine("Bonus: " + typeBonus.getTypeBonus);
            
            }
        }
        
        
        

    //end class employee

    
    }