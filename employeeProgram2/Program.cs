using System;

namespace EmployeeProgram
{
    class Program
    {
        static void Main (string[] args)
        {
            bool userChoice;
            string userChoiceString;

            List<Employee> employeeList = new List<Employee>();//array of employees 

            Employee newEmployee = new Employee("Knox", "Jimmy", 'H'); //this is creating the employee object
            employeeList.Add(newEmployee);
            Employee newEmployee2 = new Employee("Fox", "Ryan", 'H');
            employeeList.Add(newEmployee2);
            
            //create an hourly employee object 
            HourlyEmployee newHourlyEmployee = new HourlyEmployee("Smithson", "Will",'H', 15.25);//creating Hourly employee object
            employeeList.Add(newHourlyEmployee);
            HourlyEmployee newHourlyEmployee2 = new HourlyEmployee("Jones", "Matt",'H', 25.25);
            employeeList.Add(newHourlyEmployee2);
           
            //create an hourly employee object 
            SalaryEmployee newSalaryEmployee = new SalaryEmployee("Fonda", "Henry",'S', 85000);//creating Salary employee object 
            employeeList.Add(newSalaryEmployee);
            SalaryEmployee newSalaryEmployee2 = new SalaryEmployee("Arnoldson", "Blake",'S', 125000);
            employeeList.Add(newSalaryEmployee2);         
  
            foreach(Employee anEmployee in employeeList)//prints the "list" above
                {
                    Console.WriteLine(employeeList);
                }//start CRUD here

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
            
                    //print each employee to test the property gets and the toString
                    foreach (Employee anEmployee in employeeList)
                    {
                        
                            Console.WriteLine(anEmployee);
                    }

                    }//end using "R"
/*

foreach(Employee anEmployee in employeeList)
                {
                    Console.WriteLine(employeeList);

                }

*/

                    //   TODO: If the option is is C or c adds an employee including their calculated bonus 
                if (userChoiceString=="C" || userChoiceString=="c")
                {
                    //TODO: get a last name
                    Console.WriteLine("Plese enter last name to add: ");
                    //not going to be using null ; 4-27-22
                    string newLastName = Console.ReadLine();
                    Console.WriteLine("Plese enter first name to add: ");
                    //TODO: get a first name from the user
                    string newFirstName = Console.ReadLine();
                    //TODO: Get the type from the user                                     
                    Console.WriteLine("Plese enter employee type to add (S or H): ");
                    char newEmployeeType = Convert.ToChar(Console.ReadLine());//allows us to use 'Char' 

                    switch(newEmployeeType)
                    {
                        case 'H': //If the type is an 'H' or 'h'
                        case 'h':
                            Console.WriteLine("Please enter hourly salary: ");
                            double newEmployeeHourly = Convert.ToDouble(Console.ReadLine()); //TODO: get total hour salary from user
                            //Creates an Hourly Employee object with lastName, firstName, type, total hourly Salary 
                            employeeList.Add(new HourlyEmployee(newLastName, newFirstName, newEmployeeType, newEmployeeHourly));
                            Console.WriteLine("Hourly employee added. Printing new list.");
                        break;
                        
                        case 'S'://IF the type is 'Salary' or 'salary' 
                        case 's':
                            Console.WriteLine("Please enter annual salary: ");
                            double newEmployeeSalary = Convert.ToDouble(Console.ReadLine());// get's annual salary from user
                            //Creates a salary employee object with lastName, firstName, type, annual Salary
                            employeeList.Add(new SalaryEmployee(newLastName, newFirstName, newEmployeeType, newEmployeeSalary));
                            Console.WriteLine("Salary employee added. Printing new list.");
                        break;
                        default:
                            Console.WriteLine("Ope, wrong option and you only get one change here! Nothing was added."); 
                        break;
                    }
                    // print the list again
                    foreach (Employee anEmployee in employeeList)
                            Console.WriteLine(anEmployee);
                    

                    
                    

                
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





/*
for (int index = 0; index < employeeArray.Length; index++) //starts line 2 then loops every other line  
                {
                    employeeArray[index] = new SalaryEmployee();
                }
            for (int index = -1; index < employeeArray.Length; index++) 
                {   
                    while(index <index++)//For while loop every other line 
                    {
                        Console.WriteLine(employeeArray);
                        index++;//starts line 1, then loops every other line
                    }
                    employeeArray[index] = new HourlyEmployee(); //prints Salary employees and types 
                }

                */


/*
//prompt user to enter new employee FRIST name 
                    
                    string newEmployeeFirstName;
                    Console.WriteLine("Enter employee first name: ");
                    newEmployeeFirstName = Console.ReadLine(); //gets the employee firstname
                    //prompt user to enter new employee LAST name 
                    string newEmployeeLastName;
                    Console.WriteLine("Enter employee last name: ");
                    newEmployeeLastName = Console.ReadLine(); //gets the employee firstname

                    int index = 0;
                    bool found = false;

                    do{
                         if(newEmployeeLastNameArray[index] ==null)//if something is not found
                         {
                            found = true; //we found an open array element 
                         }
                         else
                         {
                            index++;//we didn't find an open element, so add 1
                         }

                      }
                    while (found ==false);

                    newEmployeeFirstNameArray [index] = newEmployeeFirstName;               
                    newEmployeeLastNameArray [index] = newEmployeeLastName;  

                    */



/*           string newEmployeeFirstName;
                    string newEmployeeLastName;
                    //prompt user to enter new employee name 
                    Console.WriteLine("Enter employee first name: ");
                    newEmployeeFirstName = Console.ReadLine(); //gets the employee firstname
                    Console.WriteLine("Enter employee last name: ");
                    newEmployeeLastName = Console.ReadLine(); //gets the employee firstname

                    int index = 0;
                    bool found = false;

                    do{
                         if(newEmployeeFirstNameArray[index] ==null)//if something is not found
                         {
                            found = true; //we found an open array element 
                         }
                         else
                         {
                            index++;//we didn't find an open element, so add 1
                         } 
                      }
                    while (found ==false);

                    newEmployeeFirstNameArray [index] = newEmployeeFirstName;               
                    newEmployeeLastNameArray [index] = newEmployeeLastName;   */






















//////*this can go where "C" was if all else fails***
/*     
            */


       /*        


        old old            
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




/*   old readline, may re-use
 {
                    for(int index = 0; index < newEmployeeFirstNameArray.Length; index++)
                      {
                         if(!(newEmployeeFirstNameArray[index] == null))
                         {
                          Console.WriteLine(newEmployeeFirstNameArray[index] + " " + newEmployeeLastNameArray[index]);
                          //Console.WriteLine(newEmployeeLastNameArray[index]);
                         }

                         
                      }


*/


  