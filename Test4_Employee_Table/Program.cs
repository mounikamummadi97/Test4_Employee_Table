// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Test4_Employee_Table;

DBConnection objDBConnection = new DBConnection();
objDBConnection.Method1();
NewEmployee objNewEmployee =new NewEmployee();
objNewEmployee.Employee();
objNewEmployee.DeleteEmployee();
NewEmployee2 objNewEmployee2 = new NewEmployee2();
objNewEmployee2.AddEmployee();
