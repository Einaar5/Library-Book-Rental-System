using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneProjesi
{

	public partial class Form2 : Form
	{
		
		DataHelper dataHelper = new DataHelper();

		public Form2()
		{
			InitializeComponent();

			int radius = 25; // Yuvarlaklık derecesi
			RoundedCorners(panel13, radius); // Metodu çağır
			RoundedCorners(panel2, radius); // Metodu çağır
		}

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

		// Form2'de TextBox'ın değerini almak için bir property
		






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

		private void GirisButon_Click(object sender, EventArgs e)
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

				// Giriş başarılı, Form2'yi gizle ve Form1'i aç
				this.Hide(); // Form2'yi gizle
				Form1 mainForm = new Form1(); // Form1'i aç
				mainForm.Show(); // Form1'i göster
			}
			else
			{
				MessageBox.Show("Kullanıcı adı veya şifre hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void kayitOl_Click(object sender, EventArgs e)
		{
			if (KayitPanel.Visible == false)
			{
				KayitPanel.Visible = true;
			}
		}

		private void GirisYapKO_Click(object sender, EventArgs e)
		{
			if (KayitPanel.Visible == true)
			{
				KayitPanel.Visible = false;
			}
		}

		private void KayitOlOnay_Click(object sender, EventArgs e)
		{
			// Formdaki veri alanlarından alınan verileri değişkenlere atayın
			string isim = textBox2.Text;
			string kullaniciAdi = textBox1.Text;
			string email = textBox3.Text;
			string sifre = textBox4.Text;

			// Veri giriş metodunu çağırın
			
			dataHelper.KayitOl(isim, kullaniciAdi, email, sifre);

			
		}

		public string KullaniciAdiText
		{
			get { return kullaniciAdiTextBox.Text; }
		}


	}
}
