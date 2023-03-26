using UnityEngine;
public class Line
{
    Orientation orientation; //file pero propiedades?
    Vector2Int coordenadas; //encapsulamos pero seguimos usando 

    public Line(Orientation orientation, Vector2Int coordenadas)
    {
        this.orientation = orientation;
        this.coordenadas = coordenadas;
    }

    public Orientation Orientation { get => orientation; set => orientation = value; }
    public Vector2Int Coordenadas { get => coordenadas; set => coordenadas = value; }
}
public enum Orientation
{
    Horizontal = 0,
    Vertical = 1
}