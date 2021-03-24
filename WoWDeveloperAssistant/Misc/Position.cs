﻿using System;

namespace WoWDeveloperAssistant.Misc
{
    [Serializable]
    public struct Position
    {
        public bool Equals(Position other)
        {
            return x.Equals(other.x) && y.Equals(other.y) && z.Equals(other.z) && orientation.Equals(other.orientation);
        }

        public override bool Equals(object obj)
        {
            return obj is Position other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = x.GetHashCode();
                hashCode = (hashCode * 397) ^ y.GetHashCode();
                hashCode = (hashCode * 397) ^ z.GetHashCode();
                hashCode = (hashCode * 397) ^ orientation.GetHashCode();
                return hashCode;
            }
        }

        public float x;
        public float y;
        public float z;
        public float orientation;

        public Position(float x, float y, float z)
        { this.x = x; this.y = y; this.z = z; orientation = 0.0f; }

        public Position(float x, float y, float z, float o)
        { this.x = x; this.y = y; this.z = z; orientation = o; }

        public bool IsValid()
        {
            return x != 0.0f && y != 0.0f;
        }
        public float GetDistance(Position comparePos)
        {
            return (float)Math.Sqrt(Math.Pow((x - comparePos.x), 2) + Math.Pow((y - comparePos.y), 2) + Math.Pow((z - comparePos.z), 2));
        }

        public static double GetExactDist2dSq(Position mainPos, Position comparePos)
        {
            double dx = mainPos.x - comparePos.x; double dy = mainPos.y - comparePos.y;
            return dx * dx + dy * dy;
        }

        public float GetExactDist2d(Position comparePos)
        {
            return (float)Math.Sqrt(GetExactDist2dSq(this, comparePos));
        }

        public static Position operator -(Position firstPos, Position secondPos)
        {
            float x = firstPos.x - secondPos.x;
            float y = firstPos.y - secondPos.y;
            float z = firstPos.z - secondPos.z;

            return new Position(x, y, z);
        }

        public static bool operator ==(Position firstPos, Position secondPos)
        {
            return firstPos.x == secondPos.x && firstPos.y == secondPos.y && firstPos.z == secondPos.z && firstPos.orientation == secondPos.orientation;
        }

        public static bool operator !=(Position firstPos, Position secondPos)
        {
            return firstPos.x != secondPos.x || firstPos.y != secondPos.y || firstPos.z != secondPos.z || firstPos.orientation != secondPos.orientation;
        }
    }
}
