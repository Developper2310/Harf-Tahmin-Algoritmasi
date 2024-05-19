# Yapay Sinir Ağları Nedir?
Yapay Sinir Ağları (YSA), insan beynindeki sinir hücrelerinin (nöronlar) çalışma prensiplerinden esinlenerek oluşturulan bir makine öğrenmesi modelidir. Beynimizdeki nöronlar, elektrik sinyalleri aracılığıyla birbirleriyle iletişim kurar ve bilgiyi işler. Yapay sinir ağları da benzer şekilde, birçok yapay nöronun birbirine bağlanarak bilgiyi işlediği bir sistemdir. Bu ağlar, çok katmanlı yapıdan oluşur: bir giriş katmanı, bir veya daha fazla gizli katman ve bir çıkış katmanı. Her nöron, kendisine gelen sinyalleri alır, işler ve sonucunu sonraki katmandaki nöronlara iletir. Bu süreçte, nöronlar arasındaki bağlantıların (ağırlıkların) değerleri öğrenme süreciyle güncellenir ve böylece modelin doğruluğu artırılır. YSA'lar, görüntü tanıma, ses tanıma, doğal dil işleme gibi birçok alanda kullanılabilir.

Kodun İşleyişi
Proje, bir form uygulaması içinde harf tanıma işlevi gören bir yapay sinir ağı modelini içeriyor. Bu model, 5x7 boyutlarında piksellerden oluşan harfleri tanıyacak şekilde eğitiliyor ve vereceğiniz girişleri tahmin ediliyor. 

Form1 yapıcısında, form bileşenleri başlatılır ve Panel1 yöntemi çağrılır.
Panel1 yöntemi, kullanıcıların pikselleri siyah veya beyaz olarak işaretleyebileceği 5x7'lik bir panel oluşturur.

![image](https://github.com/Developper2310/Harf-Tahmin-Algoritmasi/assets/130366798/75e1b8f8-2216-4943-92d9-5ec653a5a16f)

# Model Eğitim Süreci:

Baslat yöntemi, eğitim verilerini hazırlar ve yapay sinir ağı modelinin ağırlıklarını rastgele başlatır.
Egit yöntemi, eğitim verisini kullanarak ağırlıkları günceller ve modeli eğitir. Bu süreç, ileri ve geri yayılım adımlarıyla gerçekleştirilir:
İleri yayılım: Girişten gizli katmana ve çıkış katmanına hesaplamalar yapılır.
Geri yayılım: Tahmin edilen sonuçlar gerçeği ile karşılaştırılarak hata oranı hesaplanır ve ağırlıklar güncellenir.

# İleri Yayılım (Forward Propagation)
İleri yayılım, yapay sinir ağının verilen bir girdi (input) üzerinde tahmin (prediction) yapma sürecidir. Bu süreç, nöronlar arasında bilgiyi ileriye doğru aktararak sonuca ulaşmayı sağlar. 

Girdi Katmanı (Input Layer): İlk olarak, ağın giriş katmanına ham veri (girdi) verilir. Prjojede bu bir harfi temsil eden 5x7'lik bir piksel matrisidir .

Ağırlıklar ve Aktivasyon Fonksiyonu:

Her nöron, kendisine bağlı önceki katmandaki nöronlardan gelen sinyalleri alır.
Bu sinyaller, nöronlar arasındaki bağlantıların ağırlıklarıyla çarpılır.
Ağırlıklarla çarpılan bu sinyaller toplanır ve bir aktivasyon fonksiyonuna (sigmoid) uygulanarak nöronun çıkışı hesaplanır.

Gizli Katmanlar (Hidden Layers): Bu işlemler, ağın gizli katmanlarında devam eder. Her gizli katmandaki nöron, önceki katmandaki nöronlardan gelen sinyalleri işler.

Çıkış Katmanı (Output Layer): Son olarak, hesaplanan sinyaller çıkış katmanına ulaşır ve ağın tahmini elde edilir. Örneğin, hangi harfi temsil ettiğine dair bir tahmin yapılır.

İleri yayılımda bilgi, girişten çıkışa doğru katman katman aktarılır.

# Geri Yayılım (Backpropagation)
Geri yayılım, ağın yaptığı tahmin ile gerçek sonuç arasındaki farkı (hata) minimize etmek için ağırlıkları ayarlama sürecidir. Bu işlem, ağın öğrenmesini sağlar. Adım adım açıklayalım:

Hata Hesaplama:

İleri yayılımın sonunda, ağın tahmini ile gerçek sonuç (etiket) karşılaştırılır.
Bu karşılaştırmadan bir hata değeri (örneğin, MSE - Ortalama Kare Hatası) hesaplanır.
Hata Sinyalinin Geriye Doğru Yayılması:

Hesaplanan hata, çıkış katmanından başlayarak geriye doğru yayılır.
Bu hata sinyali, ağırlıkların nasıl güncelleneceğini belirler.
Ağırlıkların Güncellenmesi:

Çıkış katmanındaki nöronlar, hata sinyalini alır ve bu sinyali, kendilerine bağlı olan önceki katmandaki nöronlara iletir.
Her nöron, kendisine gelen hata sinyalini, aktivasyon fonksiyonunun türevine göre (zincir kuralı kullanılarak) kullanır ve ağırlıkları günceller.
Bu işlem, katman katman geriye doğru devam eder, ta ki giriş katmanına kadar.
Öğrenme Oranı (Learning Rate):

Ağırlıkların güncellenme miktarını belirleyen bir katsayıdır.
Öğrenme oranı, ağırlık güncellemelerinin ne kadar büyük veya küçük olacağını kontrol eder.


Model Değerlendirme (Degerlendir Yöntemi):

Degerlendir yöntemi, kullanıcı tarafından panelde çizilen harfi test verisi olarak alır ve modelin bu harfi tanıyıp tanımadığını kontrol eder.
Tanıma işlemi, ileri yayılım yöntemiyle yapılır ve sonuç kullanıcıya gösterilir.
Ağırlıkların Kaydedilmesi ve Yüklenmesi:

Kaydet yöntemi, modelin ağırlıklarını dosyaya kaydeder.
ModelYukle yöntemi, kaydedilmiş ağırlıkları dosyadan yükler.

![image](https://github.com/Developper2310/Harf-Tahmin-Algoritmasi/assets/130366798/23b593fd-0dc6-45f9-b32d-52c690eddb27)

Kodun Detaylı İşleyişi
Eğitim Verisi Hazırlığı: Kod, 5x7 piksellik harflerin ikili (0 ve 1) temsillerini eğitim verisi olarak kullanır.
Rastgele Ağırlıkların Başlatılması: Ağırlıklar, rastgele küçük değerlerle başlatılır.
İleri ve Geri Yayılım: İleri yayılımda, giriş verileri gizli katman ve çıkış katmanı boyunca iletilir. Geri yayılımda, elde edilen hatalar kullanılarak ağırlıklar güncellenir.
Modelin Kaydedilmesi ve Yüklenmesi: Ağırlıklar, metin dosyalarına kaydedilir ve gerektiğinde bu dosyalardan tekrar yüklenebilir.
Kullanıcı Etkileşimi: Kullanıcılar, panelde pikselleri işaretleyerek modelin harfi tanımasını sağlar. Eğitim ve değerlendirme işlemleri, düğmelere tıklanarak başlatılır.
Bu kod, temel bir yapay sinir ağı modelinin nasıl oluşturulacağı, eğitileceği ve kullanılacağı konusunda iyi bir örnek teşkil eder.
