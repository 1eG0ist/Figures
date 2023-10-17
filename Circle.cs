namespace Figures
{
    public class Circle : IFigure
    {
        private float[] center;
        private float radius;
    
        public Circle(float[] info)
        {
            center = new float[] { info[0], info[1] };
            radius = info[2];
        }

        public float CalcSquare()
        {
            return (float)(Math.PI * Math.Pow(radius, 2));
        }

        public float CalcPerimeter()
        {
            return (float)(2 * Math.PI * radius);
        }
    }
};