using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_3
{
    public class Staf : Karyawan
    {
        public Staf(string nip, string nama, string alamat)
            : base(nip, nama, alamat)
        {
            // Staf tidak punya atribut tambahan
        }
        public override double hitGaji(double gajiPokok, double insentif)
        {
            return gajiPokok + insentif;
        }
    }
}
