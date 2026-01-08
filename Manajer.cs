using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Kelompok_PBO
{
    internal class Manajer : Karyawan, IKaryawan
    {
        public Manajer(string nip, string nama, string alamat, double gajiPokok)
            : base(nip, nama, alamat, Jabatan.Manajer, gajiPokok, 0, 0) // Lembur di-set 0
        {
        }
        public double tunjangan =5000000;
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
