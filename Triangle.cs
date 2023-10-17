namespace Figures
{
    /*
     *      p2
     *
     *            p3
     * p1
     */
    
    public class Triangle : IFigure
    {
        private float[][] points = new float[3][];

        public Triangle(float[] points)
        {
            for (int i = 0; i < points.Length/2; i++)
            {
                this.points[i] = new float[] { points[i * 2], points[i * 2 + 1] };
            }
        }
        
        public float CalcSquare()
        {
            float[] sides = CalcSides();
            float p = CalcPerimeter() / 2;
            return (float)Math.Sqrt(p * (p-sides[0]) * (p-sides[1]) * (p-sides[2]));
        }

        public float CalcPerimeter()
        {
            return CalcSides().Sum();
        }

        public float[] CalcSides()
        {
            float[] sides = new float[]
            {
                (float)Math.Sqrt(Math.Pow(points[1][0] - points[0][0], 2) + Math.Pow(points[1][1] - points[0][1], 2)),
                (float)Math.Sqrt(Math.Pow(points[2][0] - points[1][0], 2) + Math.Pow(points[1][1]-points[2][1], 2)),
                (float)Math.Sqrt(Math.Pow(points[2][0] - points[0][0], 2) + Math.Pow(points[2][1] - points[0][1], 2))
            };
            return sides;
        }
    }
};