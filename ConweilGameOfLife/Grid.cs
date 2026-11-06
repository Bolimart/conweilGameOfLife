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

    // ★★★ Constructeur : initialise la grille et les cellules
    public Grid(int nbCells, List<Coords> AliveCellsCoords)
    {
        // TODO : initialiser n et TabCells
        // TODO : remplissage du tableau avec à chaque emplacement une instance d’une cellule Cell créée vivante (true) si les coordonnées sont dans la liste AliveCellsCoords ou absente (false) sinon.
    }

    #endregion
    #region Methods

    // ★★☆ Méthode : retourne le nombre de cellules vivantes autour d'unecellule
    public int getNbAliveNeighboor(int i, int j) {
        return 0;
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