namespace Geometry
{
    public static class Area
    {
        public static double Triangle(double sideA, double sideB, double sideC)
        {
            try
            {
                //Проверка введенных значений
                if (sideA <= 0 || sideB <= 0 || sideC<=0 )
                    throw new ArgumentException("Side of a triangle can't be 0 or less");
                //Проверка на существование треугольника
                if (sideA > sideB + sideC && sideC > sideA + sideC && sideB > sideA + sideC)
                    throw new ArgumentException("Triangle no exist");
                double[] sides = new double[] { sideA, sideB, sideC };
                var max = sides.Max();
                double area;
                //Проверка на прямоугольность
                if ( Math.Pow(max,2) == Math.Pow(sideA,2) + Math.Pow(sideB,2) + Math.Pow(sideC,2) - Math.Pow(max, 2))
                    return area = 0.5 * sideA * sideB * sideC / max;
                double semiPerimetr = (sideA + sideB + sideC) / 2;
                return area = Math.Sqrt(semiPerimetr * (semiPerimetr - sideA) * (semiPerimetr - sideB) * (semiPerimetr - sideC));
            }
            catch { throw; }
        }

        public static double Circle(double radius)
        {
            try
            {
                if (radius < 0)
                {
                    throw new ArgumentException("Radius can't be less than 0");
                }
                double area = 0;
                area = Math.PI * Math.Pow(radius, 2);
                return area;
            }
            catch { throw; }
        }
    }
}