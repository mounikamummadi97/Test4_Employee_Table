// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Test4_Employee_Table;
int item = 0;

Console.WriteLine("1.Welcome to Employe Database");
Console.WriteLine("2.Insert into Employe table ");
Console.WriteLine("3.Update the values of Employe table ");
Console.WriteLine("4.Delete the values of Employe table");
item=int.Parse(Console.ReadLine());
switch (item) 

{
    case 1:
        Console.WriteLine( "Database Connected Successfully");
    DBConnection objDBConnection = new DBConnection();
    objDBConnection.Method1();
        break;
    case 2:
        NewEmployee2 objNewEmployee2 = new NewEmployee2();
        objNewEmployee2.AddEmployee();
       
        break;
    case 3:
        NewEmployee objNewEmployee = new NewEmployee();
        objNewEmployee.UpadteEmployee();
       
        break;
    case 4:
        NewEmployee objNewEmployee1 = new NewEmployee();
        objNewEmployee1.DeleteEmployee();
        break;
}