using System;

namespace P3_2_714230053
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = false;

            do
            {
                Console.Clear();
                Console.Write("=== Menu Persegi Panjang ===");
                Console.Write("\n1. Hitung Luas");
                Console.Write("\n2. Hitung Keliling");
                Console.Write("\n3. Keluar");
                Console.Write("\nPilih Menu (1-3): ");

                int pilihan;
                if (!int.TryParse(Console.ReadLine(), out pilihan) || pilihan < 1 || pilihan > 3)
                {
                    Console.WriteLine("Pilihan invalid. Tolong pilih angka 1, 2, or 3.");
                    continue;
                }

                if (pilihan == 3)
                {
                    Console.WriteLine("Keluar...");
                    break;
                }

                Console.Write("Masukkan panjang: ");
                double panjang = Convert.ToDouble(Console.ReadLine());

                Console.Write("Masukkan lebar: ");
                double lebar = Convert.ToDouble(Console.ReadLine());

                if (pilihan == 1)
                {
                    double luas = panjang * lebar;
                    Console.WriteLine("Luas persegi panjang: " + luas);
                }
                else if (pilihan == 2)
                {
                    double keliling = 2 * (panjang + lebar);
                    Console.WriteLine("Keliling persegi panjang: " + keliling);
                }

                Console.WriteLine("\nIngin mengulang kembali? (Y/N)");
                string restartpilihan = Console.ReadLine().ToUpper();
                repeat = restartpilihan == "Y";

                if (restartpilihan == "N")
                {
                    Console.WriteLine("Terima Kasih!");
                }

            } while (repeat);
        }
    }
}