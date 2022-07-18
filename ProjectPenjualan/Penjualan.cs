using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    // Deklarasi Class Penjualan dengan Acces Modifier Public
    public class Penjualan
    {
        // Property Nota yang menampung tipe data String dengan Acces Modifier Public
        public string Nota { get; set; }

        // Property Tanggal yang menampung tipe data String dengan Acces Modifier Public
        public string Tanggal { get; set; }

        // Property Costumer yang menampung tipe data String dengan Acces Modifier Public
        public string Costumer { get; set; }

        // Property Jenis yang menampung tipe data String dengan Acces Modifier Public
        public string Jenis { get; set; }

        // Property Total yang menampung tipe data Double dengan Acces Modifier Public
        public double Total { get; set; }
    }
}
