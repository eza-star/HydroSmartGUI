using System.Collections.Generic;
using HydroSmart.Models;

namespace HydroSmart.Services
{
    public class PerawatanService
    {
        private readonly List<Pengingat> _data = new();
        private int _nextId = 1;

        public List<Pengingat> Semua()
        {
            return new List<Pengingat>(_data);
        }

        public Pengingat Tambah(Pengingat pengingat)
        {
            pengingat.Id = _nextId++;
            pengingat.Status = "Menunggu";
            _data.Add(pengingat);
            return pengingat;
        }

        public bool TandaiSelesai(int id)
        {
            Pengingat p = Cari(id);
            if (p == null) return false;
            p.Status = "Selesai";
            return true;
        }

        public bool Hapus(int id)
        {
            Pengingat p = Cari(id);
            if (p == null) return false;
            return _data.Remove(p);
        }

        private Pengingat Cari(int id)
        {
            return _data.Find(p => p.Id == id);
        }
    }
}
