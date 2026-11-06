using System;
using System.Collections.Generic;
using System.Runtime.InteropServices; // Pour List<T>

namespace ConweilGameOfLife;

public class Grid
{
    #region Fields & Properties

    // Taille de la grille
    private int _n;
    public int n { get { return _n; } set { _n = value; } }
    
    // Tableau 2D de cellules
    public Cell[,] TabCells;

    #endregion
    #region Constructor

    public Grid(int nbCells, List<Coords> AliveCellsCoords)
    {
        n = nbCells;
        TabCells = new Cell[n, n];

        for (int x = 0; x < n; x++)
            for (int y = 0; y < n; y++)
                TabCells[x, y] = new Cell(AliveCellsCoords.Exists(coo => coo.X == x && coo.Y == y ));
        DisplayGrid();
    }

    #endregion
    #region Methods

    // Retourne le nombre de cellules vivantes autour d'une cellule
    public int getNbAliveNeighboor(int i, int j)
    {
        int p = 0;
        for (int x = -1; x <= 1; x++)
            for (int y = -1; y <= 1; y++)
            {
                var ix = i + x;
                var jy = j + y;
                if (
                    ix >= 0 && jy >= 0 &&
                    ix < n && jy < n &&
                    (x != 0 || y != 0) &&
                    TabCells[ix, jy].isAlive
                    )
                    p++;
            }

        return p;
    }
    // Retourne les coordonnées des cellules vivantes
    public List<Coords> getCoordsCellsAlive() {
        var r = new List<Coords>();

        for (int x = 0; x < n; x++)
            for (int y = 0; y < n; y++)
                if (TabCells[x, y].isAlive)
                    r.Add(new Coords(x, y));

        return r;
    }
    
    // ★★☆ Méthode : afficher la grille en console (X pour cellule vivante)
    public void DisplayGrid() {
        Console.Clear();
        for (int x = 0; x < n; x++)
        {
            for (int y = 0; y < n; y++)
                Console.Write(TabCells[x, y].isAlive ? "\e[48;2;255;255;255m  " : "\e[48;2;0;0;0m  " ); // 
            Console.WriteLine();
        }

        Console.ResetColor();
    }
    
    // ★★★ Méthode : mettre à jour la grille selon les règles du jeu
    public void UpdateGrid()
    {
        // Méthode qui parcourt chaque cellule et qui met à jour leur attribut _nextStep, via son accesseur en écriture, en fonction des règles de la simulation.
        // L’attribut est mis à true si la cellule reste en vie ou apparaît et à false si la cellule à cet emplacement disparaît ou reste absente. Une fois toute la grille
        // parcourue, une deuxième passe est effectué pour associer la valeur de nexStep à l’attribut isAlive de chaque cellule.
        
        for (int x = 0; x < n; x++)
        {
            for (int y = 0; y < n; y++)
            {
                var cell = TabCells[x, y];
                var n = getNbAliveNeighboor(x, y);
                if (cell.isAlive)
                {
                    if (n < 2 || n > 3)
                        cell.PassAway();
                }
                else
                {
                    if (n == 3)
                        cell.ComeAlive();
                }

                Update += cell.Update;
            }
        }
        
        Update.Invoke();
    }

    private event Action Update;

    #endregion
}