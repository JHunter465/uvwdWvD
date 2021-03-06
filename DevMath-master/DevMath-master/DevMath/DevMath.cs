﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
    public class DevMath
    {
        public static float Lerp(float a, float b, float t)
        {
            return a + (b - a) * t;
        }

        public static float DistanceTraveled(float startVelocity, float acceleration, float time)
        {
            return (float)(startVelocity * time + acceleration * 0.5 * time * time);
        }

        public static float Clamp(float value, float min, float max)
        {
            return value > max ? max : (value < min ? min : value);
        }

        //57.29578f Could've been faster but not exact
        public static float RadToDeg(float angle)
        {
            return angle * (float)(180f / Math.PI);
        }

        ////0.0174532924f Could've been faster but not exact
        public static float DegToRad(float angle)
        {
            return angle * (float)(Math.PI / 180f);
        }
    }
}
