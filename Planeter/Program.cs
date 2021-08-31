using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Planet> solarSystem = new List<Planet> ();


            Planet mercury = new Planet();
            mercury.Name = "Mercury";
            mercury.Mass = 0.33f;
            mercury.Diameter = 4879f;
            mercury.Density = 5427;
            mercury.Gravity = 3.7f;
            mercury.RotationPeriod = 1407.6f;
            mercury.DayLength = 4222.6f;
            mercury.SunDistance = 57.9f;
            mercury.OrbitalPeriod = 88.0f;
            mercury.OrbitalVelocity = 47.4f;
            mercury.MTemp = 167;
            mercury.Moons = 0;
            mercury.RingSystem = false;
            Planet venus = new Planet();
            venus.Name = "Venus";
            venus.Mass = 4.87f;
            venus.Diameter = 12104f;
            venus.Density = 5243;
            venus.Gravity = 8.9f;
            venus.RotationPeriod = -5832.5F;
            venus.DayLength = 2802.0f;
            venus.SunDistance = 108.2f;
            venus.OrbitalPeriod = 224.7f;
            venus.OrbitalVelocity = 35.0f;
            venus.MTemp = 464;
            venus.Moons = 0;
            venus.RingSystem = false;
            Planet earth = new Planet();
            earth.Name = "Earth";
            earth.Mass = 5.97f;
            earth.Diameter = 12756f;
            earth.Density = 5514;
            earth.Gravity = 9.8f;
            earth.RotationPeriod = 23.9f;
            earth.DayLength = 24.0f;
            earth.SunDistance = 149.6f;
            earth.OrbitalPeriod = 365.2f;
            earth.OrbitalVelocity = 29.8f;
            earth.MTemp = 15;
            earth.Moons = 1;
            earth.RingSystem = false;
            Planet mars = new Planet();
            mars.Name = "Mars";
            mars.Mass = 0.642f;
            mars.Diameter = 6792f;
            mars.Density = 3933;
            mars.Gravity = 3.7f;
            mars.RotationPeriod = 24.6f;
            mars.DayLength = 24.7f;
            mars.SunDistance = 227.9f;
            mars.OrbitalPeriod = 687.0f;
            mars.OrbitalVelocity = 24.1f;
            mars.MTemp = -65;
            mars.Moons = 2;
            mars.RingSystem = false;
            Planet jupiter = new Planet();
            jupiter.Name = "Jupiter";
            jupiter.Mass = 1898f;
            jupiter.Diameter = 142984f;
            jupiter.Density = 1326;
            jupiter.Gravity = 23.1f;
            jupiter.RotationPeriod = 9.9f;
            jupiter.DayLength = 9.9f;
            jupiter.SunDistance = 778.6f;
            jupiter.OrbitalPeriod = 4331f;
            jupiter.OrbitalVelocity = 13.1f;
            jupiter.MTemp = -110;
            jupiter.Moons = 67;
            jupiter.RingSystem = true;
            Planet saturn = new Planet();
            saturn.Name = "Saturn";
            saturn.Mass = 568f;
            saturn.Diameter = 120536f;
            saturn.Density = 687;
            saturn.Gravity = 9.0f;
            saturn.RotationPeriod = 10.7f;
            saturn.DayLength = 10.7f;
            saturn.SunDistance = 1433.5f;
            saturn.OrbitalPeriod = 10747f;
            saturn.OrbitalVelocity = 9.7f;
            saturn.MTemp = -140;
            saturn.Moons = 62;
            saturn.RingSystem = true;
            Planet uranus = new Planet();
            uranus.Name = "Uranus";
            uranus.Mass = 86.8f;
            uranus.Diameter = 51118f;
            uranus.Density = 1271;
            uranus.Gravity = 8.7f;
            uranus.RotationPeriod = -17.2f;
            uranus.DayLength = 10.7f;
            uranus.SunDistance = 2872.5f;
            uranus.OrbitalPeriod = 30589f;
            uranus.OrbitalVelocity = 6.8f;
            uranus.MTemp = -195;
            uranus.Moons = 27;
            uranus.RingSystem = true;
            Planet neptune = new Planet();
            neptune.Name = "Neptune";
            neptune.Mass = 102f;
            neptune.Diameter = 49528f;
            neptune.Density = 1638;
            neptune.Gravity = 11.0f;
            neptune.RotationPeriod = 16.1f;
            neptune.DayLength = 16.1f;
            neptune.SunDistance = 4495.1f;
            neptune.OrbitalPeriod = 59.8f;
            neptune.OrbitalVelocity = 5.4f;
            neptune.MTemp = -200;
            neptune.Moons = 14;
            neptune.RingSystem = true;
            Planet pluto = new Planet();
            pluto.Name = "Pluto";
            pluto.Mass = 0.0146f;
            pluto.Diameter = 2370f;
            pluto.Density = 2095;
            pluto.Gravity = 0.7f;
            pluto.RotationPeriod = -153.3f;
            pluto.DayLength = 153.3f;
            pluto.SunDistance = 5906.4f;
            pluto.OrbitalPeriod = 90.56f;
            pluto.OrbitalVelocity = 4.7f;
            pluto.MTemp = -225;
            pluto.Moons = 5;
            pluto.RingSystem = false;



            solarSystem.Add(mercury);
            solarSystem.Add(earth);
            solarSystem.Add(mars);
            solarSystem.Add(jupiter);
            solarSystem.Add(saturn);
            solarSystem.Add(uranus);
            solarSystem.Add(neptune);
            solarSystem.Add(pluto);

            foreach (Planet massSphere in solarSystem)
            {
                Console.WriteLine(massSphere.Name);
            }
            Console.WriteLine();

            // Adding venus
            
            solarSystem.Insert(1, venus);

            Console.WriteLine("Adding venus...");
            foreach (Planet massSphere in solarSystem)
            {
                Console.WriteLine(massSphere.Name);
            }
            Console.WriteLine();


            // Removing pluto
            Planet temp = new Planet();
            Console.WriteLine("Removing PLuto...");
            foreach (Planet massSphere in solarSystem)
            {
                if (massSphere.Name == "Pluto")
                {
                    temp = massSphere;
                }
            }
            solarSystem.Remove(temp);

            foreach (Planet massSphere in solarSystem)
            {
                Console.WriteLine(massSphere.Name);
            }
            Console.WriteLine();

            // Re-Adding pluto
            Console.WriteLine("Re-adding pluto");
            solarSystem.Add(pluto);
            Console.WriteLine();

            // Find number og planets in Solar Solarsystem
            Console.WriteLine($"Numbe of planets in the solar system: {solarSystem.Count()}\n");

            //Filtering by temperature
            List<Planet> subZeroPlanets = new List<Planet>();
            foreach (Planet massSphere in solarSystem)
            {
                if(massSphere.MTemp > 0)
                {
                    subZeroPlanets.Add(massSphere);
                }
            }
            Console.WriteLine("Planets under 0 degrees");
            foreach (Planet massSphere in subZeroPlanets)
            {
                Console.WriteLine(massSphere.Name);
            }
            Console.WriteLine();


            // Filtering by diameter
            List<Planet> mediumSizedPlanets = new List<Planet>();
            foreach (Planet massSphere in solarSystem)
            {
                if (massSphere.Diameter > 10000 & massSphere.Diameter < 50000)
                {
                    mediumSizedPlanets.Add(massSphere);
                }
            }
            Console.WriteLine("Medium sized planets");
            foreach (Planet massSphere in mediumSizedPlanets)
            {
                Console.WriteLine(massSphere.Name);
            }
            Console.WriteLine();

            mediumSizedPlanets.Clear();

            Console.ReadKey();
        }
    }
}
