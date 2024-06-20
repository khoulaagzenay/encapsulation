using encapsulation;
using System.Reflection.PortableExecutable;

public class Program
{
    public static void Main(string[] arg)

    {
        Console.WriteLine("Veuillez préciser litres de bière disponibles en centilitre");
        decimal BeerDispo = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Veuillez préciser les bouteilles vides disponibles");
        int BotleDispo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Veuillez préciser les capsules disponibles");
        int CapsuleDispo = Convert.ToInt32(Console.ReadLine());
            

        BeerEncapsulator Beer1 = new BeerEncapsulator(BeerDispo, BotleDispo, CapsuleDispo);
        Beer1.display();

        Console.WriteLine(Beer1.ProduceEncapsulatedBeerBottles(100));

        Console.ReadLine();
    }

}