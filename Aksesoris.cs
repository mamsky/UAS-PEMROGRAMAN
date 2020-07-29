using program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Aksesoris : JualKucing
    {
        public double JumlahAksesoris { get; set; }
        public double HargaAksesoris { get; set; }
        public override double Harga()
        {
            return JumlahAksesoris * HargaAksesoris;
        }
    }
}