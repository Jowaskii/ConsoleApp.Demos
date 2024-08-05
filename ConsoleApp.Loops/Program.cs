// See https://aka.ms/new-console-template for more information

//Simple Loop Demo
//Print "Hello World" 10 times

Console.WriteLine("*****************Simple For Loop*****************");
for(int i = 0; i < 10; i++) {
    Console.WriteLine($"Hello, World! - {i}");
}

Console.WriteLine("Loop Completed");
Console.WriteLine();

//// Ask user how many times they wish to print hello world and print accordingly
//Console.WriteLine("How many times do you want to print hello world");
//int userCount = Convert.ToInt32(Console.ReadLine());

//for(int i = 0; i < userCount; i++) {
//    Console.WriteLine($"Hello, World! - {i}"); 
//}
Console.WriteLine("***************End Simple For Loop***************");
Console.WriteLine();
Console.WriteLine("****************While Loop****************");

int counter = 0;
while(counter < 10) {
    Console.WriteLine($"Hello World - {counter}");
    counter++;
}

//Prompt for input
int numEntered = -1; 
int sum = 0;

//process input
while(numEntered != -1) {
    Console.WriteLine("please enter a number to be added (Enter -1 to add numbers): ");

    numEntered = Convert.ToInt32(Console.ReadLine());
    if(numEntered != -1) {
        sum += numEntered;
    }
   
}

//print result
Console.WriteLine("The sum of the numbers entered is: " + sum);
Console.WriteLine("**************End While Loop**************");
Console.WriteLine();

Console.WriteLine("****************Do-While Loop****************");
numEntered = -1;
sum = 0;

do {
    numEntered = Convert.ToInt32(Console.ReadLine());
    if (numEntered == -1) {
        break;
    }
    sum += numEntered;
} while(numEntered != -1);
Console.WriteLine("The sum of the numbers entered is: " + sum);
Console.WriteLine("**************End Do-While Loop**************");






