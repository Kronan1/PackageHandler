using PackageHandler.Interfaces;
using PackageHandler.Models;

namespace PackageHandler.Services;

public class CylinderPackage : IPackage
{
    private float _volume;
    private float _price;
    private float _weight;

    public CylinderPackage(Cylinder cylinder)
    {
        _weight = cylinder.GetWeight();
        CalculateVolume(cylinder);
        CalculatePrice(cylinder);
    }

    private void CalculateVolume(Cylinder cylinder)
    {
        var length = cylinder.GetLength();
        var radius = cylinder.GetRadius();
        _volume = length * radius;
    }

    private void CalculatePrice(Cylinder cylinder)
    {
        var weight = cylinder.GetWeight();
        _price = _volume * weight;
    }

    public float GetVolume()
    {
        return _volume;
    }

    public float GetPrice()
    {
        if (_weight < 2)
            return -1;

        return _price;
    }
}