
using System.ComponentModel;
using System.IO.Pipelines;

```csharp
List<string> varor = new List<string>();
List<int> priser = new List<int>();

varor.Add("Mjölk"); // då hamnar båda på index automatiskt
priser.Add(0); 
bool kör = true;


while (kör  == true)
{
    int summa = 0;
    for (int i =0; i <varor.Count; i++) //från 0(1) varor räknar uppåt i++
{
 //System.Console.WriteLine($"{varor[i]} har du {i + 1} och det {priser[i]} blir!");   // vid första exekveringen 
 // blir nog detta som behöver fixas , ger mig:  Mjölk har du 1 och det 15 blir i consolen.
 // Jag ber consolen att ta från variablen varor och priser 18:40 kommenterar och adderar 
 // en ny
 System.Console.WriteLine($"{i + 1}. {varor[i]} - {priser[i]} ?"); //är indexet. varor[i] hämtar varan på den positionen 
 //och priser[i] hämtar priset på samma position.
summa += priser[i];
 
}
System.Console.WriteLine($"Totalt: {summa} kr"); //CW + Tab är effektivt

System.Console.WriteLine("1. Lägg till vara");
System.Console.WriteLine("2. Ta bort vara");
System.Console.WriteLine("3. Avsluta");
System.Console.WriteLine("Vad väljer du");
string? svar = System.Console.ReadLine();
if (int.TryParse(svar, out int val))
    {
        
        if (val == 3)
    {
        kör = false;
    }
else if (val == 1)      //Viktigt att else if har egna {}
    {
        Console.WriteLine("Vad heter varan?");
        //System.Console.WriteLine($"[namn] på varan?"); //Original för referens att mina två hjärnceller inte sammarbetar
        string? namn = Console.ReadLine();
     
        
        Console.WriteLine("Vad kostar varan?");
       

        if (int.TryParse(Console.ReadLine(), out int pris)) // integer och värdet skickas in i pris
         //Console.WriteLine("Priset måste vara ett heltal"); // Skulle flyttas 
         // ner till kostnad

    {
         varor.Add(namn);
         priser.Add(pris);
    }
            else
            {
                System.Console.WriteLine("Priset måste vara ett heltal");
            }
        
    }
}
else if (val == 2)
{
    System.Console.WriteLine("Vilket nummer vill du ta bort");

    int.TryParse(Console.ReadLine(), out int nummer);

    if (nummer >= 1 && nummer <= varor.Count)
    {
        int index = nummer - 1;

        varor.RemoveAt(index);
        priser.RemoveAt(index);
    }
    else
    {
        System.Console.WriteLine("Ogiltigt nummer.");
    }
}
}




// else if (val == 2) 
//         {
//             System.Console.WriteLine("Vilket nummer vill du ta bort");
           
//             int.TryParse(Console.ReadLine(),out int nummer); //Klarde jag utan ngn som helst hjälp!. 
//             //Men flyttade den under console för den ska konvertera
//             //först efter inputen från användaren. Annars skapades inte variablen
//                  // hade placerat munnen fel < skulle vara > för att få ut ogiltigt nummer
    
//     if (nummer >= 1 && nummer <= varor.Count)
//     {

//         int index = nummer - 1; //nummer var grå innan, tappar bort mig när kod blir röd eller grey 
//             //blir så många omvända tillmötesvägar för mitt huvud
//         varor.RemoveAt(index);
//         priser.RemoveAt(index);
    
// }
// else

//     System.Console.WriteLine("Ogiltigt nummer.");{}

// {
// }
// }


        
// vid första exekveringen get den mig: Mjölk har du 1 och det3 15 blir!
//Går upp till koden och korrigerar text men varför får jag mjölk? 

//Vid forsatt efterforsnkning behöver jag få in en for loop också. 20:53















// // insköpslistor

// // Början med lista. Vi ska gör en lista
// // En för text List<> == List<string>;
// // List<int> == för nummer
// //ingore.cs ska läggas till 
// //obj och ____ 
// // ska få in input från användaren input (choice?)
// //Console ska fråga efter pris

// List<string> varor = new List<string>();
// List<decimal> prices = new List<decimal>();

// varor.Add("Mjölk"); //0         Här skappas index
// varor.Add("Vatten"); //1
// varor.Add("Mannagryn"); //2

// //Får add prices också. 
// prices.Add ("15");
// prices.Add("20");
// prices.Add ("30");
 

// int choice = 1;
// while (choice ==  1 || choice == 2 )
// {
//     Console.WriteLine("1. Lägg till vara");
//     Console.WriteLine("2. Ta bort vara");
//     Console.WriteLine("3. Avsluta");
//     Console.WriteLine("Vad väljer du?");
//     int.TryParse(Console.ReadLine, out choice);
    
    

// if (choice == 1 )
// {
//     Console.WriteLine("Vad heter varan");
//     string vara = Console.ReadLine();
//     decimal pris;
//     decimal.TryParse(Console.ReadLine(), out pris);
//     varor.Add(vara);
//     prices.Add(pris);
// }
// else if (choice == 2)  // else if, ytterligare ett villkor
// //else--> allt annat, utan villkor
// {
//     Console.WriteLine("Vilken vara vill du ta bort");
//     int nummer ;
//     int.TryParse(Console.ReadLine, out nummer);
//     int index = nummer - 1;
//     varor.RemoveAt(index);
//     prices.RemoveAt(index);
// }

// for (int i = 0; i < varor.Count; i++)
// {
//     varor[i];       //Ska utgå, behövs inte för jag kallar på indexet i nästa kod
//                     //Console.WriteLine($[i])
//     prices[i];
//     //Denna kod blev krånglig för mig, fick sitta en stund. index nummret ska subtraheras
//     //Men här ska användarens input adderas. TRADIGT! 13:46
//     Console.WriteLine($"{i+1}. Du har {varor[i]} och det kostar {prices[i]} kr"); // i+1 fungerar eftersom den går om till 0

// }
// }
// Console.WriteLine("Vad väljer du");

// name[0] = "Mjölk, Vatten, Mannagryn";
// prices[0] = 20m;  30m; 50m; // Går detta ens ? hmm
// // Listor måste fyllas med 
// // .Add() innan du använder index. 10:52 09-10

// Console.WriteLine("Skriv");
// Console.WriteLine("Vilket pris är det" );

// //while passar bäst här eftersom vi 
// // inte vet hur många varor 
// // användaren kommer att lägga till.

// // if (choice == false) ;
// // {
// //     Console.WriteLine("du valde fel");
// // }




//Ref sitter med det mera sen , men orkar inte med chaten atm
//den krångalr bara till det och inte ens ref, skötter uppgiften propert 15:18

// List<string> varor = new List<string>();
// List<decimal> prices = new List<decimal>();

// varor.Add("Mjölk");
// prices.Add(15);

// varor.Add("Vatten");
// prices.Add(20);

// varor.Add("Mannagryn");
// prices.Add(30);

// int choice = 1;

// while (choice == 1 || choice == 2)
// {
//     Console.WriteLine("1. Lägg till vara");
//     Console.WriteLine("2. Ta bort vara");
//     Console.WriteLine("3. Avsluta");
//     Console.WriteLine("Vad väljer du?");

//     int.TryParse(Console.ReadLine(), out choice);

//     if (choice == 1)
//     {
//         Console.WriteLine("Vad heter varan?");
//         string vara = Console.ReadLine();

//         Console.WriteLine("Vad kostar varan?");
//         decimal.TryParse(Console.ReadLine(), out decimal pris);

//         varor.Add(vara);
//         prices.Add(pris);
//     }
//     else if (choice == 2)
//     {
//         Console.WriteLine("Vilken vara vill du ta bort?");

//         for (int i = 0; i < varor.Count; i++)
//         {
//             Console.WriteLine($"{i + 1}. {varor[i]} - {prices[i]} kr");
//         }

//         int.TryParse(Console.ReadLine(), out int nummer);

//         if (nummer >= 1 && nummer <= varor.Count)
//         {
//             int index = nummer - 1;

//             varor.RemoveAt(index);
//             prices.RemoveAt(index);
//         }
//         else
//         {
//             Console.WriteLine("Ogiltigt nummer.");
//         }
//     }

//     for (int i = 0; i < varor.Count; i++)
//     {
//         Console.WriteLine($"{i + 1}. {varor[i]} - {prices[i]} kr");
//     }
// }