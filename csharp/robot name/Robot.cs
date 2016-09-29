using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotName
{
    class Robot
    {
        public string Name { get; set; }

        public Robot()
        {
            Name = RobotNameFactory.Create();
        }

        public void Reset()
        {
            Name = RobotNameFactory.Create();
        }
    }

    static class RobotNameFactory
    {
        static int _NameSeed = 0;

        public static string Create()
        {
            _NameSeed++;
            return string.Format("{0}{1}", "AA", _NameSeed.ToString().PadLeft(3, '0'));
        }
    }
}