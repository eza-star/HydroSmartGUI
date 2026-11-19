using System;
using HydroSmart.Models;

namespace HydroSmart.Services
{
    /// <summary>Data contoh supaya aplikasi langsung ada isinya saat didemokan.</summary>
    public static class DataAwal
    {
        public static void Isi(Layanan l)
        {
            l.Tanaman.Tambah(new Selada("Selada Rak A1", "Rak A", DateTime.Today.AddDays(-20)));
            l.Tanaman.Tambah(new Kangkung("Kangkung NFT 1", "NFT 1", DateTime.Today.AddDays(-10)));
            l.Tanaman.Tambah(new Pakcoy("Pakcoy Rak B2", "Rak B", DateTime.Today.AddDays(-5)));
        }
    }
}
