using System;

namespace HydroSmart.Models
{
    public class CatatanNutrisi
    {
        public int Id { get; set; }
        public string NamaTanaman { get; set; }
        public DateTime Waktu { get; set; }
        public double PH { get; set; }
        public int Tds { get; set; }
        public double Suhu { get; set; }
        public string StatusPH { get; set; }
        public string StatusTds { get; set; }
        public string StatusSuhu { get; set; }
    }
}
