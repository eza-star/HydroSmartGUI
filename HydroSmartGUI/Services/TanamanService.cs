using System;
using System.Collections.Generic;
using HydroSmart.Models;

namespace HydroSmart.Services
{
    /// <summary>Menyimpan dan mengelola data tanaman (in-memory).</summary>
    public class TanamanService
    {
        private readonly List<Tanaman> _data = new List<Tanaman>();
        private int _nextId = 1;

        public List<Tanaman> Semua()
        {
            return new List<Tanaman>(_data);
        }

        public Tanaman Cari(int id)
        {
            return _data.Find(t => t.Id == id);
        }

        public Tanaman Tambah(Tanaman tanaman)
        {
            tanaman.Id = _nextId++;
            _data.Add(tanaman);
            return tanaman;
        }

        public bool Hapus(int id)
        {
            Tanaman t = Cari(id);
            if (t == null) return false;
            _data.Remove(t);
            return true;
        }

        /// <summary>Factory: membuat objek turunan Tanaman sesuai jenis (1=Selada, 2=Kangkung, 3=Pakcoy).</summary>
        public static Tanaman Buat(int jenis, string nama, string lokasi, DateTime tanggalTanam)
        {
            switch (jenis)
            {
                case 1: return new Selada(nama, lokasi, tanggalTanam);
                case 2: return new Kangkung(nama, lokasi, tanggalTanam);
                case 3: return new Pakcoy(nama, lokasi, tanggalTanam);
                default: throw new ArgumentException("Jenis tanaman tidak dikenal.");
            }
        }
    }
}
