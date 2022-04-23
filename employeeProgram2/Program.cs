using System;

namespace AlecExample
{
    class Program
    {
        static void Main (string[] args)
        {
            //create an employee object 
            Employee newEmployee = new Employee("Smith", "John", 'H'); //this is creating the employee object
            Employee newEmployee2 = new Employee("Cox", "Ryan", 'H');
            //print the employee object
            Console.WriteLine(newEmployee);
            Console.WriteLine(newEmployee2);
            //create an hourly employee object 
            HourlyEmployee newHourlyEmployee = new HourlyEmployee("Smithson", "Will",'H', 15.25);
            HourlyEmployee newHourlyEmployee2 = new HourlyEmployee("Jones", "Matt",'H', 25.25);
              //print the new HoulyEmployee object
            Console.WriteLine(newHourlyEmployee);
            Console.WriteLine(newHourlyEmployee2);
            //create an hourly employee object 
            SalaryEmployee newSalaryEmployee = new SalaryEmployee("Fonda", "Henry",'S', 45000);
            SalaryEmployee newSalaryEmployee2 = new SalaryEmployee("Johnson", "Blake",'S', 125000);
              //print the new HoulyEmployee object
            Console.WriteLine(newSalaryEmployee);
            Console.WriteLine(newSalaryEmployee2);
        

            Employee[] employeeArray = new Employee[25]; 
            employeeArray[1] = newEmployee; //main object
            employeeArray[2] = newEmployee2;
            employeeArray[3] = newHourlyEmployee;//main object, with child class
            employeeArray[4] = newHourlyEmployee2;
            employeeArray[5] = newSalaryEmployee;
            employeeArray[6] = newSalaryEmployee2;
            Console.WriteLine("printing the array: ");
            for(int index = 0; index < employeeArray.Length; index++)
            {
                if(!(employeeArray[index]==null))
                {
                    Console.WriteLine(employeeArray[index]);
                }
            }

        // start your CRUD here: 


        } //end main 




    }//end program 


}//end name space
