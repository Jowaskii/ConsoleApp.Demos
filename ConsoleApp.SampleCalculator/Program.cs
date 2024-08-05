// See https://aka.ms/new-console-template for more information

int choice = 0;
int num1, num2 = 0;
int ans = 0;

while (choice != -1) {
    try {
        Console.WriteLine("************>Welcome to the sample calculator<************");
        Console.WriteLine();
        //Show Calculator Options 
        Console.WriteLine("Please Select an operation (type -1 to exit calculator)");
        Console.WriteLine("1. Addition (+)");
        Console.WriteLine("2. Subtraction (-)");
        Console.WriteLine("3. Division (/) ");
        Console.WriteLine("4. Multiplication (*)");
        Console.WriteLine("5. Fibonacci Sequence (?)");
        
        choice = Convert.ToInt32(Console.ReadLine());

        if (choice == -1) {
            break;
        }
        //Prompt user for input
        Console.Write("Please Enter First Number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please Enter Second Number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        ans = 0;

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
                for (int i = num1; i <= num2; i++) {
                    ans += i;
                }
                break;

            default:
                throw new Exception("Invalid Menu Item Selected");
        }
        //Print output
        Console.WriteLine(ans);
    }
    catch (DivideByZeroException) {
        Console.WriteLine("Cannot Divide by Zero");
    }
    catch (Exception ex) {
        Console.WriteLine(ex.Message);
    }
    finally {
        Console.WriteLine("Please press any key to continue");
        Console.ReadLine();
        Console.Clear();
    }
}
Console.WriteLine("************>Thank you for using the sample calculator<************");
