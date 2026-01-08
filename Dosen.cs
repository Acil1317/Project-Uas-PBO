using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_3
{
    public class Dosen : Karyawan
    {
        private string nidn;
        public Dosen(string nip, string nama, string alamat, string nidn)
            : base(nip, nama, alamat)
        {
            this.nidn = nidn;
        }
        public string getNidn() 
        {
            return nidn; 
        }
        public override double hitGaji(double gajiPokok, double tunjangan)
        {
            return base.hitGaji(gajiPokok, 0) + tunjangan;
        }
    }
}
