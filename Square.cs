namespace Figures
{
    internal class Square : Figure
    {
        private new float[][] points = new float[2][];

        public Square(float[] points)
        {
            for (int i = 0; i < points.Length/2; i++)
            {
                this.points[i] = new float[] { points[i * 2], points[i * 2 + 1] };
            }
        }

        private new float CalcSquare()
        {
            return (float)Math.Pow(points[1][1] - points[0][1], 2);
        }

        private new float CalcPerimeter()
        {
            return (points[1][1] - points[0][1]) * 4;
        }
        
        public new string ShowInfo()
        {
            return $"Perimeter - {CalcPerimeter()}, Square - {CalcSquare()}";
        }
    }
};