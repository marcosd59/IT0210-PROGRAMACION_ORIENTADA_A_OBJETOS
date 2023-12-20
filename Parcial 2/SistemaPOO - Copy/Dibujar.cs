
public class Dibujar
{
    protected int _origRow;
    protected int _origCol;
    public int origRow
    {
        get { return _origRow; }
        set { _origRow = value; }
    }

    public int origCol
    {
        get { return _origCol; }
        set { _origCol = value; }
    }

    public void Escribir(string s, int x, int y)
    {
        Dibujar d = new Dibujar();
        Console.SetCursorPosition(d.origCol + x, d.origRow + y);
        Console.Write(s);
    }
}