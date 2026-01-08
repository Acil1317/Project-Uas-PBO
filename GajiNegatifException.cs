using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Kelompok_PBO
{

    public class GajiNegatifException : Exception
    {
        public GajiNegatifException(string message) : base(message)
        {
        }
    }
}