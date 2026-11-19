using System;
using HydroSmart.Models;

namespace HydroSmart.Services
{
    /// <summary>Data contoh supaya aplikasi langsung ada isinya saat didemokan.</summary>
    public static class DataAwal
    {
        public static void Isi(Layanan l)
        {
            l.Tanaman.Tambah(new Selada("Selada Rak 1", "Rak 1", DateTime.Today.AddDays(-20)));
            l.Tanaman.Tambah(new Kangkung("Kangkung GH 1", "GH 1", DateTime.Today.AddDays(-10)));
            l.Tanaman.Tambah(new Pakcoy("Pakcoy Rak 2", "Rak 2", DateTime.Today.AddDays(-5)));
        }
    }
}
