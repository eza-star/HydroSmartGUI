using System.Collections.Generic;

namespace HydroSmart.Models
{
    /// <summary>Basis pengetahuan penyakit/masalah tanaman: nama, gejala khas, dan penanganan.</summary>
    public class Penyakit
    {
        public string Nama { get; private set; }
        public string Penyebab { get; private set; }
        public string Penanganan { get; private set; }
        public List<int> KodeGejala { get; private set; }

        public Penyakit(string nama, string penyebab, string penanganan, params int[] kodeGejala)
        {
            Nama = nama;
            Penyebab = penyebab;
            Penanganan = penanganan;
            KodeGejala = new List<int>(kodeGejala);
        }
    }
}
