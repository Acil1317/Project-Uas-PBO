using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tugas_Kelompok_PBO;

namespace Tugas_Kelompok_PBO
{
    internal class Staff : Karyawan, IKaryawan
    {
        public Staff(string nip, string nama, string alamat, double gajiPokok, double honorLembur, int jumlahHari)
        : base(nip, nama, alamat, Jabatan.Staff, gajiPokok, honorLembur, jumlahHari)
        {
        }
        public double hitGaji()
        {
            double totalGaji = gapok + hitLembur();

            if (totalGaji < 0)
            {
                throw new GajiNegatifException($"Gaji Staf ({Nama}) dihitung negatif.");
            }
            return totalGaji;
        }
        public double hitLembur()
        {
            return jmlHari * hnrLembur;
        }
        public override double GetGaji()
        {
            try
            {
                return hitGaji();
            }
            catch (GajiNegatifException ex)
            {
                Console.WriteLine($"[ERROR GAJI STAF]: {ex.Message}");
                return 0;
            }
        }
    }
}