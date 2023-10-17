namespace Figures
{
    public class Pyramid : IFigure
    {
        private bool is_triangle_bottom;
        private float[][] points;
        private float[] center = new float[2];
        private float height;
        
        public Pyramid(float[] points, float height)
        {
            if (points.Length == 6)
            {
                this.points = new float[3][];
                for (int i = 0; i < points.Length/2; i++)
                {
                    this.points[i] = new float[] { points[i * 2], points[i * 2 + 1] };
                }
                is_triangle_bottom = true;
                center[0] = (points[0] + points[2] + points[4]) / 3;
                center[1] = (points[1] + points[3] + points[5]) / 3;
            }
            else
            {
                this.points = new float[4][];
                for (int i = 0; i < points.Length/2; i++)
                {
                    this.points[i] = new float[] { points[i * 2], points[i * 2 + 1] };
                }
                is_triangle_bottom = false;
                center[0] = (points[3] - points[1]) / 2;
                center[1] = (points[0] - points[6]) / 2;
            }

            this.height = height;
        }

        private float CalcSquare()
        {
            if (is_triangle_bottom)
            {
                float[] sides = new float[]
                {
                    (float)Math.Sqrt(Math.Pow(points[1][0] - points[0][0], 2) + Math.Pow(points[1][1] - points[0][1], 2)),
                    (float)Math.Sqrt(Math.Pow(points[2][0] - points[1][0], 2) + Math.Pow(points[1][1]-points[2][1], 2)),
                    (float)Math.Sqrt(Math.Pow(points[2][0] - points[0][0], 2) + Math.Pow(points[2][1] - points[0][1], 2))
                };
                float[] diags = CalcTriangleDiags();
                float p = sides.Sum()/2;
                float s = (float)Math.Sqrt(p * (p-sides[0]) * (p-sides[1]) * (p-sides[2]));
                float p1 = (sides[0] + diags[0] + diags[1]) / 2;
                float p2 = (sides[1] + diags[1] + diags[2]) / 2;
                float p3 = (sides[2] + diags[0] + diags[2]) / 2;
                float s1 = (float)Math.Sqrt(p1 * (p1-sides[0]) * (p1-diags[0]) * (p1-diags[1]));
                float s2 = (float)Math.Sqrt(p2 * (p2-sides[1]) * (p2-diags[1]) * (p2-diags[2]));
                float s3 = (float)Math.Sqrt(p3 * (p3-sides[2]) * (p3-diags[0]) * (p3-diags[2]));
                return s + s1 + s2 + s3;
            }

            float side_1 = Math.Abs(points[1][1] - points[0][1]);
            float side_2 = Math.Abs(points[2][0] - points[1][0]);
            float diag = CalcRectSquareDiag();
            float p11 = (side_1 + diag * 2) / 2;
            float p22 = (side_2 + diag * 2) / 2;
            float s11 = (float)Math.Sqrt(p11 * (p11 - side_1) * (p11 - diag) * (p11 - diag));
            float s22 = (float)Math.Sqrt(p22 * (p22 - side_2) * (p22 - diag) * (p22 - diag));
            return side_1 * side_2 + s11 * 2 + s22 * 2;
        }

        private float CalcPerimeter()
        {
            if (is_triangle_bottom)
            {
                float[] sides = new float[]
                {
                    (float)Math.Sqrt(Math.Pow(points[1][0] - points[0][0], 2) + Math.Pow(points[1][1] - points[0][1], 2)),
                    (float)Math.Sqrt(Math.Pow(points[2][0] - points[1][0], 2) + Math.Pow(points[1][1]-points[2][1], 2)),
                    (float)Math.Sqrt(Math.Pow(points[2][0] - points[0][0], 2) + Math.Pow(points[2][1] - points[0][1], 2))
                };
                float p = sides.Sum();
                float[] diags = CalcTriangleDiags();
                return p + diags.Sum();
            }

            float side_1 = Math.Abs(points[1][1] - points[0][1]);
            float side_2 = Math.Abs(points[2][0] - points[1][0]);
            float diag = CalcRectSquareDiag();
            return side_1 * 2 + side_2 * 2 + diag * 4;
        }

        private float CalcVolume()
        {
            if (is_triangle_bottom)
            {
                float[] sides = new float[]
                {
                    (float)Math.Sqrt(Math.Pow(points[1][0] - points[0][0], 2) + Math.Pow(points[1][1] - points[0][1], 2)),
                    (float)Math.Sqrt(Math.Pow(points[2][0] - points[1][0], 2) + Math.Pow(points[1][1]-points[2][1], 2)),
                    (float)Math.Sqrt(Math.Pow(points[2][0] - points[0][0], 2) + Math.Pow(points[2][1] - points[0][1], 2))
                };
                float p = sides.Sum() / 2;
                float s = (float)Math.Sqrt(p * (p-sides[0]) * (p-sides[1]) * (p-sides[2]));
                return s * height / 3;
            }
            return (points[1][1] - points[0][1]) * (points[2][0] - points[1][0]) / 3 * height;
        }

        private float[] CalcTriangleDiags()
        {
            float bottom_diag_1 = (float)Math.Sqrt(Math.Pow(center[0] - points[0][0], 2) + Math.Pow(center[1] - points[0][1], 2));
            float bottom_diag_2 = (float)Math.Sqrt(Math.Pow(points[1][0] - center[0], 2) + Math.Pow(points[1][1] - center[1], 2));
            float bottom_diag_3 = (float)Math.Sqrt(Math.Pow(points[2][0] - center[0], 2) + Math.Pow(center[1] - points[2][1], 2));
            float diag_1 = (float)Math.Sqrt(Math.Pow(bottom_diag_1, 2) + Math.Pow(height, 2));
            float diag_2 = (float)Math.Sqrt(Math.Pow(bottom_diag_2, 2) + Math.Pow(height, 2));
            float diag_3 = (float)Math.Sqrt(Math.Pow(bottom_diag_3, 2) + Math.Pow(height, 2));
            return new float[] { diag_1, diag_2, diag_3 };
        }

        private float CalcRectSquareDiag()
        {
            float side_1 = Math.Abs(points[1][1] - points[0][1]);
            float side_2 = Math.Abs(points[2][0] - points[1][0]);
            float bottom_diag = (float)Math.Sqrt(Math.Pow(side_1, 2) + Math.Pow(side_2, 2))/2;
            return (float)Math.Sqrt(Math.Pow(bottom_diag, 2) + Math.Pow(height, 2));
        }

        public string ShowInfo()
        {
            return $"Square - {CalcSquare()}, Perimeter - {CalcPerimeter()}, Volume - {CalcVolume()}";
        }
    }
};
