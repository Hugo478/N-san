/*
Skapa en string-array med namnen på fem olika leksaker.
Skriv en for-loop (eller foreach-loop) som skriver ut namnet på varje leksak på en egen rad.
Skapa en string-array med namnen på fem av dina klasskamrater.
Skapa en integer-array med fem värden mellan 0 och 10.
Komplettera for-loopen så att den på varje rad skriver ut något liknande "Pelle ger Barbie betyget 5". Använd dina klasskamraters namn, leksakernas namn och värdena från int-arrayen.
Skapa en tom string-lista som heter "cities".
Skapa en loop där du varje gång loopen körs hämtar en string från användaren med Console.ReadLine. Lägg till den string du får från användaren till cities-listan. Avbryt loopen om användaren skriver "exit".
Skapa en loop som ligger efter den ovanstående. Den här loopen ska skriva ut alla strings som finns sparade i cities-listan.
*/
while (true)
{
    string[] leksaker = { "Skylanders", "Lego", "Hotwheels", "Träsvärd", "Tärning" };
    string[] klasskamrat = { "Sven","Sven2","Sven3","Sven4","Mögel",};
    int[] betyg = { 0, 1, 3, 4, 10};

     List<string> cities = new List<string>();


    foreach (var leksak in leksaker)
    {
        Console.WriteLine(leksak);
    }

    for (var i = 0; i < leksaker.Length; i++)
    {
        Console.WriteLine($"{klasskamrat[i]} ger {leksaker[i]} betyget {betyg[i]}");
    }
   
  while (true)
        {
            Console.Write("Ange en stad eller skriv 'exit' för att sluta: ");
            string city = Console.ReadLine();

            if (city == "exit")
            {
                break;
            }
            else
            {
            cities.Add(city);
            }
        }
Console.WriteLine("Städer du nämnde:");
    foreach (var city in cities)
    {
        Console.WriteLine(city);
    }

}
