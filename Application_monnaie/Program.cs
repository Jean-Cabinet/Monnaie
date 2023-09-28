// See https://aka.ms/new-console-template for more information
etiquette:
Console.WriteLine("Veulliez rentrer votre montant");
double montant;
montant = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Choisir une monnaie entre CAD ou USD ");
string line = Console.ReadLine();

if (line == "CAD")
{

    double MontantUSD = montant*1.3496;
    Console.WriteLine("La somme est de " + MontantUSD + " dollars.");

}
if (line == "USD")
{
    double MontantCAD = montant/1.3496;
    Console.WriteLine("La somme est de " + MontantCAD + "dollars canadien.");
}

Console.ReadKey();
goto etiquette;
