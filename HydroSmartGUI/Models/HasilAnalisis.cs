using System;

namespace HydroSmart.Models
{
    public class HasilAnalisis
    {
        public int Id { get; set; }
        public int TanamanId { get; set; }
        public string NamaTanaman { get; set; }
        public DateTime Waktu { get; set; }
        public string Diagnosa { get; set; }
        public double Kecocokan { get; set; }   // 0 - 100 (%)
        public string Penyebab { get; set; }
        public string Penanganan { get; set; }
    }
}
