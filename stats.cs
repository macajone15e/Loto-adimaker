using System;


public class Stats
{
    private int[] resultats;

    private int[] resultatsEtoile;
    private int tirageNumber;

    public Stats()
    {
        resultats = new int[6];
        resultatsEtoile = new int[3];
    }

    public void AddStatNombres(BonNumero stat)
    {
        resultats[stat.Boules]++;
        resultatsEtoile[stat.Etoiles]++;
        tirageNumber++;
    }
   
    public void Display()
    {
    Console.WriteLine("Combien\t% ");
    Console.WriteLine("Boules");
    for(int i = 0; i<6;i++){

        Console.WriteLine($"{i}\t{resultats[i]*100.00/tirageNumber}%");

    }
    Console.WriteLine();
    Console.WriteLine("Étoiles");
    for(int i = 0; i<3;i++){

        Console.WriteLine($"{i}\t{resultatsEtoile[i]*100.000000/tirageNumber}%");

    }
    }


}