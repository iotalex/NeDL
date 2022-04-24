using System;

namespace EmployeeProgram
{
    class Program
    {
        static void Main (string[] args)
        {
           
            bool userChoice;
            string userChoiceString;
//Employee[] employeeArray = new Employee[25]; 
            Employee[] enterEmployeeArray = new Employee[25]; //Declare and instantiate the array of Employee objects
            string[] newEmployeeArray = new string[25];//hold name of new employee
        //Repeat main loop 
            do
            {     
            //  TODO: Get a valid input 
                do
                {

                userChoice = false;

                Console.WriteLine("What's your pleasure?");
                Console.WriteLine("R: Print a list of all the employees inclduing their calculated bonus.");
                Console.WriteLine("C: Add an employee.");
                Console.WriteLine("Q: Quit the program.");
                
                
                    //  reference guide:   https://www.w3resource.com/csharp-exercises/file-handling/index.php#editorr
                //   TODO: Get a valid user option (valid means its on the menu)
                userChoiceString = Console.ReadLine();
                
                
                userChoice = (userChoiceString== "R" || userChoiceString == "r" ||
                              userChoiceString== "C" || userChoiceString == "c" ||
                              userChoiceString == "Q" || userChoiceString == "q");

                if(!userChoice)
                    {
                    Console.WriteLine("Please enter a valid option");
                    }

                }
                while (!userChoice);

                //   TODO: If the option is is R or r print's a list of all the employees including their calculated bonus 
                if (userChoiceString=="R" || userChoiceString=="r")
                    {
                    for (int index = 0; index < enterEmployeeArray.Length; index++)
                    {
                        enterEmployeeArray[index] = new Employee();
                        enterEmployeeArray[index] = new HourlyEmployee();
                        enterEmployeeArray[index] = new SalaryEmployee(); //prints all employees and types 
                    }

                    //print each employee to test the property gets and the toString
                    for (int index = 0; index < enterEmployeeArray.Length; index++)
                    {
                        if (!(((enterEmployeeArray[index]).ToString())==null))
                            Console.WriteLine(enterEmployeeArray[index]);
                    }

                    }//end using "L"
                    //   TODO: If the option is is C or c adds an employee including their calculated bonus 
                if (userChoiceString=="C" || userChoiceString=="c")
                    {
                     string newEmployeeName;
                    //prompt user to enter new employee name 
                    Console.WriteLine("Enter employee first name: ");
                    newEmployeeName = Console.ReadLine(); //gets the employee firstname

                    int index = 0;
                    bool found = false;

                    do{
                         if(newEmployeeArray[index] ==null)//if something is not found
                         {
                            found = true; //we found an open array element 
                         }
                         else
                         {
                            index++;//we didn't find an open element, so add 1
                         } 
                      }
                    while (found ==false);

                    newEmployeeArray[index] = newEmployeeName;                
                    
                    }
                 
            //   TODO: Else if the option is a Q or q then quit the program                
                else if (userChoiceString=="Q" || userChoiceString=="q")
                    {
                    Console.WriteLine("Goodbye, auf wiedersehen");
                    }

                }//ends the big "do"
                while(!(userChoiceString=="Q"));  
        }//ends static void

    }//ends class

}//ends name space 


//////*this can go where "C" was if all else fails***
/*     
            */



  ////************* "R" TEST DATA, you can insert if want to borrow

       /*                   
                            //create an employee object 
                    Employee newEmployee = new Employee("Knox", "Jimmy", 'H'); //this is creating the employee object
                    Employee newEmployee2 = new Employee("Fox", "Ryan", 'H');
                    
                    
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
                    SalaryEmployee newSalaryEmployee = new SalaryEmployee("Fonda", "Henry",'S', 85000);
                    SalaryEmployee newSalaryEmployee2 = new SalaryEmployee("Arnoldson", "Blake",'S', 125000);
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
                        }//start CRUD here

    */ 
    //************************END "R" test data 