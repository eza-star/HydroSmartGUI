namespace HydroSmart.Services
{
    /// <summary>Wadah semua service supaya mudah dibagikan ke semua form/halaman.</summary>
    public class Layanan
    {
        public TanamanService Tanaman { get; private set; }
        public AnalisisService Analisis { get; private set; }
        public AuthService Auth { get; private set; }
        public PerawatanService Perawatan { get; private set; }
        public NutrisiService Nutrisi { get; private set; }

        public Layanan()
        {
            Tanaman = new TanamanService();
            Analisis = new AnalisisService();
            Auth = new AuthService();
            Perawatan = new PerawatanService();
            Nutrisi = new NutrisiService();
        }
    }
}
