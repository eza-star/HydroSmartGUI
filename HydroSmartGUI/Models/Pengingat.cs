using System;

namespace HydroSmart.Models
{
    public class Pengingat
    {
        public int Id { get; set; }
        public string NamaTanaman { get; set; }
        public DateTime Jadwal { get; set; }
        public string Kegiatan { get; set; }
        public string Status { get; set; }
    }
}
