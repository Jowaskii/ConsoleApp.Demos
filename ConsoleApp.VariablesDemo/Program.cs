// See https://aka.ms/new-console-template for more information

//Different Datatypes
/*
    text - string
    integers - int
    decimal - double, float, decimal
    logical - bool
 */

string name = "Jerome Charles";

Console.WriteLine(name);
Console.WriteLine("I am " + name); // String Concatenation
Console.WriteLine($"They call me {name}");// String Interpolation
Console.WriteLine("I was given the name {0}", name);// Formatted String

int age = 26;
int retirementYearsLeft = 39;
int retirementAge = age + retirementYearsLeft;

Console.WriteLine("My age is: " + age);
Console.WriteLine("My retirement age is: " + retirementAge);

bool isRetired = false;

Console.WriteLine("Am I retired? " + isRetired);

