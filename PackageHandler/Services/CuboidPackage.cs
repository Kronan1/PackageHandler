using PackageHandler.Interfaces;
using PackageHandler.Models;

namespace PackageHandler.Services;

public class CuboidPackage : IPackage
{
    private float _volume;
    private float _price;

    public CuboidPackage(Cuboid cuboid)
    {
        CalculateVolume(cuboid);
        CalculatePrice(cuboid);
    }

    private void CalculateVolume(Cuboid cuboid)
    {
        var length = cuboid.GetLength();
        var width = cuboid.GetWidth();
        var height = cuboid.GetHeight();
        
        _volume = (length * width * height) / 100;
    }

    private void CalculatePrice(Cuboid cuboid)
    {
        var weight = cuboid.GetWeight();
        var height = cuboid.GetHeight();
        var width = cuboid.GetWidth();
        
        if (width < 30 && height < 30)
        {
            if (weight is > 0 and < 2)
                _price = 29;
            if (weight is >= 2 and < 10)
                _price = 49;
            if (weight is >= 10 and < 20)
                _price = 79;
        }
        else
        {
            _price = (width * height + weight + 10000) / 100;
        }
    }

    public float GetVolume()
    {
        return _volume;
    }

    public float GetPrice()
    {
        return _price;
    }
}