// See https://aka.ms/new-console-template for more information

//prompt for input
Console.Write("Please enter student's grade: ");
// Global Variable / Global Scope
int grade = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("****************Simple If Statements****************");
//print pass or fail based on input
if(grade > 50) {
    Console.WriteLine("Student has passed");
}
else {
    Console.WriteLine("Student has failed");
    Console.WriteLine("Please recommend student to Student Affairs office");
}

Console.WriteLine("**************End Simple If Statements**************");
Console.WriteLine();

Console.WriteLine("****************Complex If...Else If Statements****************");
//print letter grade

/*
 *A : 86 - 100 - else if(grade >= 85 && grade <= 100 )
 *B : 75 - 85 - else if(grade >= 75 && grade <= 85)
 *C : 65 - 74 - else if(grade >=65 && grade <= 74)
 *C-: 50 - 64 - else if(grade >= 50 && grade <=64)
 *F : less than 50 - if(grade < 50)
 */


if(grade < 0 || grade > 100) {
    Console.WriteLine("Invalid Grade Entered");
}
else if (grade < 50) {
    Console.WriteLine("F");
}else if(grade >= 50 && grade <=64){
    Console.WriteLine("C-");
}
else if(grade >=65 && grade <= 74){
    Console.WriteLine("C");
}
else if(grade >= 75 && grade <= 85){
    Console.WriteLine("B");
}
else{
    Console.WriteLine("A");
}

int gradeAfterBonus = grade > 0 && grade <= 100 ? grade + 10 : 0;
Console.WriteLine(gradeAfterBonus);


Console.WriteLine("**************End Complex If...Else If Statements**************");
Console.WriteLine();

Console.WriteLine("****************Ternary Operators****************");
string passStatus = grade < 50 ? "Fail" : "Pass";
Console.WriteLine(passStatus);
Console.WriteLine("**************End Ternary Operators**************");
Console.WriteLine();

Console.WriteLine("****************Switch Statements****************");

/*
 * 1 - Sunday
 * 2 - Monday
 * 3 - Tuesday
 * 4 - Wednesday (Hump Day)
 * 5 - Thursday 
 * 6 - Friday (TGIF!!!)
 * 7 - Saturday (Beach Day)
 */

Console.Write("Please Eneter The day of the Week (1-7): ");
int dayOfTheWeek = Convert.ToInt32(Console.ReadLine());
switch (dayOfTheWeek) {
    case 1:
        Console.WriteLine("Sunday");        
    break;

    case 2:
        Console.WriteLine("Monday");
    break;

    case 3:
        Console.WriteLine("Tuesday");
    break;

    case 4:
        Console.WriteLine("Wednesday");
        Console.WriteLine("HUMP DAY!!!");
    break;

    case 5: 
        Console.WriteLine("Thursday");
    break;

    case 6:
        Console.WriteLine("Friday");
        Console.WriteLine("TGIF!!!!");
    break;

    case 7:
        Console.WriteLine("Saturday");
        Console.WriteLine("BEACH");
        Console.WriteLine("DAY!!!");
    break;

    default: 
        Console.WriteLine("Invalid Entry");
    break;

}
Console.WriteLine("**************End Switch Statements**************");

Console.WriteLine("Thank You for using this program");

