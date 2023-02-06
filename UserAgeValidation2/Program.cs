// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajalt sisestada tema vanuse
//kui kasutaja vanus on väiksem kui 13 siis konsoolis kuvatakse:
//"you are too young to use Instagram"
//muul juhul
//konsoolis kuvatakse "Welcome to instagram"

using System.Runtime.Intrinsics.X86;

Console.WriteLine("Enter your age:");

string userAge = Console.ReadLine();

int userAgeNum = 0;

//boolean - true/false

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);
//int UserAge = Int32.Parse(Console.ReadLine()); // "13" - heap, 13 - stack

Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old.");

if (isAgeNumber)
{
    if (userAgeNum >= 13)
    {
        Console.WriteLine("Welcome to Instagram!");
    }
    else
    {
        Console.WriteLine("You are too young to use Instagram.");
    }

}
else
{
    Console.WriteLine("Could not read your age.");
}
