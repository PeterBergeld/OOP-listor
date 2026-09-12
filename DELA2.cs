// Börja om från början, börja om på nytt, varför ska man......


List<string> names = new List<string>(); // an expression req an argument list or in this case ()
List<int> priser = new List<int>(); //Fortfarande lite konfys angående att grey visas under name innan den värderas, kolla upp colour.

names.Add("Mjölk");
priser.Add(15);
names.Add("Bröd");
priser.Add(32);
names.Add("Ost");
priser.Add(89);
int summa = 0;

for (int i =0; i< names.Count; i++)  // Visa varan och priset därav en for-loop
{
   
    System.Console.WriteLine($"{i+1}. {names[i]} - {priser[i]}");
    //System.Console.WriteLine($"{i+1}.{priser[i]}"); // Behöver inte vara med , för att de ska kopplas ihop
    summa += priser[i];
    
}
System.Console.WriteLine($"Totalt: {summa} kr");

System.Console.WriteLine("1. Lägg till vara");
System.Console.WriteLine("2. Ta bort vara");
System.Console.WriteLine("3. Avsluta");

string? svar = System.Console.ReadLine();
int.TryParse(svar, out int val);

if (val == 1) ;
{
    System.Console.WriteLine("Vad heter varan");
    string? name = System.Console.ReadLine();
    System.Console.WriteLine("Vad kostar varan");
}

if (int.TryParse(Console.ReadLine(), out int pris))
{
    names.Add(namn);
    priser.Add(pris);
}

else if (val == 2)
{
    System.Console.WriteLine("Vilket nummer vill du ta bort");
    int.TryParse(Console.ReadLine(), out int nummer);
}