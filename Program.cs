using System;

namespace MenggajiKaryawan
{
    class Program
    {
        static void Main(string[] args)
        {
            bool lanjut = true;

            while (lanjut)
            {
                Console.WriteLine("Absen Karyawan Yg mw Gaji");
                Console.WriteLine("=========================");

                Console.WriteLine("Pilih jenis karyawan:");
                Console.WriteLine("1. Karyawan Tetap");
                Console.WriteLine("2. Karyawan Kontrak");
                Console.WriteLine("3. Karyawan Magang");
                Console.WriteLine("4. Keluar");
                Console.Write("Masukkan pilihan (1-4): ");

                int pilihan;
                bool inputValid = int.TryParse(Console.ReadLine(), out pilihan);

                if (!inputValid)
                {
                    Console.Clear();
                    Console.WriteLine("\nError: Pilihan kamu bukan angka! Harap masukkan angka antara 1-4!\n");
                    continue;
                }

                if (pilihan == 4)
                {
                    Console.WriteLine("\nTerima kasih, program selesai!");
                    lanjut = false;
                    continue;
                }

                if (pilihan < 1 || pilihan > 4)
                {
                    Console.Clear();
                    Console.WriteLine("\nError: Pilihan kamu tidak tersedia! Harap masukkan angka 1-4\n");
                    continue;
                }

                Console.Clear();
                Console.Write("Masukkan Nama Karyawan: ");
                string nama = Console.ReadLine();

                Console.Write("Masukkan ID Karyawan: ");
                string id = Console.ReadLine();

                Console.Write("Masukkan Gaji Pokok: ");
                double gajiPokok;
                while (!double.TryParse(Console.ReadLine(), out gajiPokok))
                {
                    Console.Write("Input gaji tidak valid! Masukkan angka: ");
                }

                Karyawan karyawan = null;

                if (pilihan == 1)
                {
                    karyawan = new KaryawanTetap(nama, id, gajiPokok);
                }
                else if (pilihan == 2)
                {
                    karyawan = new KaryawanKontrak(nama, id, gajiPokok);
                }
                else if (pilihan == 3)
                {
                    karyawan = new KaryawanMagang(nama, id, gajiPokok);
                }

                Console.WriteLine("\nInformasi Karyawan:");
                Console.WriteLine("-------------------");
                karyawan.Info();

                Console.WriteLine("\nTekan Enter untuk kembali ke menu...");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}