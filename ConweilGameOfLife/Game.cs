using System;
using System.Collections.Generic; // Pour List<T>
using System.Threading; // Pour Thread.Sleep

namespace ConweilGameOfLife;

public class Game
{
    #region Fields & Propreties

    // Taille de la grille
    private int n;
    // Nombre d'itérations de la simulation
    private int iter;
    // Grille contenant toutes les cellules
    public Grid grid;
    // Liste des coordonnées des cellules vivantes au départ
    public List<Coords> AliveCellsCoords;

    #endregion
    #region Constructeur

    public Game(int nbCells, int nbIterations)
    {
        n = nbCells;
        iter = nbIterations;
        
        AliveCellsCoords = new List<Coords> {
            new Coords(5, 4),
            new Coords(4, 4),
            new Coords(4, 5),
            new Coords(3, 5),
            new Coords(3, 3),
        };

        grid = new Grid(n, AliveCellsCoords);
    }

    #endregion
    #region Methods

    // ★★★ Méthode : exécute la simulation dans la console
    public void RunGameConsole()
    {
        grid.DisplayGrid();
        // Boucle sur le nombre d'itérations
        for (int i = 0; i < iter; i++)
        {
            grid.UpdateGrid();
            grid.DisplayGrid();
            Thread.Sleep(100);
        }
    }

    #endregion

}