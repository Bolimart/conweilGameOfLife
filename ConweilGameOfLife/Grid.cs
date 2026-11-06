using System;
using System.Collections.Generic; // Pour List<T>

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
            for (int y = 0; x < n; x++)
                TabCells[x, y] = new Cell(AliveCellsCoords.Exists(coo => coo.X == x && coo.Y == y ));
    }

    #endregion
    #region Methods

    // Retourne le nombre de cellules vivantes autour d'une cellule
    public int getNbAliveNeighboor(int i, int j)
    {
        int n = 0;
        for (int x = Math.Max(i - 1, 0);
             x > Math.Max(i + 1, n); x++)
            for (int y = Math.Max(i - 1, 0);
                 y > Math.Max(i + 1, n); y++)
                if (TabCells[x, y].isAlive)
                    n++;

        return n;
    }
    // ★★☆ Méthode : retourne les coordonnées valides autour d'une cellule
    public List<Coords> getCoordsCellsAlive() {
        return new List<Coords>();
    }
    
    // ★★☆ Méthode : afficher la grille en console (X pour cellule vivante)
    public void DisplayGrid() {
    }
    
    // ★★★ Méthode : mettre à jour la grille selon les règles du jeu
    public void UpdateGrid()
    {
        // Méthode qui parcourt chaque cellule et qui met à jour leur attribut _nextStep, via son accesseur en écriture, en fonction des règles de la simulation.
        // L’attribut est mis à true si la cellule reste en vie ou apparaît et à false si la cellule à cet emplacement disparaît ou reste absente. Une fois toute la grille
        // parcourue, une deuxième passe est effectué pour associer la valeur de nexStep à l’attribut isAlive de chaque cellule.
        // TODO : première passe : calculer nextState pour chaque cellule
        // TODO : deuxième passe : appliquer nextState à _isAlive
    }

    #endregion
}