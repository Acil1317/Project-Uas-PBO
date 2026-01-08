using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_3
{ 
    public class Enrollment
    {
        private string nim;
        private string namaMHS;
        private string kodeMK;
        private string namaMK;
        private int sks;
        private string nipDosen;
        private string namaDosen;
        public Enrollment(string nim, string namaMHS, string kodeMK, string namaMK, int sks, string nipDosen, string namaDosen)
        {
            this.nim = nim;
            this.namaMHS = namaMHS;
            this.kodeMK = kodeMK;
            this.namaMK = namaMK;
            this.sks = sks;
            this.nipDosen = nipDosen;
            this.namaDosen = namaDosen;
        }
        public double hitBiaya(double biayaPerSKS)
        {
            return sks * biayaPerSKS;
        }
        public void showHasil(double biayaTotal)
        {
            Console.WriteLine("\n---------- |PENCATATAN KRS| ----------");
            Console.WriteLine("NIM\t\tNama MHS\tKD MK\tNama MK\tSKS\tNIP Dosen");
            Console.WriteLine($"{nim}\t{namaMHS}\t\t{kodeMK}\t{namaMK}\t{sks}\t{nipDosen}");
            Console.WriteLine($"\nTotal Biaya yang Harus Dibayar: {biayaTotal:N0}");
            Console.WriteLine("----------------------------------------");
        }
    }
}
