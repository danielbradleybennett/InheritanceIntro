using System;

namespace InheritanceIntro
{
  public class Ram : Vehicle
  { // Gas powered truck
    public double FuelCapacity { get; set; }

    public void RefuelTank() { }

    public override void Drive()
    {
      Console.WriteLine($"The {MainColor} {Name} RummbleRumble!");
    }

    public override void Turn()
    {
      Console.WriteLine($"The {Name} takes a right turn");
    }
    public override void Stop()
    {
      Console.WriteLine($"The {Name} comes to a violent stop");
    }
  }


}