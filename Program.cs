using System;

namespace InheritanceIntro
{
  class Program
  {
    static void Main(string[] args)
    {
      var myBike = new Zero();
      // I can still reference the inherited property
      myBike.MainColor = "Black";
      myBike.MaxOccupancy = 2;
      myBike.Name = "Zero";
      myBike.Drive();
      myBike.Turn();
      myBike.Stop();
      Console.WriteLine("-----------------");

      var myTesla = new Tesla();
      myTesla.MainColor = "midnight silver";
      myTesla.MaxOccupancy = 6;
      myTesla.Name = "Tesla";
      myTesla.Drive();
      myTesla.Turn();
      myTesla.Stop();
      Console.WriteLine("-----------------");

      var myCessna = new Cessna();
      myCessna.MainColor = "blue";
      myCessna.MaxOccupancy = 4;
      myCessna.Name = "Cessna";
      myCessna.Drive();
      myCessna.Turn();
      myCessna.Stop();
      Console.WriteLine("-----------------");

      var myRam = new Ram();
      myRam.MainColor = "purple";
      myRam.MaxOccupancy = 4;
      myRam.Name = "Ram";
      myRam.Drive();
      myRam.Turn();
      myRam.Stop();
      Console.WriteLine("-----------------");






    }
  }
}