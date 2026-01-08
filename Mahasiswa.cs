using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_3
{
    public class Mahasiswa
    {
        private string nim;
        private string nama;
        private string alamat;

        public Mahasiswa(string nim, string nama, string alamat)
        {
            this.nim = nim;
            this.nama = nama;
            this.alamat = alamat;
        }

        public string getNim() 
        { 
            return nim; 
        }
        public string getNama() 
        { 
            return nama; 
        }
        public string getAlamat() 
        { 
            return alamat; 
        }
    }
}
