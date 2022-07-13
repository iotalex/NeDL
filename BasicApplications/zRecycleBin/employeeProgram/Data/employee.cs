using System;

namespace MyWorkApplication
    {


    //use inhertance here to move name/salarytype/ into the child classes 
    
        

        public class Employee  // Base class (parent object) 
        {                
            public string FirstName
            {get; set;}
            public string LastName
            {get; set;}
            public string EmployeeSalaryType
            {get; set;}
            public string EmployeeTitle
            {get; set;}

            public Employee()
            {
                EmployeeTitle = null;
                FirstName = null;
                LastName = null;
                EmployeeSalaryType = null;
            }
            public Employee(string newFirstName, string newEmployeeTitle, string newLastName, string newEmployeeSalaryType)
            {
                EmployeeTitle = newEmployeeTitle;
                FirstName = newFirstName;
                LastName = newLastName;
                EmployeeSalaryType = newEmployeeSalaryType;
            }
           // public string GetContactInfo()
          //  {
          //      return $"First: {FirstName}, {LastName}";  //contact string info 
          //  }
          //  public string GetSalaryInfo()
            //{
              //  return $"Salary type: {EmployeeSalaryType}, + Title: {EmployeeTitle}"; //bonus type string info 
            //}

                 public string GetFirstName() 
                 { return FirstName; }//first inherit class to employeeHourly.cs file 

            public virtual void WriteDataToConsole()
            {
                // Write nothing here
            }

            public void WriteEmployeeDataToConsole()/// writes the console "R" strings 
            {
                Console.WriteLine(EmployeeTitle);
                Console.WriteLine(FirstName);
                Console.WriteLine(LastName);
                Console.WriteLine(EmployeeSalaryType);
            }

        }// end class employee
 
    } //end main 