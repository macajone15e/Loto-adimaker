using System;

public class BonNumero 
{
    public int Boules;
    public int Etoiles;



}
public class Grille
{
    private int nbBoules = 5;
    private int nbEtoiles = 2;

    private int nombreJuste;
    private int nombreEtoileJuste;

    public int[] resultats;

    private Random random;

    private int[] boules;
    private int[] etoiles;
    public int[] tirageComplet;

    public Grille()
    {
        boules = new int[nbBoules];
        tirageComplet = new int[nbBoules+nbEtoiles];
        etoiles = new int[nbEtoiles];
        resultats = new int[2];
        random = new Random();
    }

    public int NbBoules { get { return nbBoules; } }

    public void PlayerChoice(int numero, int value)
    {
        boules[numero] = value;
    }

    public int[] Tirage()
    {
        // tirage de l'ensemble des boules
        for (int i = 0; i < nbBoules; i++)
        {
            bool valueBoulesIsOk;
            int value;
            do
            {
                // tirage d'un nombre aléatoire
                value = random.Next(1, 50);
                // par défaut, je considère qu'il est bon
                valueBoulesIsOk = true;
                // je teste les tirages précédent
                for (int test = 0; test < i; test++)
                {
                    // la boule a déjà été tirée ?
                    if (boules[test] == value)
                    {
                        // ça n'est donc pas bon !
                        valueBoulesIsOk = false;
                    }
                }
                // je recommence tant que ça n'est pas bon
            } while (valueBoulesIsOk == false);
            boules[i] = value;
            tirageComplet[i]= value;
        }

        for (int i = nbBoules; i < nbBoules + nbEtoiles; i++)
        {
            bool valueEtoileIsOk;
            int valueEtoile;
            do
            {
                // tirage d'un nombre aléatoire
                valueEtoile = random.Next(1,13);
                // par défaut, je considère qu'il est bon
                valueEtoileIsOk = true;
                // je teste les tirages précédent
                for (int test = 0; test < i-nbBoules; test++)
                {
                    // la boule a déjà été tirée ?
                    if (etoiles[test] == valueEtoile)
                    {
                        // ça n'est donc pas bon !
                        valueEtoileIsOk = false;
                    }
                }
                // je recommence tant que ça n'est pas bon
            } while (valueEtoileIsOk == false);
            etoiles[i-nbBoules] = valueEtoile;
            tirageComplet[i] = valueEtoile;

        }
        Sort();
        //Display();
        return tirageComplet; 
    }

    public void Sort()
    {
        bool invert = false;
        do
        {
            invert = false;

            for (int index = 0; index < nbBoules - 1; index++)
            {

                if (tirageComplet[index] > tirageComplet[index + 1])
                {

                    int temp = tirageComplet[index];
                    tirageComplet[index] = tirageComplet[index + 1];
                    tirageComplet[index + 1] = temp;
                    invert = true;
                }
            }
        } while (invert == true);
        
        bool invertEtoiles = false;
        do
        {
            invertEtoiles = false;

            for (int index = nbBoules; index < nbBoules+nbEtoiles - 1; index++)
            {

                if (tirageComplet[index] > tirageComplet[index + 1])
                {

                    int etoileTemp = tirageComplet[index];
                    tirageComplet[index] = tirageComplet[index + 1];
                    tirageComplet[index + 1] = etoileTemp;
                    invertEtoiles = true;
                }
            }
        } while (invertEtoiles == true);
    }
    public void Display()
    {
        for (int i = 0; i < nbBoules; i++)
        {
            Console.Write($"{tirageComplet[i]} ");
        }
        Console.WriteLine();
        Console.Write("Étoiles : ");
        for (int i = nbBoules; i < nbEtoiles+nbBoules; i++)
        {
            Console.Write($"{tirageComplet[i]} ");
        }
        Console.WriteLine();
    }
    

    public BonNumero Combien(int[] x)
    {

        nombreJuste = 0;
        nombreEtoileJuste = 0;
        for (int i = 0; i < nbBoules; i++)
        {
            for (int j = 0; j < nbBoules; j++)
            {
                if (x[i] == tirageComplet[j])
                {
                    nombreJuste = nombreJuste + 1;
                    break;

                }
            }
        }
        for (int i = nbBoules; i < nbBoules+nbEtoiles; i++)
        {
            for (int j = nbBoules; j < nbBoules+nbEtoiles; j++)
            {
                if (x[i] == tirageComplet[j])
                {
                    nombreEtoileJuste = nombreEtoileJuste + 1;
                    break;

                }
            }
        }
        BonNumero resultats = new BonNumero();
        resultats.Boules = nombreJuste;
        resultats.Etoiles = nombreEtoileJuste;
        
        return resultats;

    }


}