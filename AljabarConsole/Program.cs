using AljabarLibraries;

public class Program
{
    public static void Main(string[] args)
    {
        Persamaan hitung = new Persamaan();
        double[] isi = { 1, -3, -10 };
        double[] hasil = hitung.AkarPersamaanKuadrat(isi);

        Console.WriteLine("Hasil Akar Persamaan kuadrat dari 1,-3,-10 adalah:");
        for (int i = 0; i < hasil.Length; i++)
        {
            Console.Write(hasil[i]);
            if (i < hasil.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine(" ");

        Console.WriteLine(" ");

        double[] randomizer = { 2, -3 };
        double[] result = hitung.HasilKuadrat(randomizer);

        Console.WriteLine("Hasil Perhitungan kuadrat dari 2,-3 adalah: ");
        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(result[i]);
            if (i < result.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine(" ");
    }
}