namespace Figures
{
    /*
     * p2 sssssssss p3
     * s             s
     * s             s
     * p1 sssssssss p4
     * p - point in right order
     */
    
    internal class Rectangle : Figure
    {
        private new float[][] points = new float[4][];

        public Rectangle(float[] points)
        {
            for (int i = 0; i < points.Length/2; i++)
            {
                this.points[i] = new float[] {points[i*2], points[i*2+1]};
            }
        }

        private new float CalcSquare()
        {
            return (points[1][1] - points[0][1]) * (points[2][0] - points[1][0]);
        }

        private new float CalcPerimeter()
        {
            return  (points[1][1] - points[0][1] + points[2][0] - points[1][0]) * 2;
        }

        public new string ShowInfo()
        {
            return $"Perimeter - {CalcPerimeter()}, Square - {CalcSquare()}";
        }
    }    
}
