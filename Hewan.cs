using System;
using System.Collections.Generic;
using System.Text;

namespace program
{
    class Hewan : JualKucing
    {
        public double HargaKucing { get; set; }
        public override double Harga()
        {
            return HargaKucing;
        }
    }
}