using System;

namespace AlecExample
{
    class SalaryEmployee : Employee
    {
        public double salaryRate
            {get; set;}

        public SalaryEmployee() : base()//default constructor 
        {
            salaryRate = 0.0; 
        }
        public SalaryEmployee(string newLastName, string newFirstName, char newEmployeeType, double newSalaryRate): base(newLastName, newFirstName, newEmployeeType)  //default constructor 
        {
            salaryRate = newSalaryRate; 
        }

        public override double GetBonus()//power of polymorphism 
        {
            return salaryRate * .10; 
        }

        public override string ToString()
        {
            return (base.ToString() + "  |  Annual salary: " + salaryRate + " | " + GetBonus());
        }
        

    }//end class employee

}//end name space
