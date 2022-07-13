using System;

namespace AlecExample
{
    class HourlyEmployee : Employee
    {
       
        public double hourlyRate
            {get; set;}

        public HourlyEmployee() : base()  //hourly constructor 
        {
            hourlyRate = 0.0;
        }
        public HourlyEmployee(string newLastName, string newFirstName, char newEmployeeType, double newHourlyRate) : base(newLastName, newFirstName, newEmployeeType)// constructor 
        {
            hourlyRate = newHourlyRate;
        }

        public override double GetBonus()
        {
            return hourlyRate * 80; 
        }

        public override string ToString()
        {
            return (base.ToString() + "  |  Hourly rate: " + hourlyRate + " | " + GetBonus()); //call bonus function which will return the bonus 
        }
        

    }//end class hourlyEmployee

}//end name space
