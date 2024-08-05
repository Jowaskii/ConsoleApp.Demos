// See https://aka.ms/new-console-template for more information

//Welcome Message
Console.WriteLine("************>Welcome to the sample calculator<************");
Console.WriteLine();

int choice = 0;
//Show Calculator Options 
Console.WriteLine("Please Select an operation (type -1 to exit calculator)");
Console.WriteLine("1. Addition (+)");
Console.WriteLine("2. Subtraction (-)");
Console.WriteLine("3. Division (/) ");
Console.WriteLine("4. Multiplication (*)");
Console.WriteLine("5. Fibonacci Sequence (?)");
choice = Convert.ToInt32(Console.ReadLine());

while (choice != -1) {
    //Prompt user for input
    Console.Write("Please Enter First Number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Please Enter Second Number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    int ans = 0;

    //Decide which operation is needed based on selected option
    switch (choice) {
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

        case 5: 
            for(int i = num1; i <= num2; i++) {
                ans += i;
            }
            break;

        default:
            Console.WriteLine("invalid input.......");
            break;
    }
    //Print output
    Console.WriteLine(ans);
    Console.Write("Press Enter to Continue: ");
    Console.ReadLine();
    Console.WriteLine();

    //Show Calculator Options again
    Console.WriteLine("Please Select an operation (type -1 to exit calculator)");
    Console.WriteLine("1. Addition (+)");
    Console.WriteLine("2. Subtraction (-)");
    Console.WriteLine("3. Division (/) ");
    Console.WriteLine("4. Multiplication (*)");
    Console.WriteLine("5. Fibonacci Sequence (?)");
    choice = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("************>Thank you for using the sample calculator<************");
