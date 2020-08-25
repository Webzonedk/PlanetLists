using System;
using System.Collections.Generic;
using System.Data;

namespace Planeterne
{
    class Program
    {

        static void Main(string[] args)
        {
            string planetNameHeader = "Planet name";
            string massHeader = "Planet Mass (1024kg)";
            string diameterHeader = "Diameter(km)";
            string densityHeader = "Density (kg/m3)";
            string gravityHeader = "Gravity (m/s2)";
            string rotationPeriodHoursHeader = "Rotation Period (hours)";
            string lengthOfDayHeader = "Length of Day (hours)";
            string distanceFromSunHeader = "Distance from Sun (106 km)";
            string orbitalPeriodHeader = "Orbital Period (days)";
            string orbitalVelocityHeader = "Orbital Velocity (km/s)";
            string meanTemperatureHeader = "Mean Temperature (C)";
            string numberOfMoonsHeader = "Number of Moons";
            string ringSystemsHeader = "Ring System?";

            List<Planet> listname;

            //Creating the Planet objects based on the class Planet
            Planet planet0 = new Planet("Mercury", 0.330, 4879, 5427, 3.7, 1407.6, 4222.6, 57.9, 88, 47.4, 167, 0, false);
            Planet planet1 = new Planet("Venus", 4.87, 12104, 5243, 8.9, -5832.5, 2802.0, 108.2, 224.7, 35.0, 464, 0, false);
            Planet planet2 = new Planet("Earth", 5.97, 12756, 5514, 9.8, 23.9, 24.0, 149.6, 365.2, 29.8, 15, 1, false);
            Planet planet3 = new Planet("Mars", 0.642, 6792, 3933, 3.7, 24.6, 24.7, 227.9, 687.0, 24.1, -65, 2, false);
            Planet planet4 = new Planet("Jupiter", 1898, 142984, -1326, 23.1, 9.9, 9.9, 778.6, 4331, 13.1, -110, 67, true);
            Planet planet5 = new Planet("Saturn", 568, 120536, 687, 9.0, 10.7, 10.7, 1433.5, 10747, 9.7, -140, 62, true);
            Planet planet6 = new Planet("Uranus", 86.8, 51118, 1271, 8.7, -17.2, 17.2, 2872.5, 30589, 6.8, -195, 27, true);
            Planet planet7 = new Planet("Neptune", 102, 49528, 1638, 11.0, 16.1, 16.1, 4495.1, 59.8, 5.4, -200, 14, true);
            Planet planet8 = new Planet("Pluto", 0.0146, 2370, 2095, 0.7, -153.3, 153.3, 5906.4, 90.56, 4.7, -225, 5, false);

            List<Planet> planetCollection = new List<Planet>();

            planetCollection.Add(planet0);
            planetCollection.Add(planet2);
            planetCollection.Add(planet3);
            planetCollection.Add(planet4);
            planetCollection.Add(planet5);
            planetCollection.Add(planet6);
            planetCollection.Add(planet7);
            planetCollection.Add(planet8);





           
            listname = planetCollection;
            PrintCollection();
            Console.WriteLine();

            Console.WriteLine("Inserted Venus at index 1");
            planetCollection.Insert(1, planet1);
            PrintCollection();
            Console.WriteLine();

            Console.WriteLine("Removed Pluto at index 8");
            planetCollection.RemoveAt(8);
            PrintCollection();
            Console.WriteLine();

            Console.WriteLine("Inserted Pluto again at index 8");
            planetCollection.Add(planet8);
            PrintCollection();
            Console.WriteLine();

            int listElements = planetCollection.Count;
            Console.WriteLine($"There are {listElements} planets in the planet list");
            Console.WriteLine();


            //Creating a new list only containing the cold planets below 0 degrees
            List<Planet> coldPlanets = new List<Planet>();

            foreach (var planet in planetCollection)
            {
                double zeroTemp = 0;
                if (planet.MeanTemperature < zeroTemp)
                {
                    coldPlanets.Add(planet);
                }
            }
            Console.WriteLine("Created a new list with cold planets below 0 drees");
            listname = coldPlanets;
            PrintCollection();
            Console.WriteLine();


            //Adding planets with specific diameter to a list and printing them as well
            List<Planet> specificDiameterPlanets = new List<Planet>();

            foreach (var planet in planetCollection)
            {
                double minDiameter = 10000;
                double maxDiameter = 50000;
                if (planet.Diameter > minDiameter && planet.Diameter <maxDiameter)
                {
                    specificDiameterPlanets.Add(planet);
                }
            }

            Console.WriteLine("Created another new list containing planets with diameter above 10000 km. and below 50000 km.");
            listname = specificDiameterPlanets;
            PrintCollection();
            Console.WriteLine();

            Console.WriteLine("Now printing the original list after it has been cleared (I hope it is empty)");
            planetCollection.Clear();
            listname = planetCollection;
            PrintCollection();
            Console.WriteLine();

            Console.WriteLine("Thank you for watching this listing nightmare. Have a great day.");



            void PrintCollection()
            {


                //Listing the output vertical
                Console.Write($"{planetNameHeader,-30}");
                for (int i = 0; i < listname.Count; i++)
                {
                    Console.Write($"{listname[i].Name,12}");
                }
                Console.Write("\n");

                Console.Write($"{massHeader,-30}");
                for (int i = 0; i < listname.Count; i++)
                {
                    Console.Write($"{listname[i].Mass,12}");
                }
                Console.Write("\n");

                Console.Write($"{diameterHeader,-30}");
                for (int i = 0; i < listname.Count; i++)
                {
                    Console.Write($"{listname[i].Diameter,12}");
                }
                Console.Write("\n");

                Console.Write($"{densityHeader,-30}");
                for (int i = 0; i < listname.Count; i++)
                {
                    Console.Write($"{listname[i].Density,12}");
                }
                Console.Write("\n");

                Console.Write($"{gravityHeader,-30}");
                for (int i = 0; i < listname.Count; i++)
                {
                    Console.Write($"{listname[i].Gravity,12}");
                }
                Console.Write("\n");

                Console.Write($"{rotationPeriodHoursHeader,-30}");
                for (int i = 0; i < listname.Count; i++)
                {
                    Console.Write($"{listname[i].RotationPeriodHours,12}");
                }
                Console.Write("\n");

                Console.Write($"{lengthOfDayHeader,-30}");
                for (int i = 0; i < listname.Count; i++)
                {
                    Console.Write($"{listname[i].LengthOfDay,12}");
                }
                Console.Write("\n");

                Console.Write($"{distanceFromSunHeader,-30}");
                for (int i = 0; i < listname.Count; i++)
                {
                    Console.Write($"{listname[i].DistanceFromSun,12}");
                }
                Console.Write("\n");

                Console.Write($"{orbitalPeriodHeader,-30}");
                for (int i = 0; i < listname.Count; i++)
                {
                    Console.Write($"{listname[i].OrbitalPeriod,12}");
                }
                Console.Write("\n");

                Console.Write($"{orbitalVelocityHeader,-30}");
                for (int i = 0; i < listname.Count; i++)
                {
                    Console.Write($"{listname[i].OrbitalVelocity,12}");
                }
                Console.Write("\n");

                Console.Write($"{meanTemperatureHeader,-30}");
                for (int i = 0; i < listname.Count; i++)
                {
                    Console.Write($"{listname[i].MeanTemperature,12}");
                }
                Console.Write("\n");

                Console.Write($"{numberOfMoonsHeader,-30}");
                for (int i = 0; i < listname.Count; i++)
                {
                    Console.Write($"{listname[i].NumberOfMoons,12}");
                }
                Console.Write("\n");

                Console.Write($"{ringSystemsHeader,-30}");
                for (int i = 0; i < listname.Count; i++)
                {
                    Console.Write($"{listname[i].RingSystems,12}");
                }
                Console.Write("\n");


                //This part will list them horisontal but vertical looks more pretty (GUI princess I know)
                //foreach (var planet in planetCollection)
                //{
                //    Console.Write($"{planet.Name,-12}");
                //    Console.Write($"{planet.Mass,20}");
                //    Console.Write($"{planet.Diameter,20}");
                //    Console.Write($"{planet.Density,20}");
                //    Console.Write($"{planet.Gravity,20}");
                //    Console.Write($"{planet.RotationPeriodHours,26}");
                //    Console.Write($"{planet.LengthOfDay,26}");
                //    Console.Write($"{planet.DistanceFromSun,26}");
                //    Console.Write($"{planet.OrbitalPeriod,26}");
                //    Console.Write($"{planet.OrbitalVelocity,26}");
                //    Console.Write($"{planet.MeanTemperature,20}");
                //    Console.Write($"{planet.NumberOfMoons,16}");
                //    Console.Write($"{planet.RingSystems,12}\n");
                //}
            }

        }
    }
}
