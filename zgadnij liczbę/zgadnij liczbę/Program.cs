Random rnd = new Random();
int liczba = rnd.Next(100, 1000);
Console.WriteLine("zgadnij liczbę");
var spr = Console.ReadLine();
if(spr == "sprawdź")
{
    Console.WriteLine(liczba);
}
for(int i = 1; i > 0; i++)
{
    int a = Convert.ToInt32(Console.ReadLine());
    
    if(a != liczba)
    {
        Console.WriteLine("zła liczba");
    }
    if(i == 5)
    {
        Console.WriteLine(i / 100 + "podpowiedź" );
        continue;
    }
    if (i == 10)
    {
        Console.WriteLine(i / 10 + "podpowiedź");
        continue;
    }
    if(i > 15)
    {
        Console.WriteLine("nie udało się");
        break;
    }
    if(a == liczba)
    {
        Console.WriteLine("udało się");
        break;
    }


}