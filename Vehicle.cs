using System;

namespace InheritanceIntro
{
  public class Vehicle
  {
    public string MainColor { get; set; }
    public int MaxOccupancy { get; set; }

    public string Name { get; set; }

    public virtual void Drive()
    {
      Console.WriteLine("Vroom");
    }

    public virtual void Turn()
    {
      Console.WriteLine("Turn");
    }
    public virtual void Stop()
    {
      Console.WriteLine("Stop");
    }


  }

}