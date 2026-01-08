using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_3
{
    public class Matakuliah
    {
        private string kodeMatkul;
        private string namaMatkul;
        private int sks;
        public Matakuliah(string kodeMatkul, string namaMatkul, int sks)
        {
            this.kodeMatkul = kodeMatkul;
            this.namaMatkul = namaMatkul;
            this.sks = sks;
        }
        public string getKMK() 
        { 
            return kodeMatkul; 
        }
        public string getNMK() 
        { 
            return namaMatkul; 
        }
        public int getSKS() 
        { 
            return sks; 
        }
    }
}
