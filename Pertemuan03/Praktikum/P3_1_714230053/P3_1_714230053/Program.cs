using System;

namespace P3_1_714230053
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();

                Console.Write("PENENTUKAN INDEKS PRESTASI MAHASISWA\n....................................");
                Console.Write("\nMasukkan Nama Mahasiswa: ");

                String nama = Console.ReadLine();

                Console.Write("Masukkan Nilai: ");

                int nilai = Convert.ToInt16(Console.ReadLine());

                String[] grade = { "A", "B", "C", "D" };

                if (nilai >= 85)
                {
                    Console.WriteLine("Indeks nilai {0} adalah {1}", nama, grade[0]);
                }
                else if (nilai >= 70 && nilai < 85)
                {
                    Console.WriteLine("Indeks nilai {0} adalah {1}", nama, grade[1]);
                }
                else if (nilai >= 60 && nilai < 70)
                {
                    Console.WriteLine("Indeks nilai {0} adalah {1}", nama, grade[2]);
                }
                else
                {
                    Console.WriteLine("Indeks nilai {0} adalah {1}", nama, grade[3]);
                }

                Console.Write("\nMasukkan Indeks Yang Ditampilkan: ");
                char indeks = Convert.ToChar(Console.ReadLine());
                Console.Write("Indeks Prestasi adalah: ", nama);

                prestasi(indeks);

                Console.WriteLine("\nIngin mengulang kembali? (Y/T)");
            }
            while (Console.ReadLine() == "Y");
        }
        private static void prestasi(char indeks)
        {
            switch (indeks)
            {
                case 'A':
                    Console.WriteLine("Sangat Baik");
                    break;
                case 'B':
                    Console.WriteLine("Baik");
                    break;
                case 'C':
                    Console.WriteLine("Cukup");
                    break;
                case 'D':
                    Console.WriteLine("Buruk");
                    break;
                default:
                    Console.WriteLine("Invalid Indeks Prestasi");
                    break;
            }
        }
    }
}