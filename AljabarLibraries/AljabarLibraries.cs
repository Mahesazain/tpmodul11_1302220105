namespace AljabarLibraries
{
    public class Persamaan
    {
        public double[] AkarPersamaanKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];
            double c = persamaan[2];

            double determin = b * b - 4 * a * c;

            if (determin >= 0)
            {
                double sqrt = Math.Sqrt(determin);
                double akar1 = (-b + sqrt) / (2 * a);
                double akar2 = (-b - sqrt) / (2 * a);
                return new double[] { akar1, akar2 };
            }
            else
            {
                Console.WriteLine("Persamaan tidak menghasilkan akar real");
                return new double[0];
            }
        }

        public double[] HasilKuadrat(double[] persamaan)
        {
            int n = persamaan.Length;
            double[] result = new double[n + 1];

            for (int i = 0; i < n; i++)
            {
                double coefficient = persamaan[i];
                result[2 * i] += coefficient * coefficient;

                for (int j = 1; j < n; j++)
                {
                    result[i + j] += 2 * coefficient * persamaan[j];
                }
            }

            return result;
        }
    }
}