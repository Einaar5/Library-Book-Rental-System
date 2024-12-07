using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KutuphaneProjesi
{
	public class DataHelper
	{
		
		

		// Bağlantı cümlesi (Server bilgileri, Veritabanı adı ve güvenlik)
		private string baglantiAnahtari = @"Data Source=DESKTOP-57FVTS7\SQLEXPRESS;Initial Catalog=kutuphaneProjesi;Integrated Security=True;TrustServerCertificate=True";



		//Veritabanı bağlantısını tutan nesne
		private SqlConnection baglanti;

		//1. bağlantıyı aç

		private void BaglantiAc()
		{
			try
			{
				if (baglanti == null) // Eğer bağlantı daha önce başlatılmadıysa
				{
					baglanti = new SqlConnection(baglantiAnahtari);
				}

				if (baglanti.State == ConnectionState.Closed) // Eğer bağlantı kapalıysa
				{
					baglanti.Open();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Bağlantı açılırken bir hata oluştu: {ex.Message}");
			}
		}

		private void BaglantiKapat()
		{
			if (baglanti != null && baglanti.State == ConnectionState.Open)
			{
				baglanti.Close(); // bağlantıyı kapat
			}
		}






		//-------------------------------------------------------------------------------------//





		//Veri Ekleme
		public void VeriEkle(string tabloAdi, string kolonlar, string degerler)
		{
			try
			{
				BaglantiAc();
				string sorgu = $"INSERT INTO {tabloAdi} ({kolonlar}) values ({degerler})";
				SqlCommand komut = new SqlCommand(sorgu, baglanti); // Sorguyu komuta atıyoruz
				komut.ExecuteNonQuery();//sorguyu çalıştır
			}
			finally
			{
				BaglantiKapat();
			}
		}





		//Veri Güncelleme
		public void VeriGuncelle(string yeniAd, string yeniEmail, string yeniSifre, string kullaniciAdi)
		{
			try
			{
				BaglantiAc();

				// Parametreli SQL sorgusu
				string sorgu = "UPDATE kullanici SET ad = @YeniAd, email = @YeniEmail, sifre = @YeniSifre WHERE username = @KullaniciAdi";

				using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
				{
					// Parametreleri ekliyoruz
					komut.Parameters.AddWithValue("@YeniAd", yeniAd);
					komut.Parameters.AddWithValue("@YeniEmail", yeniEmail);
					komut.Parameters.AddWithValue("@YeniSifre", yeniSifre);
					komut.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);

					// Komutu çalıştırıyoruz
					komut.ExecuteNonQuery();
				}

				MessageBox.Show("Veri başarıyla güncellendi! Yenilenmesi İçin Tekrar Giriş Yapınız");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata: " + ex.Message);
			}
			finally
			{
				BaglantiKapat();
			}
		}


		//Veri Silme
		public void VeriSil(string tabloAdi, string kosul)
		{
			try
			{
				BaglantiAc();

				// SQL sorgusunu hazırla
				string sorgu = $"DELETE FROM {tabloAdi} WHERE {kosul}";

				SqlCommand komut = new SqlCommand(sorgu, baglanti);
				komut.ExecuteNonQuery();
			}
			finally
			{
				BaglantiKapat();
			}
		}

		public DataTable VeriGoruntule(string tabloAdi)
		{
			try
			{
				BaglantiAc();

				// SQL sorgusunu hazırla
				string sorgu = $"SELECT * FROM {tabloAdi} ";

				SqlDataAdapter adaptor = new SqlDataAdapter(sorgu, baglanti);
				DataTable tablo = new DataTable(); // Verileri tutacak tablo
				adaptor.Fill(tablo); // Veriyi tabloya doldur

				return tablo; // Veriyi döndür
			}
			finally
			{
				BaglantiKapat();
			}
		}




		//Kitap Türü Verileri

		public DataTable EnPopulerKitap(string tabloAdi)
		{
			try
			{
				BaglantiAc();

				// SQL sorgusunu hazırla
				string sorgu = $"SELECT * FROM {tabloAdi} WHERE kitap_tur = @kitapTur";

				SqlCommand komut = new SqlCommand(sorgu, baglanti);
				komut.Parameters.AddWithValue("@kitapTur", "En Popüler");

				SqlDataAdapter adaptor = new SqlDataAdapter(komut); // Sorguyu ve parametreleri kullan
				DataTable tablo = new DataTable(); // Verileri tutacak tablo
				adaptor.Fill(tablo); // Veriyi tabloya doldur

				return tablo; // Veriyi döndür
			}
			finally
			{
				BaglantiKapat();
			}
		}


		public DataTable loginKosul(string kullaniciAdi, string sifre)
		{
			try
			{
				BaglantiAc();

				// SQL sorgusunu hazırla ve parametreler kullanarak güvenli sorgu oluştur
				string sorgu = $"SELECT * FROM kullanici WHERE username = @KullaniciAdi AND sifre = @Sifre";

				SqlCommand komut = new SqlCommand(sorgu, baglanti);
				komut.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);  // Kullanıcı adı parametre olarak ekleniyor
				komut.Parameters.AddWithValue("@Sifre", sifre);  // Şifre parametre olarak ekleniyor

				SqlDataAdapter adaptor = new SqlDataAdapter(komut);
				DataTable tablo = new DataTable();
				adaptor.Fill(tablo);

				return tablo;  // Veriyi döndür
			}
			finally
			{
				BaglantiKapat();
			}
		}




		public void KayitOl(string isim, string kullaniciAdi, string email, string sifre)
		{
			try
			{
				BaglantiAc();  // Bağlantıyı açıyoruz (Bağlantı dizesini burada kullanıyoruz)

				// SQL INSERT komutunu tanımlayın
				string sorgu = "INSERT INTO kullanici (ad, username, email, sifre) VALUES (@Ad, @KullaniciAdi, @Email, @Sifre)";

				// SQL komutunu oluştur
				using (SqlCommand cmd = new SqlCommand(sorgu, baglanti))
				{
					// Parametreler ekle
					cmd.Parameters.AddWithValue("@Ad", isim);
					cmd.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
					cmd.Parameters.AddWithValue("@Email", email);
					cmd.Parameters.AddWithValue("@Sifre", sifre);

					// Komutu çalıştır
					cmd.ExecuteNonQuery();
					
					
					
					
					MessageBox.Show("Veri başarıyla kaydedildi!");
					
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata: " + ex.Message);
				
			}
			finally
			{
				BaglantiKapat();  // Bağlantıyı kapatıyoruz
			}
		}


		public DataRow KullaniciBilgileriniGetir(string username)
		{
			BaglantiAc();

			try
			{
				string sorgu = "SELECT ad, username, email, sifre FROM kullanici WHERE username = @Username";
				using (SqlCommand cmd = new SqlCommand(sorgu, baglanti))
				{
					cmd.Parameters.AddWithValue("@Username", username);

					using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
					{
						DataTable dt = new DataTable();
						adapter.Fill(dt);

						if (dt.Rows.Count > 0)
						{
							return dt.Rows[0]; // Kullanıcı bulunduysa, ilk satırı döndür
						}
					}
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Hata: " + ex.Message);
			}
			finally
			{
				BaglantiKapat(); // Bağlantıyı kapat
			}

			return null; // Kullanıcı bulunamadıysa null döndür
		}



	}
}
