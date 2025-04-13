using System;

namespace MenggajiKaryawan
{
    // Base Class Karyawan 
    public class Karyawan
    {
        private string nama;
        private string id;
        private double gajiPokok;

        // Konstruktor
        public Karyawan(string nama, string id, double gajiPokok)
        {
            this.nama = nama;
            this.id = id;
            this.gajiPokok = gajiPokok;
        }

        // Get Set
        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public double GajiPokok
        {
            get { return gajiPokok; }
            set { gajiPokok = value; }
        }

        // Override oleh class turunan
        public virtual double HitungGaji()
        {
            return gajiPokok;
        }

        // Untuk menampilkan informasi karyawan
        public virtual void Info()
        {
            Console.WriteLine($"Nama: {Nama}");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Gaji Pokok: {GajiPokok:C}");
        }
    }

    // Inheritence KaryawanKontrak
    public class KaryawanTetap : Karyawan
    {
        private const double BonusTetap = 500000;

        public KaryawanTetap(string nama, string id, double gajiPokok) : base(nama, id, gajiPokok)
        {
        }

        public override double HitungGaji()
        {
            return GajiPokok + BonusTetap;
        }

        public override void Info()
        {
            base.Info();
            Console.WriteLine($"Bonus Tetap: {BonusTetap:C}");
            Console.WriteLine($"Gaji Akhir: {HitungGaji():C}");
            Console.WriteLine("Status: Karyawan Tetap");
        }
    }

    // Inheritance KaryawanKontrak
    public class KaryawanKontrak : Karyawan
    {
        private const double PotonganKontrak = 200000;

        public KaryawanKontrak(string nama, string id, double gajiPokok) : base(nama, id, gajiPokok)
        {
        }

        public override double HitungGaji()
        {
            return GajiPokok - PotonganKontrak;
        }

        public override void Info()
        {
            base.Info();
            Console.WriteLine($"Potongan Kontrak: {PotonganKontrak:C}");
            Console.WriteLine($"Gaji Akhir: {HitungGaji():C}");
            Console.WriteLine("Status: Karyawan Kontrak");
        }
    }

    // Inheritence KaryawanMagang
    public class KaryawanMagang : Karyawan
    {
        public KaryawanMagang(string nama, string id, double gajiPokok) : base(nama, id, gajiPokok)
        {
        }

        public override double HitungGaji()
        {
            return GajiPokok; // tidak ada bonus/potongan
        }

        public override void Info()
        {
            base.Info();
            Console.WriteLine($"Gaji Akhir: {HitungGaji():C}");
            Console.WriteLine("Status: Karyawan Magang");
        }
    }
}