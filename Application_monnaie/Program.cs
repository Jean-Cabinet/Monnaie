// See https://aka.ms/new-console-template for more information
etiquette:
Console.WriteLine("Veulliez rentrer votre montant");
double montant;
montant = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Choisir une monnaie entre CAD ou USD ou EUR (écrire en majuscule) ");
string line = Console.ReadLine();
Console.WriteLine("Chosir si voulez convertir votre montant en EUR ou USD ou CAD (écrire en majuscule)");
string line2 = Console.ReadLine();

if (line == "CAD" && line2 == "USD")
{

    double MontantUSD = montant/1.3496;
    Console.WriteLine("La somme est de " + MontantUSD + " dollars.");

}
if (line == "CAD" && line2 == "EUR")
{
    double MontantEUR = montant/1.42362;
    Console.WriteLine("La somme est de " + MontantEUR + "euros.");
}

if (line == "USD" && line2 == "CAD")
{

    double MontantCAD = montant*1.3496;
    Console.WriteLine("La somme est de " + MontantCAD + " dollars canadien.");

}
if (line == "USD" && line2 == "EUR")
{
    double MontantEUR = montant*0.95;
    Console.WriteLine("La somme est de " + MontantEUR + " euros.");
}

if (line == "EUR" && line2 == "CAD")
{

    double MontantCAD = montant*1.42;
    Console.WriteLine("La somme est de " + MontantCAD + " dollars canadien.");

}
if (line == "EUR" && line2 == "USD")
{
    double MontantUSD = montant/0.95;
    Console.WriteLine("La somme est de " + MontantUSD + "dollars.");
}



Console.ReadKey();
goto etiquette;
