using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Kelompok_PBO
{
    internal abstract class Karyawan
    {
        public string NIP, Nama, Alamat;
        public double gapok, hnrLembur;
        public int jmlHari;
        public Jabatan Posisi;
        public Karyawan(string nip, string nama, string alamat, Jabatan posisi, double gajiPokok, double honorLembur, int jumlahHari)
        {
            this.NIP = nip;
            this.Nama = nama;
            this.Alamat = alamat;
            this.Posisi = posisi;
            this.gapok = gajiPokok;
            this.hnrLembur = honorLembur;
            this.jmlHari = jumlahHari;
        }
        public abstract double GetGaji();
        public void showKaryawan()
        {
            Console.WriteLine($"{NIP}\t{Nama}\t{Posisi}\t{GetGaji().ToString("N0")}");
        }
        public void writeKaryawan(string path)
        {
            if (!File.Exists(path))
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine($"{NIP}\t{Nama}\t{Posisi}\t{GetGaji().ToString("N0")}");
                }
            }
            else
            {
                using (StreamWriter s = new StreamWriter(path))
                {
                    s.WriteLine($"{NIP}\t{Nama}\t{Posisi}\t{GetGaji().ToString("N0")}");
                }
            }
        }
        public void readKaryawan(string path)
        {
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (sr.ReadLine != null)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                }
            }
        }
    }
}
