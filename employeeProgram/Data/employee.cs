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
            public string GetTypeBonus
            {get; set;}

            public Employee()
            {
                FirstName = null;
                LastName = null;
                EmployeeSalaryType = null;
                GetTypeBonus = null; 

            }
            public Employee(string newFirstName, string newLastName, string newEmployeeSalaryType, string newGetBonus)
            {
                FirstName = newFirstName;
                LastName = newLastName;
                EmployeeSalaryType = newEmployeeSalaryType;
                GetTypeBonus = newGetBonus;
            }
            public string GetContactInfo()
            {
                return $"First: {FirstName}, {LastName}";  //contact string info 
            }
            public string GetSalaryInfo()
            {
                return $"Salary type: {EmployeeSalaryType}, + Bonus: {GetTypeBonus}"; //bonus type string info 
            }

                 public string GetFirstName() 
                 { return FirstName; }//first inherit class to employeeHourly.cs file 

public virtual void WriteDataToConsole()
{
    // Write nothing here
}

public void WriteEmployeeDataToConsole() 
{
        // TODO: Write title to console
    
    // TODO: Write first name to console
    Console.WriteLine(FirstName);
    // TODO: Write last name to console
    Console.WriteLine(LastName); 
}
        }// end class employee
 
    } //end main 