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
                    Console.WriteLine(anEmployee);
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

