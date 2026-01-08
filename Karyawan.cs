using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_3
{
    public class Karyawan
    {
        private string nip;
        private string nama;
        private string alamat;
        public Karyawan(string nip, string nama, string alamat)
        {
            this.nip = nip;
            this.nama = nama;
            this.alamat = alamat;
        }
        public string getNip()
        {
            return nip;
        }
        public string getNama()
        {
            return nama;
        }
        public string getAlamat()
        {
            return alamat;
        }
        public void setAlamat(string newAlamat)
        {
            this.alamat = newAlamat;
        }
        public virtual double hitGaji(double gapok, double tunjangan)
        {
            return gapok + tunjangan;
        }
    }
}
