using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Cuboid : Shape3D
    {

        public bool isCube = false;
        private Vector3 _side;

        public override float Volume

        {
            get { return _volume = _side.X * _side.Y * _side.Z; }

        }
        public float Begränsningsarea
        {
            get
            {
                return 2 * ((_side.X * _side.Z) + (_side.X * _side.Y) + (_side.Z * _side.Y));
            }
        }


        public Cuboid(Vector3 center, Vector3 size)
        {

            _center = center;
            _side = size;
            _area = 2 * ((_side.X * _side.Z) + (_side.X * _side.Y) + (_side.Z * _side.Y));

            if (_side.X.Equals(_side.Y) && _side.Y.Equals(_side.Z))
            {
                this.isCube = true;
            }


        }
        public Cuboid(Vector3 center, float width)
        {
            _center = center;

            _side.X = width;
            _side.Y = width;
            _side.Z = width;

            this.isCube = true;
            _area = 4 * width;

        }

        public override string ToString()
        {
            string returneraCuboid = $"cubiod @({_center:f2}): w = {_side.X:f2}, H = {_side.Y:f2}, l = {_side.Z:f2}";

            if (isCube)
            {
                returneraCuboid = $"cube @({_center:f2}): w = {_side.X:f2}, H = {_side.Y:f2}, l = {_side.Z:f2}";
            }

            return returneraCuboid;
        }

    }
}
