// See https://aka.ms/new-console-template for more information

//Ask for players age as input and print it to the screen
//Display an error message if am invalid input is received
try {
    Console.Write("Please Enter your age: ");
    int age = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"You are {age} years old!");
}
catch (Exception) { 
    Console.WriteLine("Your age value was incorrect, please try again");
    //throw;

}
finally {
    Console.WriteLine("*************Thank you for using this program*************");
}

