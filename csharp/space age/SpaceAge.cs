using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceAgeProject
{
    class SpaceAge
    {
        public double Seconds { get; set; }

        public SpaceAge(double seconds)
        {
            Seconds = seconds;
        }

        internal double OnEarth()
        {
            return Seconds / 31557600;
        }

        internal double OnMercury()
        {
            return OnEarth() / 0.2408467;
        }

        internal double OnVenus()
        {
            return OnEarth() / 0.61519726;
        }

        internal double OnMars()
        {
            return OnEarth() / 1.8808158;
        }

        internal double OnJupiter()
        {
            return OnEarth() / 11.862615;
        }

        internal double OnSaturn()
        {
            return OnEarth() / 29.447498;
        }

        internal double OnUranus()
        {
            return OnEarth() / 84.016846;
        }

        internal double OnNeptune()
        {
            return OnEarth() / 164.79132;
        }
    }
}