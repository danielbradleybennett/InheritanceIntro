using System;

namespace InheritanceIntro
{
  public class Zero : Vehicle
  { // Electric motorcycle
    public double BatteryKWh { get; set; }

    public void ChargeBattery() { }

    public override void Drive()
    {
      Console.WriteLine($"The {MainColor} {Name} Whooosh");
    }

    public override void Turn()
    {
      Console.WriteLine($"The {Name} makes a fast left");
    }
    public override void Stop()
    {
      Console.WriteLine($"The {Name} comes to a hault");
    }

  }

}