using Shapes;

Shape[] shapes = new Shape[21];


for (int i = 0; i < 21; i++)
{
    shapes[i] = Shape.GenerateShape();
}

float totalArea = 0;

for (int i = 0; i < shapes.Length - 1; i++)
{
    Console.WriteLine($"{i + 1}: {shapes[i]}");
    totalArea += shapes[i].Area;
}
totalArea /= shapes.Length - 1;
totalArea = (float)Math.Round(totalArea, 1);
Console.WriteLine($"\nMedelvärdet på arean är: {totalArea} enheter");