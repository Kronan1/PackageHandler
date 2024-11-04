namespace PackageHandler.Models;

public class Cylinder
{
    private float _radius;
    private float _length;
    private float _weight;

    public Cylinder(float radius, float length, float weight)
    {
        _radius = radius;
        _length = length;
        _weight = weight;
    }
    
    public float GetRadius() => _radius;
    public float GetLength() => _length;
    public float GetWeight() => _weight;
}