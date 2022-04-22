using System;         //EMPLOYEE (*Salary*) SALARYTYPE, BONUS CALC. HERE

namespace MyWorkApplication
{
    class EmployeeSalaried : Employee //streamwriter to write to file, Salary employee class
    {
        public void WriteEmployeeToFile(StreamWriter sw)
        {
            // TODO: Write first name to file
            sw.WriteLine(GetFirstName());
            // TODO: Write last name to file

        }

        //SO I'd say a good TODO: add a bonus structure to calculate for this employee 


    } //end salary employee class 
  
} //end main 