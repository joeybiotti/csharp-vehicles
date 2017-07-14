using System;
using System.Linq;
using System.Collections.Generic;


public interface IVehicle
{
    int Doors { get; set; }
    int PassengerCapacity { get; set; }
    string TransmissionType { get; set; }
    double EngineVolume { get; set; }
    void Start();
    void Stop();

}

public interface IFlyer
{
    bool Winged { get; set; }
    double MaxAirSpeed { get; set; }
    double MaxLandSpeed { get; set; }
    int Wheels { get; set; }
    void Fly();

}

public interface IDriver
{
    int Wheels { get; set; }
    double MaxWaterSpeed { get; set; }
    void Drive();
}

public interface IWater
{
    double MaxWaterSpeed { get; set; }
    void Drive();
}

public class JetSki : IVehicle, IWater
{
    public int Doors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int PassengerCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string TransmissionType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double EngineVolume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double MaxWaterSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Drive()
    {
        Console.WriteLine("The jetski zips through the waves with the greatest of ease");
    }

    public void Fly()
    {
        throw new NotImplementedException();
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class Oceanliner : IVehicle, IWater
{
    public int Doors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int PassengerCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string TransmissionType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double EngineVolume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double MaxWaterSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Drive()
    {
        Console.WriteLine("An Oceanliner is nothing more than a floating hotel...");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class Motorcycle : IVehicle, IDriver
{
    public int Doors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int PassengerCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string TransmissionType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double EngineVolume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int Wheels { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double MaxWaterSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Drive()
    {
        Console.WriteLine("The motorcycle screams down the highway");
    }

    public void Fly()
    {
        throw new NotImplementedException();
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class GoKart : IVehicle, IDriver
{
    public int Wheels { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double MaxWaterSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int Doors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int PassengerCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string TransmissionType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double EngineVolume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Drive()
    {
        Console.WriteLine("The GoKart zips around the track");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class Cessna : IVehicle, IFlyer
{
  public int Wheels { get; set; } = 3;
  public int Doors { get; set; } = 3;
  public int PassengerCapacity { get; set; } = 113;
  public bool Winged { get; set; } = true;
  public string TransmissionType { get; set; } = "None";
  public double EngineVolume { get; set; } = 31.1;
  public double MaxWaterSpeed { get; set; }
  public double MaxLandSpeed { get; set; }
  public double MaxAirSpeed { get; set; } = 309.0;

  public void Drive()
  {
    throw new NotImplementedException();
  }

  public void Fly()
  {
    Console.WriteLine("The Cessna effortlessly glides through the clouds like a gleaming god of the Sun");
  }

  public void Start()
  {
    throw new NotImplementedException();
  }

  public void Stop()
  {
    throw new NotImplementedException();
  }
}

public class FighterJet : IVehicle, IFlyer
{
    public int Doors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int PassengerCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string TransmissionType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double EngineVolume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public bool Winged { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double MaxAirSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double MaxLandSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int Wheels { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Drive()
    {
        throw new NotImplementedException();
    }

    public void Fly()
    {
        Console.WriteLine("The Fighter Jet broke the sound barrier");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}


public class Program
{

    public static void Main() {

        // Build a collection of all vehicles that fly
            Cessna aCessna = new Cessna();
            FighterJet aFighterJet = new FighterJet();

            List <IFlyer> Flyers = new List <IFlyer>();
            Flyers.Add(aCessna);
            Flyers.Add(aFighterJet);
        // With a single `foreach`, have each vehicle Fly()
            foreach(var air in Flyers)
            {
                air.Fly();
            }

        // Build a collection of all vehicles that operate on roads
            GoKart aGoKart = new GoKart();
            Motorcycle aMotorcycle = new Motorcycle();

            List <IDriver> Drivers = new List <IDriver>();
            Drivers.Add(aGoKart);
            Drivers.Add(aMotorcycle);

        // With a single `foreach`, have each road vehicle Drive()
            foreach(var road in Drivers)
            {
                road.Drive();
            }

        // Build a collection of all vehicles that operate on water
            Oceanliner anOceanliner = new Oceanliner();
            JetSki aJetSki = new JetSki();

            List <IWater> Boats = new List <IWater>();
            Boats.Add(anOceanliner);
            Boats.Add(aJetSki);
        
        // With a single `foreach`, have each water vehicle Drive()
            foreach(var water in Boats)
            {
                water.Drive();
            }
    }

}
