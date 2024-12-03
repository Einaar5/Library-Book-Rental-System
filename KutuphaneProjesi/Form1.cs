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

namespace KutuphaneProjesi
{
	public partial class Form1 : Form
	{

		public Form1()
		{
			InitializeComponent();
		}

		//Constractor
		private void Form1_Load(object sender, EventArgs e)
		{
			Form2 form2 = new Form2();
			KitapKiralaPencere.Visible = false;
			SepetimPanel.Visible = false;
			
			label11.Text = form2.KullaniciAdiText;

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



			// Kalangun'daki öğeleri kontrol et
			
		}

		
	}
}
