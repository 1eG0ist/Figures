namespace Figures
{
    /*
     * p2 sssssssss p3
     * s             s
     * s             s
     * p1 sssssssss p4
     * p - point in right order
     */
    
    public class Rectangle : IFigure
    {
        private List<float[]> points = new List<float[]>();

        public Rectangle(float[] points)
        {
            for (int i = 0; i < points.Length; i += 2)
            {
                this.points.Add(new float[] {points[i], points[i+1]});
            }
        }

        public float CalcSquare()
        {
            return 2f;
        }

        public float CalcPerimeter()
        {
            return  (points[1][1] - points[0][1]) + (points[2][0] - points[1][0]) + (points[2][1] - points[3][0]) +
                      (points[3][0] - points[0][0]);
        }
    }    
}
