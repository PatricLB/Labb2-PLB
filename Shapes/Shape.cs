using System.Drawing;
using System.Numerics;

namespace Shapes
{
    public abstract class Shape
    {
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }

        public static Shape GenerateShape()
        {
            Random randomShape = new Random();
            Random randomSize = new Random();
            float randomX = randomSize.NextSingle() * 10;
            float randomY = randomSize.NextSingle() * 10;
            float randomZ = randomSize.NextSingle() * 10;
            float randomWidth = randomSize.NextSingle() * 10;
            float randomInputRadie = randomSize.Next(1, 15);

            Shapes form = (Shapes)randomShape.Next(0, 6);

            Vector2 randomVector2Position = new Vector2(randomX, randomY);
            Vector2 randomVector2WidthLength = new Vector2(randomX, randomY);
            Vector3 randomVector3Position = new Vector3(randomX, randomY, randomZ);
            Vector3 randomVector3WidthLengthDepth = new Vector3(randomX, randomY, randomZ);


            if (form == Shapes.circle)
            {
                return new Circle(randomVector2Position, randomInputRadie);
            }
            else if (form == Shapes.rectangle)
            {
                return new Rectangles(randomVector2Position, randomVector2WidthLength);
            }
            else if (form == Shapes.square)
            {
                return new Rectangles(randomVector2Position, randomWidth);
            }
            else if (form == Shapes.cuboid)
            {
                return new Cuboid(randomVector3Position, randomVector3WidthLengthDepth);
            }
            else if (form == Shapes.cube)
            {
                return new Cuboid(randomVector3Position, randomWidth);
            }
            else
            {
                return new Sphere(randomVector3Position, randomInputRadie);
            }

        }


    }

    enum Shapes
    {
        circle,
        rectangle,
        square,
        cuboid,
        cube,
        sphere
    }
}