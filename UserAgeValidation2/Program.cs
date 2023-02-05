// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal sisestada tema vanus
//kui kasutaja vanus on väiksem kui 13, siis konsoolis kuvatakse:
//"you are too young to use Instagram"
//muul juhul
//konsoolis kuvatakse "Welcome to Instagram"

Console.WriteLine("Enter your age:");

string userAge = Console.ReadLine();

int userAgeNum = 0;

//boolean -true/false

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);


//int userage = Int32.Parse(Console.ReadLine()); // "13" -heap, 13 -stack

Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old.");
if(isAgeNumber) //võib olla ka if(isAgeNumber == true)
{
    if(userAgeNum > 13)
    {
        Console.WriteLine("Welcome to Instagram.");
    }
    else
    {
        Console.WriteLine("Your are too young to use Instagram");
    }
}
else
{
    Console.WriteLine("Could not read your age");
}

//if(userage >= 13)
//{
//    Console.WriteLine("Welcome to Instagram!");
//}
// kui kasutad alguses if(userage > 13) siis:
//else if (userage == 13)
//{
//    Console.WriteLine("Welcome to Instagram!");
//}
//if (userage <13)
//{
//    Console.WriteLine("Your are too young to use Instagram.");
//}

