using System;


class Program
{


    static void Main(string[] args)
    {
        Grille fdj = new Grille();
        Grille player = new Grille();
        Stats stats = new Stats();


    /* for (int i = 0; i < player.NbBoules; i++)
        {
            Console.Write($"Boule n°{i + 1} : ");
            int value = Convert.ToInt16(Console.ReadLine());
            player.PlayerChoice(i, value);
        }*/
       
        player.Tirage(); // Tir de la grille joueur 
        //player.Display();
        
    for(int nbTirages = 0; nbTirages < 1; nbTirages++){
       
        int[] nbBon = player.Combien(fdj.Tirage()); // Comparaison de la grille joueur en fonction du tirage fdj

       stats.AddStatNombres(nbBon[0]);
       Console.WriteLine($"Il y a {player.resultats[0]} boule(s) de juste");
       Console.WriteLine($"Il y a {player.resultats[1]} étoiles(s) de juste");
    }
    //stats.Display();
    }
    
}
