using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_auto
{
    public class vehicle
    {
        public string Type { get; set; }
        public string Brand { get; }
        public string Fuel { get; set; }
        public double EngineVolume { get; set; }
        public int FuelLevel { get; set; }
        public int Distance { get; set; }
        public double PneuState { get; set; }

        public vehicle(string brand)
        {
            Type = "Unknown";
            Brand = brand;
            Fuel = "Gas";
            EngineVolume = 1000;
            FuelLevel = 100;
            Distance = 0;
            PneuState = 100;
        }
        public void move()
        {
            FuelLevel -= 1;
            FuelLevel = Math.Max(0, FuelLevel - 1);
            if (FuelLevel > 0)
            {
                Distance += 10;
                PneuState -= 0.01;
            }
        }
        public void refuel()
        {
            if (FuelLevel < 100)
            {
                FuelLevel += 30;
            }
            FuelLevel = Math.Min(100, FuelLevel + 1);

        }
    }
}
