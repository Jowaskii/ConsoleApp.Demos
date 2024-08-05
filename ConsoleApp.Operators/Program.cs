// See https://aka.ms/new-console-template for more information

/*
    Math Operations and Operators
 */

Console.Write("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the second number: ");
string numEntered = Console.ReadLine();
int num2 = Convert.ToInt32(numEntered);

//add numbers
int sum = num1 + num2;

//multiply numbers
int product = num1 * num2;

//divide numbers
int quotient = num1 / num2;

//subtract numbers
int difference = num1 - num2;

//modulus
int mod = num1 % num2;

Console.WriteLine();
Console.WriteLine("****************Math Results****************");
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Product: {product}");
Console.WriteLine($"Qoutient: {quotient}");
Console.WriteLine($"Modulus: {mod}");
Console.WriteLine("**************End Math Results**************");


/*
 Logic Operations and Operators
 */

bool isGreaterThan = num1 > num2;
bool isLessThan = num1 < num2;
bool isEqualTo = num1 == num2;
bool isGreaterThanOrEqualTo = num1 >= num2;
bool isLessThanOrEqualTo = num1 <= num2;
bool isNotEqualTo = num1 != num2;

Console.WriteLine();
Console.WriteLine("****************Logic Results****************");
Console.WriteLine($"Is Greater Than: {isGreaterThan}");
Console.WriteLine($"Is Less Than: {isLessThan}");
Console.WriteLine($"Is Equal To: {isEqualTo}");
Console.WriteLine($"Is Greater Than Or Equal To: {isGreaterThanOrEqualTo}");
Console.WriteLine($"Is Less Than Or Equal To: {isLessThanOrEqualTo}");
Console.WriteLine($"Is Not Equal To: {isNotEqualTo}");
Console.WriteLine("**************End Logic Results**************");
Console.WriteLine();

/*
    Assignment Operations and Operators
 */

int randomvalue = 5;
Console.WriteLine("Enter random number");
randomvalue = Convert.ToInt32(Console.ReadLine());
//int increaseValue = num1 + 5;

//num1 = num1 + 5;

Console.WriteLine();
Console.WriteLine("****************Assignment Results****************");
num1 += randomvalue;
Console.WriteLine($"Num1 Increased By {randomvalue}: " + num1);
num1 -= randomvalue;
Console.WriteLine($"Num1 Decreased by {randomvalue}: " + num1);
num1 /= randomvalue;
Console.WriteLine($"Num1 Divided by {randomvalue}: " + num1);
num1 %= randomvalue;
Console.WriteLine($"Num1 Mod by {randomvalue}: " + num1);
num1 *= randomvalue;
Console.WriteLine($"Num1 Multplied by {randomvalue}: " + num1);
Console.WriteLine("**************End Logic Results**************");

