using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
    public class Line
    {
        public Vector2 Position
        {
            get; set;
        }

        public Vector2 Direction
        {
            get; set;
        }

        public float Length
        {
            get; set;
        }

        public bool IntersectsWith(Circle circle)
        {
            float cX = circle.Position.x;
            float cY = circle.Position.y;
            float radius = circle.Radius;
            float lineX = Position.x;
            float lineY = Position.y;
            float line2X = Position.x + (Direction.x * Length);
            float line2Y = Position.x + (Direction.y * Length);
            float determinant;
            float distanceX = line2X - lineX;
            float distanceY = line2Y - lineY;

            float A = distanceX * distanceX + distanceY * distanceY;
            float B = 2 * (distanceX * (lineX - cX) + distanceY * (line2Y - cY));
            float C = (lineX - cX) * (lineX - cX) + (lineY - cY) * (lineY - cY) - radius * radius;

            determinant = B * B - 4 * A * C;
            if(A< 0 || determinant < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
