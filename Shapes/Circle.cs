using System.Numerics;

namespace Shapes
{
    public class Circle : Shape2D
    {

        private readonly float _radius;

        public override float Circumference
        {

            get
            {
                return (float)(2 * Math.PI * _radius);

            }

        }

        public Circle(Vector2 center, float radius)
        {
            Vector3 vector2till3 = new Vector3();
            vector2till3.X = center.X;
            vector2till3.Y = center.Y;
            vector2till3.Z = 0.0f;
            _center = vector2till3;

            _radius = radius;
            _area = (float)(Math.PI * (Math.Pow(radius, 2)));
        }

        public override string ToString()
        {
            return $"circle @({_center.X:f2}, {_center.Y:f2}): r = {this._radius:f2}";
        }

    }
}
