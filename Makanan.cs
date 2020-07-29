using System;
using System.Collections.Generic;
using System.Text;

namespace program
{
    class Makanan : JualKucing
    {
        public double JumlahMakanan { get; set; }
        public double HargaMakanan { get; set; }
        public override double Harga()
        {
            return JumlahMakanan * HargaMakanan;
        }
    }
}