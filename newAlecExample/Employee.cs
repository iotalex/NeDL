using System;

namespace AlecExample
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

        public override string ToString()
        {
            return ("Employee: " + lastName + ", " + firstName + " | " + employeeType);
        }
        

    }//end class employee

}//end name space
