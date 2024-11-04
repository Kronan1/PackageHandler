using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using PackageHandler.Interfaces;
using PackageHandler.Models;
using PackageHandler.Services;

namespace PackageHandler;

class Program
{
    static void Main(string[] args)
    {
        IPackage packageService = null;
        
        Console.WriteLine("Välj C för Cylinder eller P för Paket");
        var chosenOption = Console.ReadLine();

        if (chosenOption?.ToUpper() == null)
        {
            Console.WriteLine("Skriv C eller P");
            return;
        }

        if (chosenOption.ToUpper() != "C" && chosenOption.ToUpper() != "P")
        {
            Console.WriteLine("Skriv C eller P");
            return; 
        }


        if (chosenOption.ToUpper() == "C")
        {
            var radius = GetFloatFromInput("Radius: ");
            if (radius == -1)
                return;
            
            var length = GetFloatFromInput("Längd cm: ");
            if (length == -1)
                return;
            
            var weight = GetFloatFromInput("Vikt kg: ");
            if (weight == -1 || weight > 20)
                return;

            packageService = new CylinderPackage(new Cylinder(radius, length, weight));
        }

        if (chosenOption.ToUpper() == "P")
        {
            // private float _width;
            var width = GetFloatFromInput("Bredd cm: ");
            if (width == -1)
                return;
            
            // private float _height;
            var height = GetFloatFromInput("Höjd cm: ");
            if (height == -1)
                return;
            
            // private float _length;
            var length = GetFloatFromInput("Längd cm: ");
            if (length == -1)
                return;
            
            // private float _weight;
            var weight = GetFloatFromInput("Vikt kg: ");
            if (weight == -1 || weight > 20)
                return;
            
            packageService = new CuboidPackage(new Cuboid(width, height, weight, length ));
        }

        if (packageService != null)
        {
            if (packageService.GetPrice() == -1)
            {
                Console.WriteLine("Pris är otillgängligt för det här paketet");
            }
            else
            {
                Console.WriteLine($"Pris: {packageService.GetPrice()}");
            }
            
            Console.WriteLine($"Volym: {packageService.GetVolume()} m^3");
        }
    }

    private static float GetFloatFromInput(string input)
    {
        Console.WriteLine(input);
        
        try
        {
            return float.Parse(Console.ReadLine());
        }
        catch (Exception e)
        {
            return -1;
        }
    }
}