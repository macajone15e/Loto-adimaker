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

    public void AddStatNombres(int numeros, int etoile)
    {
        resultats[numeros]++;
        resultatsEtoile[etoile]++;
        tirageNumber++;
    }
   
    public void Display()
    {
    Console.WriteLine("Combien\t% ");
    for(int i = 0; i<6;i++){

        Console.WriteLine($"{i}\t{resultats[i]*100.000000/tirageNumber}%");

    }
    Console.WriteLine();
    for(int i = 0; i<4;i++){

        Console.WriteLine($"{i}\t{resultatsEtoile[i]*100.000000/tirageNumber}%");

    }
    }


}