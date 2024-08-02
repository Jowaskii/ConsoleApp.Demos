string? firstName = string.Empty;
string? middleName = string.Empty;
string? lastName = string.Empty;
string? occupation = string.Empty;
string? address = string.Empty;
int age = 0;
char gender = char.MinValue;

Console.Write("Enter your first name: ");
firstName = Console.ReadLine();

Console.Write("Enter Your middle Name: ");
middleName = Console.ReadLine();

Console.Write("Enter Your last Name: ");
lastName = Console.ReadLine();

Console.Write("Enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter your adrdress: ");
address = Console.ReadLine();

Console.Write("Enter your gender (M or F): ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Enter your occupation: ");
occupation = Console.ReadLine();

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Your name is {0} {1} {2}", firstName, middleName, lastName);
Console.WriteLine($"You are a {age} year old " + occupation + " of {0} ", address);

