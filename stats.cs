using System;


public class Stats
{
    private int[] resultats;
    private int tirageNumber;

    public Stats()
    {
        resultats = new int[6];
    }

    public void AddStatNombres(int nombre)
    {
        resultats[nombre]++;
        tirageNumber++;
    }
    public void Display()
    {
    Console.WriteLine("Combien\t% ");
    for(int i = 0; i<6;i++){

        Console.WriteLine($"{i}\t{resultats[i]*100.0/tirageNumber}%");

    }
    }


}