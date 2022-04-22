using System;         //EMPLOYEE TEIR, LASTNAME,FIRSTNAME, SALARYTYPE

namespace MyWorkApplication
{
     class EmployeeHourly : Employee //streamwriter to write to file, Hourly employee class
        {
           private string RName;   
          

   public void WriteEmployeeToFile(StreamWriter sw)
   {
      // TODO: Write first name to file
      sw.WriteLine(GetFirstName());
      // TODO: Write last name to file

   }
    
     
        }//end class employeeHourly
    
    
}//end main 