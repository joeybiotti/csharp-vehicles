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
    void Drive();

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
}

public interface IWater
{
    double MaxWaterSpeed { get; set; }
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

public class Motorcycle : IVehicle, IDriver
{
    public int Wheels { get; set; } = 2;
    public int Doors { get; set; } = 0;
    public int PassengerCapacity { get; set; }
    public bool Winged { get; set; } = false;
    public string TransmissionType { get; set; } = "Manual";
    public double EngineVolume { get; set; } = 1.3;
    public double MaxWaterSpeed { get; set; }
    public double MaxLandSpeed { get; set; } = 160.4;
    public double MaxAirSpeed { get; set; }

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

    void IVehicle.Drive()
    {
        throw new NotImplementedException();
    }

    void IVehicle.Start()
    {
        throw new NotImplementedException();
    }

    void IVehicle.Stop()
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


public class Program
{

    public static void Main() {

        // Build a collection of all vehicles that fly
 
        // With a single `foreach`, have each vehicle Fly()



        // Build a collection of all vehicles that operate on roads

        // With a single `foreach`, have each road vehicle Drive()



        // Build a collection of all vehicles that operate on water
        
        // With a single `foreach`, have each water vehicle Drive()
    }

}
