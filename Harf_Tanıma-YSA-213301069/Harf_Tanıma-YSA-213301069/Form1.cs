namespace Harf_Tanıma_YSA_213301069
{


    public partial class Form1 : Form
    {

        string projeDizini = Directory.GetCurrentDirectory();




        private int[,] matrix; // Matris

        public Form1()
        {
            InitializeComponent();
        }
        System.Threading.Timer timer;
        bool tizin = true;
        public bool izin = false;
        double[,] agirliklar_gizli;
        double[,] agirliklar_cikti;
        double hataOranı;
        private void Form1_Load(object sender, EventArgs e)
        {
            Panel1();

        }

        private void Kontrol(string dosyaYolu)
        {
            if (!File.Exists(dosyaYolu))
            {
                File.CreateText(dosyaYolu);

            }
        }

        public void Panel1()
        {
            int row = 7;
            int column = 5;
            int panelWidth = 350;
            int panelHeight = 350;
            int cellWidth = panelWidth / column;
            int cellHeight = panelHeight / row;

            panel1.Size = new Size(panelWidth, panelHeight);

            // Matrisi oluştur


            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Panel cell = new Panel();
                    cell.Size = new Size(cellWidth, cellHeight);
                    cell.Location = new Point(j * cellWidth, i * cellHeight);
                    cell.BackColor = Color.White;
                    cell.BorderStyle = BorderStyle.FixedSingle;

                    // Hücreye tıklanma olayını ekle
                    cell.Click += (s, e) =>
                    {
                        if (cell.BackColor == Color.Black)
                        {
                            cell.BackColor = Color.White;
                        }
                        else
                        {
                            cell.BackColor = Color.Black;
                        }
                    };

                    panel1.Controls.Add(cell);
                }
            }

            this.Controls.Add(panel1);

        }




        async void Baslat()
        {


            double[,,] egitimVerisi = new double[23, 7, 5] {
    /* A */
    {{0,0,1,0,0},
     {0,1,0,1,0},
     {1,0,0,0,1},
     {1,1,1,1,1},
     {1,0,0,0,1},
     {1,0,0,0,1},
     {1,0,0,0,1}},
    /* B */
    {{1,1,1,1,0},
     {1,0,0,0,1},
     {1,0,0,0,1},
     {1,1,1,1,0},
     {1,0,0,0,1},
     {1,0,0,0,1},
     {1,1,1,1,0}},
    /* C */
    {{0,0,1,1,1},
     {0,1,0,0,0},
     {1,0,0,0,0},
     {1,0,0,0,0},
     {1,0,0,0,0},
     {0,1,0,0,0},
     {0,0,1,1,1}},
    /* D */
    {{1,1,1,0,0},
     {1,0,0,1,0},
     {1,0,0,0,1},
     {1,0,0,0,1},
     {1,0,0,0,1},
     {1,0,0,1,0},
     {1,1,1,0,0}},
    /* E */
    {{1,1,1,1,1},
     {1,0,0,0,0},
     {1,0,0,0,0},
     {1,1,1,1,1},
     {1,0,0,0,0},
     {1,0,0,0,0},
     {1,1,1,1,1}},
    /* F */
    {{1,1,1,1,1},
     {1,0,0,0,0},
     {1,0,0,0,0},
     {1,1,1,1,1},
     {1,0,0,0,0},
     {1,0,0,0,0},
     {1,0,0,0,0}},
    /* G */
    {{0,1,1,1,1},
     {1,0,0,0,0},
     {1,0,0,0,0},
     {1,0,0,1,1},
     {1,0,0,0,1},
     {1,0,0,0,1},
     {0,1,1,1,1}},
    /* H */
    {{1,0,0,0,1},
     {1,0,0,0,1},
     {1,0,0,0,1},
     {1,1,1,1,1},
     {1,0,0,0,1},
     {1,0,0,0,1},
     {1,0,0,0,1}},
    /* I */
    {{1,1,1,1,1},
     {0,0,1,0,0},
     {0,0,1,0,0},
     {0,0,1,0,0},
     {0,0,1,0,0},
     {0,0,1,0,0},
     {1,1,1,1,1}},
    /* J */
    {{0,0,0,0,1},
     {0,0,0,0,1},
     {0,0,0,0,1},
     {0,0,0,0,1},
     {1,0,0,0,1},
     {1,0,0,0,1},
     {0,1,1,1,0}},
    /* K */
    {{1,0,0,0,1},
     {1,0,0,1,0},
     {1,0,1,0,0},
     {1,1,0,0,0},
     {1,0,1,0,0},
     {1,0,0,1,0},
     {1,0,0,0,1}},
    /* L */
    {{1,0,0,0,0},
     {1,0,0,0,0},
     {1,0,0,0,0},
     {1,0,0,0,0},
     {1,0,0,0,0},
     {1,0,0,0,0},
     {1,1,1,1,1}},
    /* M */
    {{1,0,0,0,1},
     {1,1,0,1,1},
     {1,0,1,0,1},
     {1,0,0,0,1},
     {1,0,0,0,1},
     {1,0,0,0,1},
     {1,0,0,0,1}},
    /* N */
    {{1,0,0,0,1},
     {1,1,0,0,1},
     {1,0,1,0,1},
     {1,0,0,1,1},
     {1,0,0,0,1},
     {1,0,0,0,1},
     {1,0,0,0,1}},
    /* O */
    {{0,1,1,1,0},
     {1,0,0,0,1},
     {1,0,0,0,1},
     {1,0,0,0,1},
     {1,0,0,0,1},
     {1,0,0,0,1},
     {0,1,1,1,0}},
    /* P */
    {{1,1,1,1,0},
     {1,0,0,0,1},
     {1,0,0,0,1},
     {1,1,1,1,0},
     {1,0,0,0,0},
     {1,0,0,0,0},
     {1,0,0,0,0}},
    /* R */
    {{1,1,1,1,0},
     {1,0,0,0,1},
     {1,0,0,0,1},
     {1,1,1,1,0},
     {1,0,1,0,0},
     {1,0,0,1,0},
     {1,0,0,0,1}},
    /* S */
    {{0,1,1,1,1},
     {1,0,0,0,0},
     {1,0,0,0,0},
     {0,1,1,1,0},
     {0,0,0,0,1},
     {1,0,0,0,1},
     {0,1,1,1,0}},
    /* T */
    {{1,1,1,1,1},
     {0,0,1,0,0},
     {0,0,1,0,0},
     {0,0,1,0,0},
     {0,0,1,0,0},
     {0,0,1,0,0},
     {0,0,1,0,0}},
    /* U */
    {{1,0,0,0,1},
     {1,0,0,0,1},
     {1,0,0,0,1},
     {1,0,0,0,1},
     {1,0,0,0,1},
     {1,0,0,0,1},
     {0,1,1,1,0}},
    /* V */
    {{1,0,0,0,1},
     {1,0,0,0,1},
     {1,0,0,0,1},
     {1,0,0,0,1},
     {1,0,0,0,1},
     {0,1,0,1,0},
     {0,0,1,0,0}},
    /* Y */
    {{1,0,0,0,1},
     {1,0,0,0,1},
     {0,1,0,1,0},
     {0,0,1,0,0},
     {0,0,1,0,0},
     {0,0,1,0,0},
     {0,0,1,0,0}},
    /* Z */
    {{1,1,1,1,1},
     {0,0,0,0,1},
     {0,0,0,1,0},
     {0,0,1,0,0},
     {0,1,0,0,0},
     {1,0,0,0,0},
     {1,1,1,1,1}}
};

            int girdiSayisi = 35; // 5x7
            int gizliNöronlar = 12;
            int ciktiSayisi = egitimVerisi.GetLength(0);

            // Ağırlıkları rastgele başlat
            Random random = new Random();
            agirliklar_gizli = RastgeleMatris(gizliNöronlar, girdiSayisi, random);
            agirliklar_cikti = RastgeleMatris(ciktiSayisi, gizliNöronlar, random);


            int iterasyonSayısı = 10000;
            

            Egit(egitimVerisi, agirliklar_gizli, agirliklar_cikti, hataOranı, iterasyonSayısı);



        }

        public double[,] MatrisAl(double[,,] matris, int index)
        {
            double[,] d2 = new double[7, 5];
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    d2[i, j] = matris[index, i, j];
                }
            }
            return d2;
        }

        public int[] Harfsayısı(int sayı)
        {
            int[] dizi = new int[sayı];
            for (int i = 0; i < sayı; i++) dizi[i] = i;
            return dizi;
        }

        public void Egit(double[,,] egitimVerisi, double[,] agirliklar_gizli, double[,] agirliklar_cikti, double hataOranı, int iterasyonSayısı)
        {
            // Eğitim
            for (int iterasyon = 0; iterasyon < iterasyonSayısı; iterasyon++)
            {
                foreach (int harfIndex in Harfsayısı(egitimVerisi.GetLength(0))) //burada eğitim sayısını otomati k fonksiyonka ayarladım
                {
                    var input = MatrisiDuzlestir(MatrisAl(egitimVerisi, harfIndex));

                    var output = YeniVector(harfIndex, egitimVerisi.GetLength(0)); // One-hot encoding

                    // İleri yayılım
                    //girişten gizli katmana ve çıkış katmanına hesaplama
                    double[] gizliKatman = Sigmoid(Carpim(agirliklar_gizli, input));
                    double[] cıkısKatman = Sigmoid(Carpim(agirliklar_cikti, gizliKatman));

                    // Geri yayılım
                    //ileri yayılımda elde edilen sonuçları gerçeği ile karşılaştıraraka tam tersi şekilde çıkıştan gizliye ve gizliden girişe ağırlıkları hata bulma ile yeniden gücelleme 
                    double[] ciktiHatasi = CiktiHatasi(output, cıkısKatman);
                    double[] gizliHata = GizliHatasi(agirliklar_cikti, ciktiHatasi, gizliKatman);

                    // ağırlık güncelleme

                    agirliklar_gizli = AğırlıkGüncelle(agirliklar_gizli, hataOranı, gizliHata, input);
                    agirliklar_cikti = AğırlıkGüncelle(agirliklar_cikti, hataOranı, ciktiHatasi, gizliKatman);
                }
            }
        }

        public void Degerlendir(double[,] testVerisi, double[,] agirliklar_gizli, double[,] agirliklar_cikti)
        {
            textBox1.Text = "";
            char[] harfler = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'R', 'S', 'T', 'U', 'V', 'Y', 'Z' };
            // Test
            double[] giris = MatrisiDuzlestir(testVerisi);

            //buda aslında bir ileri yayılım
            double[] gizli = Sigmoid(Carpim(agirliklar_gizli, giris));
            double[] cıktı = Sigmoid(Carpim(agirliklar_cikti, gizli));

            // Sonuç
            double l = 0;
            int p = 0;
            for (int i = 0; i < harfler.Length; i++)
            {
                textBox1.Text += ($" {harfler[i]} harfi ={cıktı[i]} {Environment.NewLine} ");
                if (cıktı[i] > l)
                {
                    l = cıktı[i];
                    p = i;
                }

            }
            chat.Text = $"Yazdığın harfi {harfler[p]} olarak tahmin ettim. Puanı {l} Diğer tahminlerimi aşağıda görebiliersin";
        }

        static double[,] RastgeleMatris(int satir, int sutun, Random random)
        {
            var matris = new double[satir, sutun];
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    matris[i, j] = random.NextDouble() * 2 - 1; // -1 ve 1 aralığı
                }
            }
            return matris;
        }

        static double[] MatrisiDuzlestir(double[,] matris)
        {
            int rowCount = matris.GetLength(0);
            int colCount = matris.GetLength(1);
            double[] result = new double[rowCount * colCount];
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    result[i * colCount + j] = matris[i, j];
                }
            }
            return result;
        }

        static double[] YeniVector(int index, int length)
        {
            var vector = new double[length];
            vector[index] = 1;
            return vector;
        }

        //ağırlıklar
        static double[] Carpim(double[,] matris, double[] vektor)
        {
            int rowCount = matris.GetLength(0);
            int colCount = matris.GetLength(1);
            double[] result = new double[rowCount];
            for (int i = 0; i < rowCount; i++)
            {
                double sum = 0;
                for (int j = 0; j < colCount; j++)
                {
                    sum += matris[i, j] * vektor[j];
                }
                result[i] = sum;
            }
            return result;
        }


        //aynı zmanda transfer fonksiyonu 
        static double[] Sigmoid(double[] v)
        {
            var sigmoid = new double[v.Length];
            for (int i = 0; i < v.Length; i++)
            {
                sigmoid[i] = 1 / (1 + Math.Exp(-v[i]));
            }
            return sigmoid;
        }

        //çıkış katamnı tahminleri hata oranı burada
        static double[] CiktiHatasi(double[] gercek, double[] tahmin)
        {
            var hata = new double[gercek.Length];
            for (int i = 0; i < gercek.Length; i++)
            {
                hata[i] = gercek[i] - tahmin[i];
            }
            return hata;
        }

        //gizli katmandaki tahminler hata 
        static double[] GizliHatasi(double[,] agirliklar, double[] ciktiHatasi, double[] gizliCikti)
        {
            var hata = new double[gizliCikti.Length];
            for (int i = 0; i < gizliCikti.Length; i++)
            {
                double sum = 0;
                for (int j = 0; j < ciktiHatasi.Length; j++)
                {
                    sum += agirliklar[j, i] * ciktiHatasi[j];
                }
                hata[i] = gizliCikti[i] * (1 - gizliCikti[i]) * sum;
            }
            return hata;
        }

        //2 katman arasındaki bağlantılar katmanların çarpımına eşittir.
        static double[,] AğırlıkGüncelle(double[,] agirliklar, double hataOrani, double[] hata, double[] giris)
        {
            int rowCount = agirliklar.GetLength(0);
            int colCount = agirliklar.GetLength(1);
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    agirliklar[i, j] += hataOrani * hata[i] * giris[j];
                }
            }
            return agirliklar;
        }
        public void Kaydet(string dosyaAdi, double[,] agirliklar)
        {
            using (StreamWriter sw = new StreamWriter(dosyaAdi))
            {
                int rowCount = agirliklar.GetLength(0);
                int colCount = agirliklar.GetLength(1);
                textBox1.Text += rowCount;
                textBox1.Text += colCount;

                // Ağırlıkları dosyaya yaz
                for (int i = 0; i < rowCount; i++)
                {
                    for (int j = 0; j < colCount; j++)
                    {
                        sw.Write(agirliklar[i, j] + " ");
                    }
                    sw.WriteLine();
                }
            }
        }
        async void button1_Click(object sender, EventArgs e)
        {
            if (KontrolEt(textBox2.Text))
            {
                tizin = true;

                Baslat();
                izin = true;
                chat.Text = "Harika model eğitimi tamamlandı test etmeye hazırsınız";
            }else chat.Text = "Lütfen hata oranını doğru girdiğinize emin olun. Değer 0 ve 1 arasında olmalıdır.";

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (izin)
            {
                int row = 7;
                int column = 5;
                double[,] testverisi = new double[row, column];

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        Panel cell = (Panel)panel1.Controls[i * column + j];
                        if (cell.BackColor == Color.Black)
                            testverisi[i, j] = 1;
                        else
                            testverisi[i, j] = 0;
                    }
                }
                Degerlendir(testverisi, agirliklar_gizli, agirliklar_cikti);

            }
            else
            {
                chat.Text = "Önce medeli eğitmelisiniz";
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (izin)
            {

                try
                {
                    string gizliYol = Path.Combine(projeDizini, "gizliAgirlik.txt");
                    string cıkısYol = Path.Combine(projeDizini, "cıkısAgirlik.txt");

                    Kontrol(gizliYol);
                    Kontrol(cıkısYol);
                    Kaydet(gizliYol, agirliklar_gizli);
                    Kaydet(cıkısYol, agirliklar_cikti);
                    chat.Text = "Modeliniz bşarı ile kaydedildi";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata :" + ex);
                }
            }
            else chat.Text = "Modeli kadydebilmeniz için önce bir model eğitmelisiniz";

        }

        public double[,] ModelYukle(string dosyaAdi)
        {
            // Proje dizini
            string projeDizini = Directory.GetCurrentDirectory();
            string dosyaYolu = Path.Combine(projeDizini, dosyaAdi);
            int i = 0;
            
            if (File.Exists(dosyaYolu))
            {
                try
                {
                    // Dosya varsa ağırlıkları yükle
                    string[] satirlar = File.ReadAllLines(dosyaYolu);
                    int satır = satirlar.Length;
                    int sütun = satirlar[0].Split(' ').Length-1;

                    double[,] agirliklar = new double[satır, sütun];

                    while (i < satır )
                    {
                        int j = 0;
                        string[] degerler = satirlar[i].Split(' ');
                        while (j < degerler.Length-1 )
                        {
                            agirliklar[i, j] = double.Parse(degerler[j]);
                            j++;
                            
                        }
                        i++;
                        
                    }
                    
                    chat.Text = "Harika model yüklendi test etmeye hazırsınız";
                    izin = true;
                    return agirliklar;

                }
                catch (Exception ex)
                {
                    chat.Text = $"Üzgünüm model dosyasında bir hata oluştu bozuk olabilir. Yeni model eğitip kaydedebilirsiniz ";
                    izin = false;
                    MessageBox.Show($"{ex}", "Hata");
                }


            }

            return null;

        }

        private bool KontrolEt(string sayi)
        {
            double doubleSayi;
            if (!double.TryParse(sayi, out doubleSayi) || doubleSayi < 0 || doubleSayi > 1)
            {
                MessageBox.Show("Lütfen 0 ile 1 arasında bir sayı girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            hataOranı = doubleSayi;
            return true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Control control in panel1.Controls)
            {
                if (control.BackColor == Color.Black)
                {
                    control.BackColor = Color.White;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            agirliklar_gizli = ModelYukle("gizliAgirlik.txt");
            agirliklar_cikti = ModelYukle("cıkısAgirlik.txt");

        }
    }
}
