// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal valida tema sugu (m/f)
//rakendus küsib kasutajal sisestada tema nime perekonnanime
//lähtudeskasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome, Mr. (kasutaja perekonnanimi) / Mrs. (kasutaja perekonnanimi)"

Console.WriteLine("Please select your gender (m/f):");

char UserGender = Char.Parse(Console.ReadLine()); //Loeb konsoolist maha andmeid string (sõne) formaadis
Console.WriteLine("Please enter your lastname:");
string userLastName = Console.ReadLine();



if(UserGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName} !");
}
else if(UserGender == 'f')
{
    Console.WriteLine($"Welcome, Mrs {userLastName} !");
}

else
{
    Console.WriteLine($"Welcome {userLastName} !");
}



