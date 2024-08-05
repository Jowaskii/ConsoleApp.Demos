// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a letter grade");
Console.WriteLine("A,B,C,D,F");
char letterGrade = Convert.ToChar(Console.ReadLine()); 

/*
 * A - 95% -> 100%
 * B - 75% -> 94%
 * C - 65% -> 74%
 * D - 55% -> 64%
 * F - 0% -> 54%
 */

switch (letterGrade) {
    case 'A':
        Console.WriteLine("95% - 100%");
    break;

    case 'B':
        Console.WriteLine("75% - 94%");
    break;

    case 'C':
        Console.WriteLine("65% - 74%");
    break;

    case 'D':
        Console.WriteLine("55% - 64%");
    break;

    case 'F':
        Console.WriteLine("0% - 54%");
    break;

    default:
        Console.WriteLine("invalid entry");
    break;
}


