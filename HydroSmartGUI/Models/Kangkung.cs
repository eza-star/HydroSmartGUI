using System;

namespace HydroSmart.Models
{
    public class Kangkung : Tanaman
    {
        public Kangkung(string nama, string lokasi, DateTime tanggalTanam) : base(nama, lokasi, tanggalTanam) { }

        public override string Jenis { get { return "Kangkung"; } }
        public override int UmurPanenHari { get { return 25; } }
        public override double PhMin { get { return 5.5; } }
        public override double PhMax { get { return 6.5; } }
        public override int TdsMin { get { return 1050; } }
        public override int TdsMax { get { return 1400; } }

        public override string TipsPerawatan()
        {
            return "Kangkung tumbuh cepat dan haus nutrisi: cek TDS lebih sering dan potong pucuk untuk memicu tunas.";
        }

        // Contoh override method virtual: kangkung bisa dipanen bertahap
        public override string FaseTumbuh()
        {
            string fase = base.FaseTumbuh();
            return fase == "Siap panen" ? "Siap panen (bisa panen bertahap)" : fase;
        }
    }
}
