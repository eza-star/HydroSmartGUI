using System;
using System.Collections.Generic;
using HydroSmart.Models;

namespace HydroSmart.Services
{
    public class NutrisiService
    {
        private readonly List<CatatanNutrisi> _data = new();
        private int _nextId = 1;

        public List<CatatanNutrisi> Semua()
        {
            return new List<CatatanNutrisi>(_data);
        }

        public CatatanNutrisi Tambah(string namaTanaman, double ph, int tds, double suhu,
            double phMin, double phMax, int tdsMin, int tdsMax)
        {
            CatatanNutrisi c = new CatatanNutrisi
            {
                Id = _nextId++,
                NamaTanaman = namaTanaman,
                Waktu = DateTime.Now,
                PH = ph,
                Tds = tds,
                Suhu = suhu,
                StatusPH = ph >= phMin && ph <= phMax ? "Normal" : "Tidak Normal",
                StatusTds = tds >= tdsMin && tds <= tdsMax ? "Normal" : "Tidak Normal",
                StatusSuhu = suhu >= 18 && suhu <= 30 ? "Normal" : "Tidak Normal"
            };
            _data.Add(c);
            return c;
        }

        public bool HapusSemua()
        {
            if (_data.Count == 0) return false;
            _data.Clear();
            _nextId = 1;
            return true;
        }
    }
}
