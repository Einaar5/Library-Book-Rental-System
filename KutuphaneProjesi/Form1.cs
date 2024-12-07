using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace KutuphaneProjesi
{
	public partial class Form1 : Form
	{
		DataHelper dataHelper = new DataHelper();
		public Form1()
		{
			InitializeComponent();
			int radius = 25; // Yuvarlaklık derecesi
			RoundedCorners(panel13, radius); 
			RoundedCorners(panel14, radius); 
			RoundedCorners(KapsayiciLogin, radius); 
			RoundedCorners(VeriGuncelle, radius); 
			RoundedCorners(SepetiTemizle, radius); 
			RoundedCorners(button2, radius); 
			RoundedCorners(Anasayfa, radius); 
			RoundedCorners(KitapKiralama, radius); 
			RoundedCorners(button4, radius); 
			RoundedCorners(Sepetim, radius); 
			RoundedCorners(cikis, radius); 
			RoundedCorners(SepeteEkleButonu, radius); 
			RoundedCorners(Sil, radius); 
			RoundedCorners(KayitOlOnay, radius); 
			RoundedCorners(GirisYapKO, radius); 
			RoundedCorners(GirisButon, radius); 
			RoundedCorners(kayitOl, radius); 
			RoundedCorners(KayitPanel, radius); 
			
			

		}

		//Köşe Yuvarlatıcı
		private void RoundedCorners(Control control, int radius)
		{
			// Yuvarlak köşeleri oluşturmak için GraphicsPath kullanılır
			GraphicsPath path = new GraphicsPath();
			path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90); // Sol üst
			path.AddArc(new Rectangle(control.Width - radius, 0, radius, radius), 270, 90); // Sağ üst
			path.AddArc(new Rectangle(control.Width - radius, control.Height - radius, radius, radius), 0, 90); // Sağ alt
			path.AddArc(new Rectangle(0, control.Height - radius, radius, radius), 90, 90); // Sol alt
			path.CloseFigure();

			// Panelin köşe bölgelerini yuvarlak yapar
			control.Region = new Region(path);
		}


		private void Form1_Load(object sender, EventArgs e)
		{
			
			KitapKiralaPencere.Visible = false;
			SepetimPanel.Visible = false;




			//Fonksionlarımı formun load metoduna çağırdım
			ButonlaraVeriEkle();
			FiyatEkle();
			kitapGorseliGetir();
		}

		//login ekranı için yuvarlak köşe tasasrımı




		//Çıkış
		private void button5_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Hesaptan Çıkmak İstiyor Musunuz ?", "Çıkış", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

		}

		//Anasayfa



		//Sepetim
		// Panelleri gizleme ve gösterme fonksiyonu
		private void TogglePanels(Control visiblePanel)
		{
			// Tüm panelleri gizle
			SepetimPanel.Visible = false;
			KitapKiralaPencere.Visible = false;
			Hesabim.Visible = false;

			// Görünür yapmak istediğin paneli göster
			if (visiblePanel != null)
			{
				visiblePanel.Visible = true;
			}
		}

		// Sepetim butonuna tıklanınca
		private void Sepetim_Click(object sender, EventArgs e)
		{
			TogglePanels(SepetimPanel);
		}

		// Kitap Kiralama butonuna tıklanınca
		private void KitapKiralama_Click(object sender, EventArgs e)
		{
			TogglePanels(KitapKiralaPencere);
		}

		// Ana sayfa butonuna tıklanınca
		private void Anasayfa_Click(object sender, EventArgs e)
		{
			TogglePanels(null); // Tüm panelleri gizle
		}

		// Hesabım butonuna tıklanınca
		private void button4_Click(object sender, EventArgs e)
		{
			TogglePanels(Hesabim);
		}





		//Kitap Butonları----------------------------------------------------------------------------------------------------------------------------------------


		private void Kitap1_Click(object sender, EventArgs e)
		{
			if (SepetListesi.Items.Contains(Kitapismi1.Text))
			{
				MessageBox.Show("Aynı Üründen Sadece 1 Tane Alabilirsiniz!");
			}
			else
			{
				if (panel10.Visible == false)
				{
					panel10.Visible = true;

				}
				SepetListesi.Items.Add(Kitapismi1.Text);
				SepetListesiFiyat.Items.Add(Kitap1Fiyat.Text);

			}
		}

		private void Kitap2_Click(object sender, EventArgs e)
		{
			if (SepetListesi.Items.Contains(Kitapismi2.Text))
			{
				MessageBox.Show("Aynı Üründen Sadece 1 Tane Alabilirsiniz!");
			}
			else
			{
				if (panel10.Visible == false)
				{
					panel10.Visible = true;

				}
				SepetListesi.Items.Add(Kitapismi2.Text);
				SepetListesiFiyat.Items.Add(Kitap2Fiyat.Text);

			}
		}

		private void Kitap3_Click(object sender, EventArgs e)
		{
			if (SepetListesi.Items.Contains(Kitapismi3.Text))
			{
				MessageBox.Show("Aynı Üründen Sadece 1 Tane Alabilirsiniz!");
			}
			else
			{
				if (panel10.Visible == false)
				{
					panel10.Visible = true;

				}
				SepetListesi.Items.Add(Kitapismi3.Text);
				SepetListesiFiyat.Items.Add(Kitap3Fiyat.Text);

			}
		}

		private void Kitap4_Click(object sender, EventArgs e)
		{
			if (SepetListesi.Items.Contains(Kitapismi4.Text))
			{
				MessageBox.Show("Aynı Üründen Sadece 1 Tane Alabilirsiniz!");
			}
			else
			{
				if (panel10.Visible == false)
				{
					panel10.Visible = true;

				}
				SepetListesi.Items.Add(Kitapismi4.Text);
				SepetListesiFiyat.Items.Add(Kitap4Fiyat.Text);

			}
		}

		private void Kitap5_Click(object sender, EventArgs e)
		{
			if (SepetListesi.Items.Contains(Kitapismi5.Text))
			{
				MessageBox.Show("Aynı Üründen Sadece 1 Tane Alabilirsiniz!");
			}
			else
			{
				if (panel10.Visible == false)
				{
					panel10.Visible = true;

				}
				SepetListesi.Items.Add(Kitapismi5.Text);
				SepetListesiFiyat.Items.Add(Kitap5Fiyat.Text);

			}
		}

		private void Kitap6_Click(object sender, EventArgs e)
		{
			if (SepetListesi.Items.Contains(Kitapismi6.Text))
			{
				MessageBox.Show("Aynı Üründen Sadece 1 Tane Alabilirsiniz!");
			}
			else
			{
				if (panel10.Visible == false)
				{
					panel10.Visible = true;

				}
				SepetListesi.Items.Add(Kitapismi6.Text);
				SepetListesiFiyat.Items.Add(Kitap6Fiyat.Text);

			}
		}

		private void Kitap7_Click(object sender, EventArgs e)
		{
			if (SepetListesi.Items.Contains(Kitapismi7.Text))
			{
				MessageBox.Show("Aynı Üründen Sadece 1 Tane Alabilirsiniz!");
			}
			else
			{
				if (panel10.Visible == false)
				{
					panel10.Visible = true;

				}
				SepetListesi.Items.Add(Kitapismi7.Text);
				SepetListesiFiyat.Items.Add(Kitap7Fiyat.Text);

			}
		}

		private void Kitap8_Click(object sender, EventArgs e)
		{
			if (SepetListesi.Items.Contains(Kitapismi8.Text))
			{
				MessageBox.Show("Aynı Üründen Sadece 1 Tane Alabilirsiniz!");
			}
			else
			{
				if (panel10.Visible == false)
				{
					panel10.Visible = true;

				}
				SepetListesi.Items.Add(Kitapismi8.Text);
				SepetListesiFiyat.Items.Add(Kitap8Fiyat.Text);

			}
		}



		private void Kitap9_Click(object sender, EventArgs e)
		{
			if (SepetListesi.Items.Contains(Kitapismi9.Text))
			{
				MessageBox.Show("Aynı Üründen Sadece 1 Tane Alabilirsiniz!");
			}
			else
			{
				if (panel10.Visible == false)
				{
					panel10.Visible = true;

				}
				SepetListesi.Items.Add(Kitapismi9.Text);
				SepetListesiFiyat.Items.Add(Kitap9Fiyat.Text);

			}
		}

		private void Kitap10_Click(object sender, EventArgs e)
		{
			if (SepetListesi.Items.Contains(Kitapismi10.Text))
			{
				MessageBox.Show("Aynı Üründen Sadece 1 Tane Alabilirsiniz!");
			}
			else
			{
				if (panel10.Visible == false)
				{
					panel10.Visible = true;

				}
				SepetListesi.Items.Add(Kitapismi10.Text);
				SepetListesiFiyat.Items.Add(Kitap10Fiyat.Text);

			}
		}

		private void Kitap11_Click(object sender, EventArgs e)
		{
			if (SepetListesi.Items.Contains(Kitapismi11.Text))
			{
				MessageBox.Show("Aynı Üründen Sadece 1 Tane Alabilirsiniz!");
			}
			else
			{
				if (panel10.Visible == false)
				{
					panel10.Visible = true;

				}
				SepetListesi.Items.Add(Kitapismi11.Text);
				SepetListesiFiyat.Items.Add(Kitap11Fiyat.Text);

			}
		}

		private void Kitap12_Click(object sender, EventArgs e)
		{
			if (SepetListesi.Items.Contains(Kitapismi12.Text))
			{
				MessageBox.Show("Aynı Üründen Sadece 1 Tane Alabilirsiniz!");
			}
			else
			{
				if (panel10.Visible == false)
				{
					panel10.Visible = true;

				}
				SepetListesi.Items.Add(Kitapismi12.Text);
				SepetListesiFiyat.Items.Add(Kitap12Fiyat.Text);

			}
		}

		private void Kitap13_Click(object sender, EventArgs e)
		{
			if (SepetListesi.Items.Contains(Kitapismi13.Text))
			{
				MessageBox.Show("Aynı Üründen Sadece 1 Tane Alabilirsiniz!");
			}
			else
			{
				if (panel10.Visible == false)
				{
					panel10.Visible = true;

				}
				SepetListesi.Items.Add(Kitapismi13.Text);
				SepetListesiFiyat.Items.Add(Kitap13Fiyat.Text);

			}
		}

		//Kitap Click End-------------------------------------------------------------------------------------------------------------------------------------------------------



		//Sepete Ekleme Sistemi


		private void SepeteEkleButonu_Click(object sender, EventArgs e)
		{
			bool UrunVarmi = false;

			foreach (var item in SepetListesi.Items)
			{
				if (Sepetİsim.Items.Contains(item))
				{
					UrunVarmi = true; // Aynı ürün varsa işaretle
					break;
				}
			}
			foreach (var item in SepetListesiFiyat.Items)
			{
				if (SepetFiyat.Items.Contains(item))
				{
					UrunVarmi = true; // Aynı ürün varsa işaretle
					break;
				}
			}

			if (UrunVarmi)
			{
				MessageBox.Show("Sepete Aynı Ürünler Eklenemez");
			}
			else
			{
				foreach (var item in SepetListesi.Items)
				{
					Sepetİsim.Items.Add(item); // Ürünleri ekle

				}
				foreach (var item in SepetListesiFiyat.Items)
				{
					SepetFiyat.Items.Add(item); // Ürünleri ekle

				}

				panel10.Visible = false;



				MessageBox.Show("Sepete Başarıyla Eklendi");
			}




			// Normal Fiyat Hesaplama Kısmı
			double toplamFiyat = 0;

			// Fiyatları doğru bir şekilde toplamak
			foreach (var fiyat in SepetListesiFiyat.Items)
			{
				try
				{
					// Kültürel format belirterek dönüştür
					toplamFiyat += double.Parse(fiyat.ToString(), System.Globalization.CultureInfo.InvariantCulture);
				}
				catch (FormatException)
				{
					MessageBox.Show("Fiyat formatı hatalı! Lütfen fiyatların doğru formatta olduğundan emin olun.");
					return; // Hesaplamayı durdur
				}
			}

			// Toplam fiyatı ve KDV'yi hesapla
			double kdvOrani = 0.05; // %5 KDV
			double kdvTutari = toplamFiyat * kdvOrani;
			double toplamTutar = toplamFiyat + kdvTutari;

			// Sonuçları ekrana yazdır
			NormalFiyat.Text = toplamFiyat.ToString("F2"); // Normal fiyat
			ToplamFiyat.Text = toplamTutar.ToString("F2"); // KDV dahil toplam fiyat



		}

		//Sepet Listesi Temizleme Butonu
		private void Sil_Click(object sender, EventArgs e)
		{
			SepetListesi.Items.Clear();
			SepetListesiFiyat.Items.Clear();

		}


		//Sepeti Temizleme Butonu
		private void SepetiTemizle_Click(object sender, EventArgs e)
		{
			Sepetİsim.Items.Clear();
			SepetFiyat.Items.Clear();
			SepetListesi.Items.Clear();
			SepetListesiFiyat.Items.Clear();
			MessageBox.Show("Sepetiniz Temizlendi!");
			NormalFiyat.Text = "0";
			ToplamFiyat.Text = "0";
		}

		private void ButonlaraVeriEkle()
		{

			// DataHelper nesnesini oluştur
			DataHelper dataHelper = new DataHelper();
			// Veri tabanından kitapları al
			DataTable kitaplar = dataHelper.VeriGoruntule("kitaplarStok"); // Tablo adını düzenleyin

			// Mevcut butonlarınızı sırayla atayın
			Kitapismi1.Text = kitaplar.Rows[0]["kitap_ad"].ToString();
			Kitapismi2.Text = kitaplar.Rows[1]["kitap_ad"].ToString();
			Kitapismi3.Text = kitaplar.Rows[2]["kitap_ad"].ToString();
			Kitapismi4.Text = kitaplar.Rows[3]["kitap_ad"].ToString();
			Kitapismi5.Text = kitaplar.Rows[4]["kitap_ad"].ToString();
			Kitapismi6.Text = kitaplar.Rows[5]["kitap_ad"].ToString();
			Kitapismi7.Text = kitaplar.Rows[6]["kitap_ad"].ToString();
			Kitapismi8.Text = kitaplar.Rows[7]["kitap_ad"].ToString();
			Kitapismi9.Text = kitaplar.Rows[8]["kitap_ad"].ToString();
			Kitapismi10.Text = kitaplar.Rows[9]["kitap_ad"].ToString();
			Kitapismi11.Text = kitaplar.Rows[10]["kitap_ad"].ToString();
			Kitapismi12.Text = kitaplar.Rows[11]["kitap_ad"].ToString();
			Kitapismi13.Text = kitaplar.Rows[12]["kitap_ad"].ToString();
		}


		private void FiyatEkle()
		{
			try
			{
				// DataHelper nesnesini oluştur
				DataHelper dataHelper = new DataHelper();
				// Veri tabanından kitapları al
				DataTable kitaplar = dataHelper.VeriGoruntule("kitaplarStok"); // Tablo adını düzenleyin

				// Mevcut butonlarınızı sırayla atayın
				Kitap1Fiyat.Text = kitaplar.Rows[0]["kitap_fiyat"].ToString();
				Kitap2Fiyat.Text = kitaplar.Rows[1]["kitap_fiyat"].ToString();
				Kitap3Fiyat.Text = kitaplar.Rows[2]["kitap_fiyat"].ToString();
				Kitap4Fiyat.Text = kitaplar.Rows[3]["kitap_fiyat"].ToString();
				Kitap5Fiyat.Text = kitaplar.Rows[4]["kitap_fiyat"].ToString();
				Kitap6Fiyat.Text = kitaplar.Rows[5]["kitap_fiyat"].ToString();
				Kitap7Fiyat.Text = kitaplar.Rows[6]["kitap_fiyat"].ToString();
				Kitap8Fiyat.Text = kitaplar.Rows[7]["kitap_fiyat"].ToString();
				Kitap9Fiyat.Text = kitaplar.Rows[8]["kitap_fiyat"].ToString();
				Kitap10Fiyat.Text = kitaplar.Rows[9]["kitap_fiyat"].ToString();
				Kitap11Fiyat.Text = kitaplar.Rows[10]["kitap_fiyat"].ToString();
				Kitap12Fiyat.Text = kitaplar.Rows[11]["kitap_fiyat"].ToString();
				Kitap13Fiyat.Text = kitaplar.Rows[12]["kitap_fiyat"].ToString();

			}
			catch (Exception ex)
			{

				MessageBox.Show("Hata" + ex.Message);
			}
		}


		private void kitapGorseliGetir()
		{
			try
			{
				// DataHelper nesnesini oluştur
				DataHelper dataHelper = new DataHelper();
				// Veri tabanından kitapları al
				DataTable kitaplar = dataHelper.VeriGoruntule("kitaplarStok"); // Tablo adını düzenleyin

				// Her bir kitap için arka plan resmini ayarla
				Kitap1.BackgroundImage = Image.FromFile(kitaplar.Rows[0]["kitap_gorsel"].ToString());
				Kitap1.BackgroundImageLayout = ImageLayout.Stretch;
				Kitap2.BackgroundImage = Image.FromFile(kitaplar.Rows[1]["kitap_gorsel"].ToString());
				Kitap2.BackgroundImageLayout = ImageLayout.Stretch;
				Kitap3.BackgroundImage = Image.FromFile(kitaplar.Rows[2]["kitap_gorsel"].ToString());
				Kitap3.BackgroundImageLayout = ImageLayout.Stretch;
				Kitap4.BackgroundImage = Image.FromFile(kitaplar.Rows[3]["kitap_gorsel"].ToString());
				Kitap4.BackgroundImageLayout = ImageLayout.Stretch;
				Kitap5.BackgroundImage = Image.FromFile(kitaplar.Rows[4]["kitap_gorsel"].ToString());
				Kitap5.BackgroundImageLayout = ImageLayout.Stretch;
				Kitap6.BackgroundImage = Image.FromFile(kitaplar.Rows[5]["kitap_gorsel"].ToString());
				Kitap6.BackgroundImageLayout = ImageLayout.Stretch;
				Kitap7.BackgroundImage = Image.FromFile(kitaplar.Rows[6]["kitap_gorsel"].ToString());
				Kitap7.BackgroundImageLayout = ImageLayout.Stretch;
				Kitap8.BackgroundImage = Image.FromFile(kitaplar.Rows[7]["kitap_gorsel"].ToString());
				Kitap8.BackgroundImageLayout = ImageLayout.Stretch;
				Kitap9.BackgroundImage = Image.FromFile(kitaplar.Rows[8]["kitap_gorsel"].ToString());
				Kitap9.BackgroundImageLayout = ImageLayout.Stretch;
				Kitap10.BackgroundImage = Image.FromFile(kitaplar.Rows[9]["kitap_gorsel"].ToString());
				Kitap10.BackgroundImageLayout = ImageLayout.Stretch;
				Kitap11.BackgroundImage = Image.FromFile(kitaplar.Rows[10]["kitap_gorsel"].ToString());
				Kitap11.BackgroundImageLayout = ImageLayout.Stretch;
				Kitap12.BackgroundImage = Image.FromFile(kitaplar.Rows[11]["kitap_gorsel"].ToString());
				Kitap12.BackgroundImageLayout = ImageLayout.Stretch;
				Kitap13.BackgroundImage = Image.FromFile(kitaplar.Rows[12]["kitap_gorsel"].ToString());
				Kitap13.BackgroundImageLayout = ImageLayout.Stretch;

			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata: " + ex.Message);
			}
		}

		//Ödeme Yap Butonu ve kiralama zamanı eklentileri
		private void button2_Click(object sender, EventArgs e)
		{
			string satinalmaZamani = DateTime.Now.ToString("dd.MM.yyyy HH:mm"); // Satın alma zamanı
			DateTime satinalmaDateTime = DateTime.Parse(satinalmaZamani); // String'i DateTime'a dönüştür

			DateTime iadeZamani = satinalmaDateTime.AddDays(21); // 3 hafta (21 gün) ekle
			string iadeZamaniString = iadeZamani.ToString("dd.MM.yyyy HH:mm"); // Sonucu string'e dönüştür

			foreach (var item in Sepetİsim.Items)
			{
				HesabimListbox.Items.Add(item);
				kiralamaZamani.Items.Add(satinalmaZamani); // Her öğe için bir kez zaman ekleniyor

				// Kalan gün hesaplama
				TimeSpan kalanSure = iadeZamani - DateTime.Now;
				int kalanGun = Math.Max(0, kalanSure.Days); // Eğer kalan gün negatifse sıfır yap

				// Kalan gün değerini ekle
				Kalangun.Items.Add("Kalan Gün Sayisi: " + kalanGun.ToString());


			}

			

			Sepetİsim.Items.Clear();
			SepetFiyat.Items.Clear();
			SepetListesi.Items.Clear();
			MessageBox.Show("Ödeme Tamamlanmıştır!");
			NormalFiyat.Text = "";
			ToplamFiyat.Text = "";

		}

		


		private void GirisButon_Click_1(object sender, EventArgs e)
		{
			string kullaniciAdi = kullaniciAdiTextBox.Text.Trim();
			string sifre = sifreTextBox.Text.Trim();

			if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
			{
				MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}





			// Kullanıcıyı doğrulama işlemi
			DataRow kullanici = KullaniciDogrula(kullaniciAdi, sifre);

			if (kullanici != null)
			{

				MessageBox.Show($"Hoş geldiniz, {kullanici["ad"]}!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
				KapsayiciLogin.Visible = false;
				label38.Text = kullaniciAdi;

				// Veri Güncelleme Kısımları için çağırılacak kısım


				try
				{
					string kullaniciAdi1 = label38.Text; // Kullanıcı adını TextBox'tan al

					if (string.IsNullOrWhiteSpace(kullaniciAdi1))
					{
						MessageBox.Show("Lütfen bir kullanıcı adı girin.");
						return;
					}

					// Kullanıcı bilgilerini getir
					var userData = dataHelper.KullaniciBilgileriniGetir(kullaniciAdi1);

					if (userData != null)
					{
						// TextBox'lara doldur
						textBox1.Text = userData["ad"].ToString();
						textBox2.Text = userData["username"].ToString();
						textBox3.Text = userData["email"].ToString();
						textBox4.Text = userData["sifre"].ToString();
					}
					else
					{
						MessageBox.Show("Kullanıcı bulunamadı.");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Hata: " + ex.Message);
				}


			}
			else
			{
				MessageBox.Show("Kullanıcı adı veya şifre hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


			


		}


		//Form Girişi İçin ayarlar LOGİN ve SİGN in



		private DataRow KullaniciDogrula(string kullaniciAdi, string sifre)
		{
			// Veritabanında kullanıcıyı kontrol et

			string sorguKosulu = $"KullaniciAdi = '{kullaniciAdi}' AND Sifre = '{sifre}'"; // Bu, SQL enjeksiyonlarına yol açabilir. Parametre kullanmak daha güvenli.

			// Veritabanından sorgu sonucu al
			DataTable sonuc = dataHelper.loginKosul(kullaniciAdi, sifre); // Parametreli sorguyu kullanıyoruz

			if (sonuc.Rows.Count > 0)
			{
				return sonuc.Rows[0]; // Kullanıcı bulunduysa, bilgileri döndür
			}

			return null; // Kullanıcı bulunamadı
		}

		

		private void kayitOl_Click_1(object sender, EventArgs e)
		{
			if (KayitPanel.Visible == false)
			{
				KayitPanel.Visible = true;
			}
		}

		private void GirisYapKO_Click_1(object sender, EventArgs e)
		{
			if (KayitPanel.Visible == true)
			{
				KayitPanel.Visible = false;
			}
		}


		private void KayitOlOnay_Click_1(object sender, EventArgs e)
		{
			// Formdaki veri alanlarından alınan verileri değişkenlere atayın
			string isim = textBox7.Text;
			string kullaniciAdi = textBox8.Text;
			string email = textBox6.Text;
			string sifre = textBox5.Text;

			// Veri giriş metodunu çağırın

			dataHelper.KayitOl(isim, kullaniciAdi, email, sifre);
		}

		private void VeriGuncelle_Click(object sender, EventArgs e)
		{
			// Kullanıcının girdiği değerleri alıyoruz
			string isim = textBox1.Text;
			string kullaniciAdi = textBox2.Text;
			string email = textBox3.Text;
			string sifre = textBox4.Text;
			string kosul = kullaniciAdiTextBox.Text;
			// Kullanıcı adı, isim, email ve şifrenin boş olup olmadığını kontrol et
			if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(isim) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(sifre))
			{
				MessageBox.Show("Tüm alanlar doldurulmalıdır.");
				return;
			}

			// Veri giriş metodunu çağırın
			dataHelper.VeriGuncelle(isim, email, sifre, kullaniciAdi,kosul);
		}

	}
}
