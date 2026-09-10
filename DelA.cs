// insköpslistor

// Början med lista. Vi ska gör en lista
// En för text List<> == List<string>;
// List<int> == för nummer
//ingore.cs ska läggas till 
//obj och ____ 
// ska få in input från användaren input (choice?)
//Console ska fråga efter pris

List<string> varor = new List<strin>();
List<decimal> prices = new List<decimal>();

varor.Add("Mjölk"); //0         Här skappas index
varor.Add("Vatten"); //1
varor.Add("Mannagryn"); //2

//Får add prices också. 
prices.Add ("Mjölk" , "Vatten");
prices.Add("Vatten");
prices.Add ("Mannagryn");
 


while (choice  == 1 || choice == 2 )
{
    Console.WriteLine("vad väljer du?");
    int.TryParse(Console.ReadLine, out choice);
}

if (choice == 1 )
{
    Console.WriteLine("Vad heter varan");
    string vara = Console.ReadLine();
    int pris;
    int.TryParse(Console.ReadLine(), out pris);
    varor.Add(vara);
    prices.Add(pris);
}
else if (choice == 2) ; // else if, ytterligare ett villkor
//else--> allt annat, utan villkor
{
    Console.WriteLine("Vilken vara vill du ta bort");
    int nummer ;
    int.TryParse(Console.ReadLine, out nummer);
    int index = nummer - 1;
    varor.RemoveAt(index);
    prices.RemoveAt(index);
}

for (int i = 0; i < varor.Count; i++)
{
    varor[i];
    prices[i];
    //Denna kod blev krånglig för mig, fick sitta en stund. index nummret ska subtraheras
    //Men här ska användarens input adderas. TRADIGT! 13:46
    Console.WriteLine($"{i+1}. Du har {varor[i]} och det kostar {prices[i]} kr");
}


name[0] = "Mjölk, Vatten, Mannagryn";
prices[0] = 20m;  30m; 50m; // Går detta ens ? hmm
// Listor måste fyllas med 
// .Add() innan du använder index. 10:52 09-10

Console.WriteLine("Skriv");
Console.WriteLine("Vilket pris är det" );

//while passar bäst här eftersom vi 
// inte vet hur många varor 
// användaren kommer att lägga till.

// if (choice == false) ;
// {
//     Console.WriteLine("du valde fel");
// }

