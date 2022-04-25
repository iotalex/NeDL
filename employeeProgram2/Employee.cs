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
            
            RName = " ";
            lastName = " ";
            firstName = " "; 
            employeeType = ' '; //char,  H or S 
        }
        public Employee(string newLastName, string newFirstName, char newemployeeType)//default constructor 
        {
            lastName = newLastName;
            firstName = newFirstName; 
            employeeType = newemployeeType;
            RName = null; //still working other part
        }
        private string RName;  //still working on other part         

        public virtual string GetName()
        {
            return RName; //this was added, can delete if not needed, working on first part yet
        }
        public virtual double GetBonus()
        {
            return 0.0; 
        }
       
        public override string ToString()
        {
            return "Employee: " + lastName + ", " + firstName + " | " + employeeType; //delete "GetBonus() here; 4-25-22
        }
        

    }//end class employee

}//end name space
