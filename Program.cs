using System;

namespace Tugas_3
{ 
    public class Program
    {
        private const double BIAYA_PER_SKS = 200000;
        private const int JUMLAH_DATA = 3;
        public static void Main(string[] args)
        {
            Console.WriteLine("======================================================");
            Console.WriteLine("||         SIMULASI PROGRAM AKADEMIK ITPLN          ||");
            Console.WriteLine("======================================================");

            Dosen[] daftarDosen = InputDosen(JUMLAH_DATA);
            ShowDosen(daftarDosen);

            Mahasiswa[] daftarMahasiswa = InputMahasiswa(JUMLAH_DATA);
            ShowMahasiswa(daftarMahasiswa);

            Matakuliah[] daftarMatkul = InputMatkul(JUMLAH_DATA);
            ShowMatkul(daftarMatkul);

            ProsesEnrollment(daftarMahasiswa, daftarMatkul, daftarDosen);
        }

        static Dosen[] InputDosen(int jumlah)
        {
            Dosen[] daftar = new Dosen[jumlah];
            Console.WriteLine("\nInput Data Dosen sebanyak 3 kali");

            for (int i = 0; i < jumlah; i++)
            { 
                Console.Write("Masukkan NIP Dosen ke-{0}    : ", i + 1 );
                string nip = Console.ReadLine();
                Console.Write("Masukkan NIDN Dosen ke-{0}   : ", i + 1 );
                string nidn = Console.ReadLine();
                Console.Write("Masukkan Nama Dosen ke-{0}   : ", i + 1 );
                string nama = Console.ReadLine();
                Console.Write("Masukkan Alamat Dosen ke-{0} : ", i + 1 );
                string alamat = Console.ReadLine();

                daftar[i] = new Dosen(nip, nama, alamat, nidn);
            }
            return daftar;
        }

        static Mahasiswa[] InputMahasiswa(int jumlah)
        {
            Mahasiswa[] daftar = new Mahasiswa[jumlah];
            Console.WriteLine("\nInput Data Mahasiswa sebanyak 3 kali");

            for (int i = 0; i < jumlah; i++)
            {
                Console.Write("Masukkan NIM Mahasiswa ke-{0}    : ", i + 1 );
                string nim = Console.ReadLine();
                Console.Write("Masukkan Nama Mahasiswa ke-{0}   : ", i + 1 );
                string nama = Console.ReadLine();
                Console.Write("Masukkan Alamat Mahasiswa ke-{0} : ", i + 1 );
                string alamat = Console.ReadLine();

                daftar[i] = new Mahasiswa(nim, nama, alamat);
            }
            return daftar;
        }

        static Matakuliah[] InputMatkul(int jumlah)
        {
            Matakuliah[] daftar = new Matakuliah[jumlah];
            Console.WriteLine("\nInput Data Matkul sebanyak 3 kali");

            for (int i = 0; i < jumlah; i++)
            {
                Console.Write("Masukkan Kode MK ke-{0}  : ", i + 1 );
                string kodeMK = Console.ReadLine();
                Console.Write("Masukkan Nama MK ke-{0}  : ", i + 1 );
                string namaMK = Console.ReadLine();
                Console.Write("Masukkan SKS MK ke-{0}   : ", i + 1 );
                int sks = 0;
                if (!int.TryParse(Console.ReadLine(), out sks))
                {
                    sks = 0;
                }

                daftar[i] = new Matakuliah(kodeMK, namaMK, sks);
            }
            return daftar;
        }

        static void ShowDosen(Dosen[] daftar)
        {
            Console.WriteLine("\nNO\tNIP\tNIDN\tNama\t\t\tAlamat");
            for (int i = 0; i < daftar.Length; i++)
            {
                Console.WriteLine($"{i + 1}\t{daftar[i].getNip()}\t{daftar[i].getNidn()}\t{daftar[i].getNama()}\t\t{daftar[i].getAlamat()}");
            }
        }

        static void ShowMahasiswa(Mahasiswa[] daftar)
        {
            Console.WriteLine("\nNO\tNIM\t\tNama\tAlamat");
            for (int i = 0; i < daftar.Length; i++)
            {
                Console.WriteLine($"{i + 1}\t{daftar[i].getNim()}\t{daftar[i].getNama()}\t{daftar[i].getAlamat()}");
            }
        }

        static void ShowMatkul(Matakuliah[] daftar)
        {
            Console.WriteLine("\nNO\tKodeMK\tNamaMK\tSKS");
            for (int i = 0; i < daftar.Length; i++)
            {
                // Menggunakan fungsi Getter
                Console.WriteLine($"{i + 1}\t{daftar[i].getKMK()}\t{daftar[i].getNMK()}\t{daftar[i].getSKS()}");
            }
        }

        static void ProsesEnrollment(Mahasiswa[] mhsArray, Matakuliah[] mkArray, Dosen[] dsnArray)
        {
            Console.WriteLine("\n==================================");
            Console.WriteLine("Pilih mahasiswanya no berapa, makulnya no berapa dan dosennya no berapa");
            Console.Write("Pilih mahasiswa no berapa: ");
            int noMhs = int.Parse(Console.ReadLine());
            Console.Write("Pilih makul no berapa    : ");
            int noMatkul = int.Parse(Console.ReadLine());
            Console.Write("Pilih dosen no berapa    : ");
            int noDosen = int.Parse(Console.ReadLine());

            int indexMhs = noMhs - 1;
            int indexMatkul = noMatkul - 1;
            int indexDosen = noDosen - 1;

            if (indexMhs >= 0 && indexMhs < JUMLAH_DATA &&
                indexMatkul >= 0 && indexMatkul < JUMLAH_DATA &&
                indexDosen >= 0 && indexDosen < JUMLAH_DATA)
            {
                Mahasiswa mhsDipilih = mhsArray[indexMhs];
                Matakuliah mkDipilih = mkArray[indexMatkul];
                Dosen dsnDipilih = dsnArray[indexDosen];

                // INISIALISASI OBJEK ENROLLMENT DENGAN CONSTRUCTOR
                Enrollment enrollmentBaru = new Enrollment(
                    mhsDipilih.getNim(),
                    mhsDipilih.getNama(),
                    mkDipilih.getKMK(),
                    mkDipilih.getNMK(),
                    mkDipilih.getSKS(),
                    dsnDipilih.getNip(),
                    dsnDipilih.getNama()
                );

                double totalBiaya = enrollmentBaru.hitBiaya(BIAYA_PER_SKS);
                enrollmentBaru.showHasil(totalBiaya);
            }
            else
            {
                Console.WriteLine("\n--- ERROR ---");
                Console.WriteLine("Pilihan nomor tidak valid. Pastikan Anda memilih 1, 2, atau 3.");
            }
        }
    }
}
