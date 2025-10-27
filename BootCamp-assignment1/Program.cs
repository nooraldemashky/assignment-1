/**
 * 1. write aprogram that prints name of the day
 * based on the users input \( a number between 1and 7 ) 
 * if the user enters a number greater than 7 or less than 1,
 * display invalid input */


   Console.WriteLine("Please enter a number ");
var num = Convert.ToInt32(Console.ReadLine());
if (num > 7 || num < 1)
   {
    Console.WriteLine("invalid input , try another number");
    
   }
 else
    {
       switch (num)
    {
        case 1:
            Console.WriteLine("The Day is Sunday ");
            break;
        case 2:
            Console.WriteLine("The Day is Monday ");
            break;
        case 3:
            Console.WriteLine("The Day is Tuesday ");
            break;
        case 4:
            Console.WriteLine("The Day is Wednesday ");
            break;
        case 5:
            Console.WriteLine("The Day is Thursday ");
            break;
        case 6:
            Console.WriteLine("The Day is Friday ");
            break;
        case 7:
            Console.WriteLine("The Day is Saturday ");
            break;
    }
    
    }
//------------------------------------------
/* * 
 * 2. wrtie a program that prints how many days are in a month
 * (30,31,28) based on the users input 9 anumber between 1 and 12)
 * if user enters a number greater than 12 or less than 1 
 * deisplay invalid input 
 * */
Console.WriteLine("Please enter a number ");
var num2 = Convert.ToInt32(Console.ReadLine());

if (num2 > 12 || num2 < 1)
{
    Console.WriteLine("invalid input , try another number");

}
else if (num2 == 1 || num2 == 3 || num2 == 5 || num2 == 7)
{
    Console.WriteLine($"the month is {num2}: Number of days 31  ");
}
else if (num2 == 8 || num2 == 10 || num2 == 12)
{
    Console.WriteLine($"the month is {num2}: Number of days 31  ");
}
else if (num2 == 4 || num2 == 6 || num2 == 9 || num2 == 11)
{
    Console.WriteLine($"the month is {num2}: Number of days 30 ");
}
else if (num2 == 2)
{
    Console.WriteLine($"the month is {num2}: Number of days 28  ");
}
