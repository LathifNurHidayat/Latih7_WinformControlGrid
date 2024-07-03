namespace Latih7_WinformControlGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private IEnumerable<Mobil> GenerateData()
        {
            var honda = new Mobil
            {
                TipeMobil = "HatchBack",
                Warna = "Merah",
                VolumeMesin = 1500,
                BahanBakar = "Pertamax",
                MaxKecepatan = 180,
                TglProduksi = new DateTime(2020, 1, 2)
            };

            var pajero = new Mobil
            {
                TipeMobil = "Pajero Sport",
                Warna = "Hitam",
                VolumeMesin = 2500,
                BahanBakar = "Dex",
                MaxKecepatan = 160,
                TglProduksi = new DateTime(2021, 11, 15)
            };

            var suzukiErtiga = new Mobil
            {
                TipeMobil = "Compact",
                Warna = "Putih",
                VolumeMesin = 1300,
                BahanBakar = "Dexlite",
                MaxKecepatan = 180,
                TglProduksi = new DateTime(2022, 3, 12)
            };


            var ListMobil = new List<Mobil> { honda, pajero, suzukiErtiga };
            return ListMobil;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var datamobil = GenerateData();
            dataGridView1.DataSource = datamobil;
        }
    }

}
