// See https://aka.ms/new-console-template for more information

//Welcome Message
Console.WriteLine("************>Welcome to the sample calculator<************");
Console.WriteLine();

//Show Calculator Options
Console.WriteLine("Please Select an operation");
Console.WriteLine("1. Addition (+)");
Console.WriteLine("2. Subtraction (-)");
Console.WriteLine("3. Division (/) ");
Console.WriteLine("4. Multiplication (*)");
int Operation = Convert.ToInt32(Console.ReadLine());

//Prompt user for input
Console.Write("Please Enter First Number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please Enter Second Number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int ans = 0;

//Decide which operation is needed based on selected option
switch (Operation) {
    case 1:
        ans = num1 + num2;
        Console.Write($"{num1} + {num2} = ");
    break;

    case 2:
        ans = num1 - num2;
        Console.Write($"{num1} - {num2} = ");
    break;

    case 3:
        ans = num1 / num2;
        Console.Write($"{num1} / {num2} = ");
    break;

    case 4:
        ans = num1 * num2;
        Console.Write($"{num1} * {num2} = ");
    break;

    default:
        Console.WriteLine("invalid input.......");
    break;
}
//Print output
Console.WriteLine(ans);
