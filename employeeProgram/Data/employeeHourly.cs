using System;         //EMPLOYEE TEIR, LASTNAME,FIRSTNAME, SALARYTYPE

namespace MyWorkApplication
{
     class EmployeeHourly : Employee //appears to work, but avoid static void Main(string[] args)  
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