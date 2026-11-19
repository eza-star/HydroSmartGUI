using System;
using System.Collections.Generic;
using System.Linq;
using HydroSmart.Models;

namespace HydroSmart.Services
{
    /// <summary>Kontrak untuk semua mesin diagnosa (Interface / Abstraction).</summary>
    public interface IDiagnosa
    {
        HasilAnalisis Diagnosa(Tanaman tanaman, List<int> kodeGejala);
    }

    /// <summary>
    /// Diagnosa sederhana berbasis aturan (mirip decision tree): setiap penyakit punya himpunan gejala,
    /// penyakit dengan tingkat kecocokan (Jaccard) tertinggi dan >= 40% dipilih.
    /// </summary>
    public class AnalisisService : IDiagnosa
    {
        public static readonly Dictionary<int, string> DaftarGejala = new Dictionary<int, string>
        {
            { 1, "Daun menguning" },
            { 2, "Bercak coklat/hitam pada daun" },
            { 3, "Akar berlendir atau berbau busuk" },
            { 4, "Tanaman layu padahal air cukup" },
            { 5, "Ujung/tepi daun mengering seperti terbakar" },
            { 6, "Pertumbuhan kerdil/lambat" },
            { 7, "Lapisan putih seperti tepung pada daun" },
            { 8, "Daun berlubang/tergigit" }
        };

        private readonly List<Penyakit> _basisPengetahuan = new List<Penyakit>();
        private readonly List<HasilAnalisis> _riwayat = new List<HasilAnalisis>();
        private int _nextId = 1;

        public AnalisisService()
        {
            _basisPengetahuan.Add(new Penyakit(
                "Busuk akar (Pythium)",
                "Oksigen terlarut rendah, suhu air terlalu tinggi, atau tandon kotor.",
                "Ganti larutan nutrisi, bersihkan tandon dan media, turunkan suhu air, tambahkan aerator.",
                3, 4, 1));
            _basisPengetahuan.Add(new Penyakit(
                "Kekurangan nitrogen",
                "Konsentrasi nutrisi (TDS) terlalu rendah atau pH tidak sesuai sehingga unsur tidak terserap.",
                "Cek TDS dan pH, tambahkan nutrisi AB Mix sesuai takaran, stabilkan pH.",
                1, 6));
            _basisPengetahuan.Add(new Penyakit(
                "Tip burn (ujung daun terbakar)",
                "Kekurangan kalsium akibat suhu tinggi, kelembapan rendah, atau nutrisi terlalu pekat.",
                "Turunkan TDS, perbaiki sirkulasi udara, kurangi suhu, beri tambahan kalsium.",
                5));
            _basisPengetahuan.Add(new Penyakit(
                "Embun tepung (powdery mildew)",
                "Jamur akibat kelembapan tinggi dan sirkulasi udara buruk.",
                "Buang daun terinfeksi, perbaiki sirkulasi udara, gunakan fungisida nabati.",
                7));
            _basisPengetahuan.Add(new Penyakit(
                "Bercak daun (jamur/bakteri)",
                "Percikan air dan kelembapan berlebih pada daun.",
                "Pangkas daun bergejala, jaga daun tetap kering, pisahkan tanaman terinfeksi.",
                2, 1));
            _basisPengetahuan.Add(new Penyakit(
                "Serangan hama (ulat/kutu daun)",
                "Hama pemakan daun, biasanya masuk dari luar greenhouse.",
                "Ambil hama secara manual, pasang jaring/insect net, semprot pestisida nabati.",
                8));
        }

        public HasilAnalisis Diagnosa(Tanaman tanaman, List<int> kodeGejala)
        {
            HasilAnalisis hasil = new HasilAnalisis();
            hasil.Id = _nextId++;
            hasil.TanamanId = tanaman.Id;
            hasil.NamaTanaman = tanaman.Nama;
            hasil.Waktu = DateTime.Now;

            Penyakit terbaik = null;
            double skorTerbaik = 0;

            foreach (Penyakit p in _basisPengetahuan)
            {
                int irisan = p.KodeGejala.Intersect(kodeGejala).Count();
                int gabungan = p.KodeGejala.Union(kodeGejala).Count();
                double skor = gabungan == 0 ? 0 : (double)irisan / gabungan;
                if (skor > skorTerbaik)
                {
                    skorTerbaik = skor;
                    terbaik = p;
                }
            }

            if (terbaik != null && skorTerbaik >= 0.4)
            {
                hasil.Diagnosa = terbaik.Nama;
                hasil.Kecocokan = Math.Round(skorTerbaik * 100, 1);
                hasil.Penyebab = terbaik.Penyebab;
                hasil.Penanganan = terbaik.Penanganan;
            }
            else
            {
                hasil.Diagnosa = "Belum dapat dipastikan";
                hasil.Kecocokan = Math.Round(skorTerbaik * 100, 1);
                hasil.Penyebab = "Kombinasi gejala belum cocok dengan basis pengetahuan.";
                hasil.Penanganan = "Cek pH/TDS/suhu air, amati beberapa hari lagi, atau konsultasi ke petani hidroponik.";
            }

            _riwayat.Add(hasil);
            return hasil;
        }

        public List<HasilAnalisis> Riwayat()
        {
            return _riwayat.OrderByDescending(h => h.Waktu).ToList();
        }
    }
}
