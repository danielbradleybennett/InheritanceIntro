using System;

namespace InheritanceIntro
{
  public class Cessna : Vehicle
  { // Propellor light aircraft
    public double FuelCapacity { get; set; }

    public void RefuelTank() { }

    public override void Drive()
    {
      Console.WriteLine($"The {MainColor} {Name} Brrrrrrr");
    }

    public override void Turn()
    {
      Console.WriteLine($"The {Name} takes a left turn");
    }
    public override void Stop()
    {
      Console.WriteLine($"The {Name} stops abruptly");
    }


  }

}