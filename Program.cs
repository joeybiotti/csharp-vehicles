using System;
using System.Linq;
using System.Collections.Generic;


public interface IVehicle
{
    int Wheels { get; set; }
    int Doors { get; set; }
    int PassengerCapacity { get; set; }
    bool Winged { get; set; }
    string TransmissionType { get; set; }
    double EngineVolume { get; set; }
    double MaxWaterSpeed { get; set; }
    double MaxLandSpeed { get; set; }
    double MaxAirSpeed { get; set; }
    void Start();
    void Stop();
    void Drive();
    void Fly();
}

public class JetSki : IVehicle
{
    public int Wheels { get; set; }
    public int Doors { get; set; }
    public int PassengerCapacity { get; set; }
    public bool Winged { get; set; }
    public string TransmissionType { get; set; }
    public double EngineVolume { get; set; }
    public double MaxWaterSpeed { get; set; }
    public double MaxLandSpeed { get; set; }
    public double MaxAirSpeed { get; set; }

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

public class Motorcycle : IVehicle
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

public class Cessna : IVehicle
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


public class Program
{

    public static void Main() {

        // Build a collection of all vehicles that fly
        List <string> Flyers = new List <string>();
        Flyers.Add("Helicopter");
        Flyers.Add("Airplane");
        Flyers.Add("Hot Air Balloon");
        Flyers.Add("Blimp");
        
        Console.WriteLine("\nIn The Air\n");
        // With a single `foreach`, have each vehicle Fly()
        foreach (string fly in Flyers)
        {
            Console.WriteLine(fly);
        }

        // Build a collection of all vehicles that operate on roads
        List<string> OnRoads = new List<string>();
        OnRoads.Add("Car");
        OnRoads.Add("Truck");
        OnRoads.Add("Bicycle");
        OnRoads.Add("GoKart");

        Console.WriteLine("\nOn the Road\n");
        // With a single `foreach`, have each road vehicle Drive()
        foreach(string road in OnRoads)
        {
            Console.WriteLine(road);
        }

        Console.WriteLine("\nOn the Water\n");
        // Build a collection of all vehicles that operate on water
        List<string> OnWater = new List <string>();
        OnWater.Add("Motor Boat");
        OnWater.Add("Sail Boat");
        OnWater.Add("Barge");
        OnWater.Add("Submarine");
        // With a single `foreach`, have each water vehicle Drive()
        foreach(string water in OnWater)
        {
            Console.WriteLine(water);
        }
    }

}