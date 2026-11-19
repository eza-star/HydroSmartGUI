using System;

namespace HydroSmart.Models
{
    /// <summary>
    /// Kelas abstrak untuk semua tanaman hidroponik (Inheritance + Abstraction).
    /// Properti abstrak diisi berbeda oleh tiap jenis tanaman (Polymorphism).
    /// </summary>
    public abstract class Tanaman
    {
        private string _nama; // field private -> Encapsulation

        public int Id { get; set; }

        public string Nama
        {
            get { return _nama; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Nama tanaman tidak boleh kosong.");
                _nama = value.Trim();
            }
        }

        public string Lokasi { get; set; }
        public DateTime TanggalTanam { get; set; }

        // Data khusus tiap jenis (di-override oleh subclass)
        public abstract string Jenis { get; }
        public abstract int UmurPanenHari { get; }
        public abstract double PhMin { get; }
        public abstract double PhMax { get; }
        public abstract int TdsMin { get; }
        public abstract int TdsMax { get; }
        public abstract string TipsPerawatan();

        protected Tanaman(string nama, string lokasi, DateTime tanggalTanam)
        {
            Nama = nama;
            Lokasi = lokasi;
            TanggalTanam = tanggalTanam;
        }

        public int UmurHari
        {
            get { return Math.Max(0, (DateTime.Today - TanggalTanam.Date).Days); }
        }

        public DateTime EstimasiPanen
        {
            get { return TanggalTanam.Date.AddDays(UmurPanenHari); }
        }

        public virtual string FaseTumbuh()
        {
            double rasio = (double)UmurHari / UmurPanenHari;
            if (rasio < 0.25) return "Semai";
            if (rasio < 0.75) return "Vegetatif";
            if (rasio < 1.0) return "Menjelang panen";
            return "Siap panen";
        }

        public virtual string Ringkasan()
        {
            return string.Format("[{0}] {1} ({2}) | Lokasi: {3} | Tanam: {4:dd-MM-yyyy} | Umur: {5} hari | Fase: {6} | Estimasi panen: {7:dd-MM-yyyy}",
                Id, Nama, Jenis, Lokasi, TanggalTanam, UmurHari, FaseTumbuh(), EstimasiPanen);
        }
    }
}
