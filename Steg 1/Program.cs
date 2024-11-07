/*
SLUTÖVNING: Skapa ett “gissa siffran”-spel:
Slumpa eller välj ett tal som användaren ska gissa.
Skapa en loop som körs tills användaren gissat rätt. Du måste alltså skapa variabeln där användarens gissning lagras utanför loopen.
Låt användaren skriva in ett tal. Gör inskrivningen säker, dvs att programmet inte krashar om användaren skriver in något som inte kan konverteras till en int.
Informera användaren om huruvida hens gissning är för hög, för låg eller exakt rätt.
*/
while (true)
{
   int Nummer = Random.Shared.Next(1, 5);
   while (true)
   {
    Console.WriteLine("Gissa ett nummer mellan 1 och 5: ");
    int Gissning = int.Parse(Console.ReadLine());
    if (Gissning == Nummer){
        Console.WriteLine("Du gissade rätt");
        return;
    }
    else
    {
         Console.WriteLine("Fel! Gissa igen");
    }
   }
}