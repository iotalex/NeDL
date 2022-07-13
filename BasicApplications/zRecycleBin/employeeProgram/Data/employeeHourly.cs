using System;         //EMPLOYEE TEIR, LASTNAME,FIRSTNAME, SALARYTYPE

namespace MyWorkApplication
{
     public class EmployeeHourly : Employee //streamwriter to write to file, Hourly employee class
        {
           public int HourlyRate { get; set; }
          public EmployeeHourly(string title, string firstName, string lastName, string employeeType, int rate)
            :base(title, firstName, lastName, employeeType)
          {
            HourlyRate = rate; 
          }
         
//THis is like option "C" which is write a name; need to focus on "R" = print a list of all employees and salary 
          
         public override void WriteDataToConsole()
         {
            WriteEmployeeDataToConsole();
            // TODO: Write hourly rate to console
         }
         
         public void WriteEmployeeToFile(StreamWriter sw)
         {
         //TODO write an array to store names?     
         string name = " ";//store an employee name to write later 
         

            // TODO: Write first name to file
  //          sw.WriteLine(GetFirstName());
            // TODO: Write last name to file
         }
         
         
            
            
 
    
     
        }//end class employeeHourly
    
    
}//end main 