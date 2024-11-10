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
        
    for(int nbTirages = 0; nbTirages < 100000000; nbTirages++){
       
        int[] nbBon = player.Combien(fdj.Tirage()); // Comparaison de la grille joueur en fonction du tirage fdj
        //Console.WriteLine($"Il y a {resultats[0]} boule(s) de juste");
        //Console.WriteLine($"Il y a {resultats[1]} étoiles(s) de juste");

       stats.AddStatNombres(nbBon[0],nbBon[1]); 
       
    }
    stats.Display();
    }
    
}
