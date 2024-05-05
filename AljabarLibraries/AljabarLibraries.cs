namespace AljabarLibraries
{
    public class Persamaan
    {
        public double[] AkarPersamaanKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];
            double c = persamaan[2];

            double akar1, akar2;
            double determinant = ((b * b) - (4 * (a * c)));

            if (determinant >= 0)
            {
                akar1 = (-b + Math.Sqrt(determinant)) / (2 * a);
                akar2 = (-b - Math.Sqrt(determinant)) / (2 * a);
            }
            else
            {
                return new double[0];
            }
            return new double[] { akar1, akar2 };
        }

        public double[] HasilKuadrat(double[] persamaan)
        {
            int n = persamaan.Length;
            double[] result = new double[n + 1];

            for (int i = 0; i < n; i++)
            {
                double koef = persamaan[i];
                result[2 * i] += koef * koef;

                for (int j = i + 1; j < n; j++)
                {
                    result[i + j] += 2 * koef * persamaan[j];
                }
            }
            return result;
        }
    }
}