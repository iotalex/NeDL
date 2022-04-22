using System;

namespace MyWorkApplication
    {


    //use inhertance here to move name/salarytype/ into the child classes 
    
        

        class Employee  // Base class (parent object) 
        {                
            public string FirstName
            {get; set;}
            public string LastName
            {get; set;}
            public string GetSalaryType
            {get; set;}
            public string GetTypeBonus
            {get; set;}

            public Employee()
            {
                FirstName = null;
                LastName = null;
                GetSalaryType = null;
                GetTypeBonus = null; 

            }
            public Employee (string newFirstName, string newLastName, string newGetSalaryType, string newGetBonus)
            {
                FirstName = newFirstName;
                LastName = newLastName;
                GetSalaryType = newGetSalaryType;
                GetTypeBonus = newGetBonus;
            }
            public string GetContactInfo()
            {
                return $"First: {FirstName}, {LastName}";  //contact string info 
            }
            public string GetSalaryInfo()
            {
                return $"Salary type: {GetSalaryType}, + Bonus: {GetTypeBonus}"; //bonus type string info 
            }

                 public string GetFirstName() 
                 { return FirstName; }//first inherit class to employeeHourly.cs file 

        }// end class employee
 
    } //end main 