using System.Numerics;

namespace Shapes
{
    public class Rectangles : Shape2D
    {

        private Vector2 _size;
        public bool isSquare = false;


        public override float Circumference
        {

            get { return 2 * (_size.X + _size.Y); }

        }

        public Rectangles(Vector2 center, Vector2 sida)
        {
            Vector3 vector2till3 = new Vector3();
            vector2till3.X = center.X;
            vector2till3.Y = center.Y;
            vector2till3.Z = 0.0f;
            _center = vector2till3;

            _size = sida;
            _area = _size.X * _size.Y;

            if (_size.X.Equals(_size.Y))
            {
                this.isSquare = true;
            }

        }
        public Rectangles(Vector2 center, float width)
        {
            Vector3 vector2till3 = new Vector3();
            vector2till3.X = center.X;
            vector2till3.Y = center.Y;
            vector2till3.Z = 0.0f;
            _center = vector2till3;

            _area = width * width;

            _size.Y = width;
            _size.X = width;
            this.isSquare = true;
        }

        public override string ToString()
        {
            string returneraRektangel = $"rectangle @({_center.X:f2}, {_center.Y:f2}): w = {this._size.X:f2} h = {this._size.Y:f2}";

            if (isSquare)
            {
                returneraRektangel = $"square @({_center.X:f2}, {_center.Y:f2}): w = {this._size.X:f2} h = {this._size.Y:f2}";
            }

            return returneraRektangel;
        }

    }
}
