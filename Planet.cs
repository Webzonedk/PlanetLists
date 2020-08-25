using System;
using System.Collections.Generic;
using System.Text;

namespace Planeterne
{
    class Planet
    {

        private string name;
        private double mass;
        private double diameter;
        private double density;
        private double gravity;
        private double rotationPeriodHours;
        private double lengthOfDay;
        private double distanceFromSun;
        private double orbitalPeriod;
        private double orbitalVelocity;
        private double meanTemperature;
        private int numberOfMoons;
        private bool ringSystems;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Mass
        {
            get { return mass; }
            set { mass = value; }
        }

        public double Diameter
        {
            get { return diameter; }
            set { diameter = value; }
        }

        public double Density
        {
            get { return density; }
            set { density = value; }
        }

        public double Gravity
        {
            get { return gravity; }
            set { gravity = value; }
        }

        public double RotationPeriodHours
        {
            get { return rotationPeriodHours; }
            set { rotationPeriodHours = value; }
        }

        public double LengthOfDay
        {
            get { return lengthOfDay; }
            set { lengthOfDay = value; }
        }

        public double DistanceFromSun
        {
            get { return distanceFromSun; }
            set { distanceFromSun = value; }
        }

        public double OrbitalPeriod
        {
            get { return orbitalPeriod; }
            set { orbitalPeriod = value; }
        }

        public double OrbitalVelocity
        {
            get { return orbitalVelocity; }
            set { orbitalVelocity = value; }
        }

        public double MeanTemperature
        {
            get { return meanTemperature; }
            set { meanTemperature = value; }
        }

        public int NumberOfMoons
        {
            get { return numberOfMoons; }
            set { numberOfMoons = value; }
        }

        public string RingSystems
        {
            get
            {
                if (ringSystems == true)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }
            }
            // set { ringSystems = value; }
        }






        public Planet
            (
            string name,
            double mass,
            double diameter,
            double density,
            double gravity,
            double rotationPeriodHours,
            double lengthOfDay,
            double distanceFromSun,
            double orbitalPeriod,
            double orbitalVelocity,
            double meanTemperature,
            int numberOfMoons,
            bool ringSystems
            )
        {
            Name = name;
            Mass = mass;
            Diameter = diameter;
            Density = density;
            Gravity = gravity;
            RotationPeriodHours = rotationPeriodHours;
            LengthOfDay = lengthOfDay;
            DistanceFromSun = distanceFromSun;
            OrbitalPeriod = orbitalPeriod;
            OrbitalVelocity = orbitalVelocity;
            MeanTemperature = meanTemperature;
            NumberOfMoons = numberOfMoons;
            //RingSystems = ringSystems;
        }

    }
}
