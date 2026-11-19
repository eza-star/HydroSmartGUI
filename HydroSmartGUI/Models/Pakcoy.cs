using System;

namespace HydroSmart.Models
{
    public class Pakcoy : Tanaman
    {
        public Pakcoy(string nama, string lokasi, DateTime tanggalTanam) : base(nama, lokasi, tanggalTanam) { }

        public override string Jenis { get { return "Pakcoy"; } }
        public override int UmurPanenHari { get { return 30; } }
        public override double PhMin { get { return 6.0; } }
        public override double PhMax { get { return 7.0; } }
        public override int TdsMin { get { return 1050; } }
        public override int TdsMax { get { return 1750; } }

        public override string TipsPerawatan()
        {
            return "Pakcoy menyukai pH sedikit lebih tinggi (6.0-7.0) dan cahaya cukup 10-12 jam per hari.";
        }
    }
}
