using System;

namespace EmployeeProgram
{
    class Employee
    {
        public string lastName
            {get; set;}
        public string firstName
            {get; set;}
        public char employeeType
            {get; set;}
        
       
        public Employee()//default constructor 
        {
            lastName = " ";
            firstName = " "; 
            employeeType = ' '; //char,  H or S 
        }
        public Employee(string newLastName, string newFirstName, char newemployeeType)//default constructor 
        {
            lastName = newLastName;
            firstName = newFirstName; 
            employeeType = newemployeeType;
        }

        public virtual double GetBonus()
        {
            return 0.0; 
        }

        public override string ToString()
        {
            return ("EmployeeYY: " + lastName + ", " + firstName + " | " + employeeType + GetBonus());
        }
        

    }//end class employee

}//end name space
