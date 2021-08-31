using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeter
{
    class Planet
    {
        // Planet attributes
        private string name;
        private float mass;
        private float diameter;
        private int density;
        private float gravity;
        private float rotationPeriod;
        private float dayLength;
        private float sunDistance;
        private float orbitalPeriod;
        private float orbitalVelocity;
        private int mTemp;
        private int moons;
        private bool ringSystem;

        public Planet()
        {
            // Empty constructor
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }
        public float Mass
        {
            get
            {
                return mass;
            }
            set
            {
                this.mass = value;
            }
        }
        public float Diameter
        {
            get
            {
                return diameter;
            }
            set
            {
                this.diameter = value;
            }
        }
        public int Density
        {
            get
            {
                return density;
            }
            set
            {
                this.density = value;
            }
        }
        public float Gravity
        {
            get
            {
                return gravity;
            }
            set
            {
                this.gravity = value;
            }
        }
        public float RotationPeriod
        {
            get
            {
                return rotationPeriod;
            }
            set
            {
                this.rotationPeriod = value;
            }
        }
        public float DayLength
        {
            get
            {
                return dayLength;
            }
            set
            {
                this.dayLength = value;
            }
        }
        public float SunDistance
        {
            get
            {
                return sunDistance;
            }
            set
            {
                this.sunDistance = value;
            }
        }
        public float OrbitalPeriod
        {
            get
            {
                return orbitalPeriod;
            }
            set
            {
                this.orbitalPeriod = value;
            }
        }
        public float OrbitalVelocity
        {
            get
            {
                return orbitalVelocity;
            }
            set
            {
                this.orbitalVelocity = value;
            }
        }
        public int MTemp
        {
            get
            {
                return mTemp;
            }
            set
            {
                this.mTemp = value;
            }
        }
        public int Moons
        {
            get
            {
                return moons;
            }
            set
            {
                this.moons = value;
            }
        }
        public bool RingSystem
        {
            get
            {
                return ringSystem;
            }
            set
            {
                this.ringSystem = value;
            }
        }
    }
}
