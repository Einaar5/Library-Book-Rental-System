using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

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
		public void VeriGuncelle(string tabloAdi, string guncellemeBilgi, string kosul)
		{
			try
			{
				BaglantiAc();
				string sorgu = $"UPDATE {tabloAdi} SET {guncellemeBilgi} WHERE {kosul}";
				SqlCommand komut = new SqlCommand(sorgu, baglanti); // Sorguyu komuta atıyoruz
				komut.ExecuteNonQuery();//sorguyu çalıştır
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
				string sorgu = $"SELECT * FROM {tabloAdi}";

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




		//Kitap Verileri GEtir


	}
}
