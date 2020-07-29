using System;
using System.Collections.Generic;
using System.Text;

namespace program
{
    public abstract class JualKucing
    {
        public string JenisKucing { get; set; }
        public string JenisKelamin { get; set; }
        public string JumlahKucing { get; set; }
        public abstract double Harga();
    }
}
