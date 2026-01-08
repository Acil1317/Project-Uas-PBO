using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tugas_Kelompok_PBO;

namespace Tugas_Kelompok_PBO
{
    internal class Supervisor : Karyawan, IKaryawan
    {
        public Supervisor(string nip, string nama, string alamat, double gajiPokok)
            : base(nip, nama, alamat, Jabatan.Supervisor, gajiPokok, 0, 0) // Lembur di-set 0
        {
        }
        public double tunjangan = 2000000;
        public double hitGaji()
        {
            return gapok + hitLembur() + tunjangan;
        }
        public double hitLembur()
        {
            return 0;
        }
        public override double GetGaji()
        {
            return hitGaji();
        }
    }
}