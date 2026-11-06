namespace ConweilGameOfLife;

public struct Coords
{
    #region Fields & Propreties

    private int _x;
    private int _y;

    public int X
    {
        get => _x;
        set => _x = value;
    }
    
    public int Y
    {
        get => _y;
        set => _y = value;
    }

    #endregion

    #region Constructors

    public Coords(int x, int y)
    {
        _x = x;
        _y = y;
    }

    #endregion
    #region Methods

    public override string ToString() => $"Coords: x={_x} y={_y}";

    #endregion
}