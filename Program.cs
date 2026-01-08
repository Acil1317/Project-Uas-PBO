using System;
using System.IO;

// Ganti FilesExceptionArrClass_A dengan namespace proyek Anda yang benar
namespace Tugas_Kelompok_PBO
{
    internal class Program
    {
        // Path File Karyawan
        // Catatan: Pastikan drive D: ada, jika tidak, ubah menjadi path yang valid (misalnya, @"DataKaryawan.txt")
        static string KaryawanPath = @"d:\New folder\Tugas_Kelompok_PBO\DataKaryawan.txt";

        static void Main(string[] args)
        {
            int jmlKaryawan = 0;
            Console.WriteLine("PROGRAM PBO: SISTEM PENGGAJIAN KARYAWAN");
            Console.WriteLine("==================================================");
            try
            {
                // Bagian input untuk menentukan jumlah array
                Console.Write("Masukan jumlah data Karyawan: ");
                // Menggunakan Convert.ToInt16 seperti di contoh kode Anda, pastikan ini tidak gagal
                jmlKaryawan = Convert.ToInt16(Console.ReadLine());

                // Panggil method untuk input dan proses data
                genKaryawan(jmlKaryawan);
            }
            // Catch error umum (misalnya, format input salah saat Convert.ToInt16/ToDouble)
            catch (Exception ex)
            {
                Console.WriteLine("\n[ERROR UTAMA] Terjadi kesalahan pada input atau sistem. Harap hubungi admin.");
                saveLog(ex.Message); // Simpan error ke log
            }
            finally
            {
                Console.WriteLine("\n--- Program Selesai ---");
            }
        }

        // Method meniru saveLog yang ada di contoh kode Anda
        static void saveLog(string msg)
        {
            string Path = @"d:\New folder\Tugas_Kelompok_PBO\ErrorLog.txt";
            // File.AppendText(Path) akan membuat file jika belum ada dan selalu menambahkan data baru
            using (StreamWriter s = File.AppendText(Path))
            {
                s.WriteLine($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}] {msg}");
            }
        }

        // Method untuk generate Karyawan (Input, Show, Write File)
        static void genKaryawan(int jml)
        {
            // Array of Class
            Karyawan[] daftarKaryawan = new Karyawan[jml];

            for (int i = 0; i < daftarKaryawan.Length; i++)
            {
                Console.WriteLine($"\n--- Masukan Data Karyawan ke-{i + 1} ---");

                // Input Identitas
                Console.Write("Masukan NIP      : ");
                string nip = Console.ReadLine();
                Console.Write("Masukan Nama     : ");
                string nama = Console.ReadLine();
                Console.Write("Masukan Alamat   : ");
                string alamat = Console.ReadLine();

                // Input Gaji Pokok
                Console.Write("Masukan Gaji Pokok (Rp): ");
                double gajiPokok = Convert.ToDouble(Console.ReadLine());

                Console.Write("Pilih Jabatan (1: Staf 2: Supervisor 3: Manajer): ");

                if (int.TryParse(Console.ReadLine(), out int posisiIndex))
                {
                    // Konversi ke Enum
                    Jabatan posisi = (Jabatan)(posisiIndex - 1);

                    switch (posisi)
                    {
                        case Jabatan.Staff:
                            Console.Write("Masukan Honor Lembur per Hari (Rp): ");
                            double hnrLembur = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Masukan Jumlah Hari Lembur: ");
                            int jmlHari = Convert.ToInt16(Console.ReadLine());

                            daftarKaryawan[i] = new Staff(nip, nama, alamat, gajiPokok, hnrLembur, jmlHari);
                            break;
                        case Jabatan.Supervisor:
                            daftarKaryawan[i] = new Supervisor(nip, nama, alamat, gajiPokok);
                            break;
                        case Jabatan.Manajer:
                            daftarKaryawan[i] = new Manajer(nip, nama, alamat, gajiPokok);
                            break;
                        default:
                            Console.WriteLine("Jabatan tidak valid. Dibuat Staf default.");
                            daftarKaryawan[i] = new Staff(nip, nama, alamat, gajiPokok, 0, 0);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Pilihan tidak valid. Dibuat Staf default.");
                    daftarKaryawan[i] = new Staff(nip, nama, alamat, gajiPokok, 0, 0);
                }
            }

            // Output data ke konsol
            Console.WriteLine("\n==================================================");
            Console.WriteLine("JUDUL\tNAMA\tJABATAN\tGAJI DITERIMA");

            // Output dan File Writing (Style Foreach Anda)
            foreach (Karyawan k in daftarKaryawan)
            {
                // Memanggil method show dan write dari objek Karyawan
                k.showKaryawan();
                k.writeKaryawan(KaryawanPath);
            }
            Console.WriteLine("==================================================");
            Console.WriteLine($"[INFO FILE]: Data Karyawan berhasil ditambahkan ke {KaryawanPath}.");
        }
    }
}