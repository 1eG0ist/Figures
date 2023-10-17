namespace Figures
{
    public class Square : IFigure
    {
        private float[][] points = new float[2][];

        public Square(float[] points)
        {
            for (int i = 0; i < points.Length/2; i++)
            {
                this.points[i] = new float[] { points[i * 2], points[i * 2 + 1] };
            }
        }

        public float CalcSquare()
        {
            return (float)Math.Pow(points[1][1] - points[0][1], 2);
        }

        public float CalcPerimeter()
        {
            return (points[1][1] - points[0][1]) * 4;
        }
    }
};