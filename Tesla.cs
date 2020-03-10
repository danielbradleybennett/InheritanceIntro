using System;

namespace InheritanceIntro
{
  public class Tesla : Vehicle
  { // Electric car
    public double BatteryKWh { get; set; }

    public void ChargeBattery() { }

    public override void Drive()
    {
      Console.WriteLine($"The {MainColor} {Name} Zoom!!");
    }

    public override void Turn()
    {
      Console.WriteLine($"The {Name} makes a sharp right");
    }
    public override void Stop()
    {
      Console.WriteLine($"The {Name} screeches to a stop");
    }
  }

}
