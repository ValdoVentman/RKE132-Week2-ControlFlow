// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal valida tema sugu (m/F)
//rakendus küsib kasutajal sisestada tema perekonnanime
//lähtudes kasutaja valikust, rekendus tervitab kasutajad järgmiselt:
//"Welcome, Mr. [kasutaja perekonnanimi] / "Welcome, Ms [kasutaja perekonnanimi]"

Console.WriteLine("Please, select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine()); //loeb konsoolist maha andmeid string (sõne) formaadis

Console.WriteLine("Please, enter your name:");
string userLastName = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");   
}
else if (userGender == 'f')
{
    Console.WriteLine($"welcome, Ms.{userLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}

