using System;

namespace HydroSmart.Models
{
    public class Selada : Tanaman
    {
        public Selada(string nama, string lokasi, DateTime tanggalTanam) : base(nama, lokasi, tanggalTanam) { }

        public override string Jenis { get { return "Selada"; } }
        public override int UmurPanenHari { get { return 35; } }
        public override double PhMin { get { return 5.5; } }
        public override double PhMax { get { return 6.5; } }
        public override int TdsMin { get { return 560; } }
        public override int TdsMax { get { return 840; } }

        public override string TipsPerawatan()
        {
            return "Selada rentan tip burn: jaga suhu air di bawah 25 C dan sirkulasi udara baik.";
        }
    }
}
