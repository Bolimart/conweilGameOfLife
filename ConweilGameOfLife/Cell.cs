namespace ConweilGameOfLife;

using System;
public class Cell
{
    #region Fields & Properties

    // Attribut privé représentant l'état actuel de la cellule
    private bool _isAlive;
    public bool isAlive { get { return _isAlive; } private set { _isAlive = value; } }
    
    // Attribut privé pour stocker l'état futur de la cellule
    private bool _nextState;

    #endregion
    #region Constructor

    // ★☆☆ Constructeur : initialise la cellule avec un état donné
    public Cell(bool state)
    {
        isAlive = state;
        _nextState = state;
    }

    #endregion
    #region Methods

    // ★☆☆ Méthode : fait vivre la cellule au prochain pas de simulation
    public void ComeAlive() => _nextState = true;
    
    // ★☆☆ Méthode : tue la cellule au prochain pas de simulation
    public void PassAway() => _nextState = false;
    
    // ★☆☆ Méthode : met à jour _isAlive avec _nextState
    public void Update() => _isAlive = _nextState;

    #endregion
}