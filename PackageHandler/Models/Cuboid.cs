namespace PackageHandler.Models;

public class Cuboid
{
    private float _width;
    private float _height;
    private float _length;
    private float _weight;

    public Cuboid(float width, float height, float weight, float length)
    {
        _width = width;
        _height = height;
        _weight = weight;
        _length = length;
    }

    public float GetWidth () => _width;
    public float GetHeight () => _height;
    public float GetWeight () => _weight;
    public float GetLength () => _length;
}