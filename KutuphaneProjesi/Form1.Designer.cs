using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace KutuphaneProjesi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label45 = new System.Windows.Forms.Label();
			this.label38 = new System.Windows.Forms.Label();
			this.panel10 = new System.Windows.Forms.Panel();
			this.label24 = new System.Windows.Forms.Label();
			this.Sil = new System.Windows.Forms.Button();
			this.SepetListesiFiyat = new System.Windows.Forms.ListBox();
			this.SepeteEkleButonu = new System.Windows.Forms.Button();
			this.SepetListesi = new System.Windows.Forms.ListBox();
			this.label11 = new System.Windows.Forms.Label();
			this.Sepetim = new System.Windows.Forms.Button();
			this.cikis = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.KitapKiralama = new System.Windows.Forms.Button();
			this.Anasayfa = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.KitapKiralaPencere = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabControl2 = new System.Windows.Forms.TabControl();
			this.tabPage8 = new System.Windows.Forms.TabPage();
			this.Hesabim = new System.Windows.Forms.Panel();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage13 = new System.Windows.Forms.TabPage();
			this.KapsayiciLogin = new System.Windows.Forms.Panel();
			this.panel14 = new System.Windows.Forms.Panel();
			this.KayitPanel = new System.Windows.Forms.Panel();
			this.panel13 = new System.Windows.Forms.Panel();
			this.label57 = new System.Windows.Forms.Label();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.label39 = new System.Windows.Forms.Label();
			this.label40 = new System.Windows.Forms.Label();
			this.GirisYapKO = new System.Windows.Forms.Button();
			this.KayitOlOnay = new System.Windows.Forms.Button();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.sifreKayitOl = new System.Windows.Forms.Label();
			this.EmailKayitOl = new System.Windows.Forms.Label();
			this.KullaniciAdiKayitOl = new System.Windows.Forms.Label();
			this.İsimKayitOl = new System.Windows.Forms.Label();
			this.label56 = new System.Windows.Forms.Label();
			this.kayitOl = new System.Windows.Forms.Button();
			this.label41 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.label42 = new System.Windows.Forms.Label();
			this.label43 = new System.Windows.Forms.Label();
			this.label44 = new System.Windows.Forms.Label();
			this.GirisButon = new System.Windows.Forms.Button();
			this.sifreTextBox = new System.Windows.Forms.TextBox();
			this.kullaniciAdiTextBox = new System.Windows.Forms.TextBox();
			this.label55 = new System.Windows.Forms.Label();
			this.VeriGuncelle = new System.Windows.Forms.Button();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label37 = new System.Windows.Forms.Label();
			this.label36 = new System.Windows.Forms.Label();
			this.label35 = new System.Windows.Forms.Label();
			this.label34 = new System.Windows.Forms.Label();
			this.tabPage14 = new System.Windows.Forms.TabPage();
			this.Kalangun = new System.Windows.Forms.ListBox();
			this.kiralamaZamani = new System.Windows.Forms.ListBox();
			this.label31 = new System.Windows.Forms.Label();
			this.HesabimListbox = new System.Windows.Forms.ListBox();
			this.panel11 = new System.Windows.Forms.Panel();
			this.label33 = new System.Windows.Forms.Label();
			this.label32 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.Kitapismi8 = new System.Windows.Forms.Label();
			this.Kitapismi7 = new System.Windows.Forms.Label();
			this.Kitapismi6 = new System.Windows.Forms.Label();
			this.Kitapismi5 = new System.Windows.Forms.Label();
			this.Kitapismi4 = new System.Windows.Forms.Label();
			this.Kitapismi3 = new System.Windows.Forms.Label();
			this.Kitapismi2 = new System.Windows.Forms.Label();
			this.Kitapismi1 = new System.Windows.Forms.Label();
			this.Kitap8Fiyat = new System.Windows.Forms.Label();
			this.Kitap7Fiyat = new System.Windows.Forms.Label();
			this.Kitap6Fiyat = new System.Windows.Forms.Label();
			this.Kitap5Fiyat = new System.Windows.Forms.Label();
			this.Kitap4Fiyat = new System.Windows.Forms.Label();
			this.Kitap3Fiyat = new System.Windows.Forms.Label();
			this.Kitap2Fiyat = new System.Windows.Forms.Label();
			this.Kitap1Fiyat = new System.Windows.Forms.Label();
			this.Kitap8 = new System.Windows.Forms.Button();
			this.Kitap7 = new System.Windows.Forms.Button();
			this.Kitap6 = new System.Windows.Forms.Button();
			this.Kitap5 = new System.Windows.Forms.Button();
			this.Kitap4 = new System.Windows.Forms.Button();
			this.Kitap3 = new System.Windows.Forms.Button();
			this.Kitap2 = new System.Windows.Forms.Button();
			this.Kitap1 = new System.Windows.Forms.Button();
			this.tabPage9 = new System.Windows.Forms.TabPage();
			this.label30 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.Kitap12Fiyat = new System.Windows.Forms.Label();
			this.Kitap11Fiyat = new System.Windows.Forms.Label();
			this.Kitap10Fiyat = new System.Windows.Forms.Label();
			this.Kitap9Fiyat = new System.Windows.Forms.Label();
			this.Kitap13Fiyat = new System.Windows.Forms.Label();
			this.Kitapismi13 = new System.Windows.Forms.Label();
			this.Kitapismi12 = new System.Windows.Forms.Label();
			this.Kitapismi11 = new System.Windows.Forms.Label();
			this.Kitapismi10 = new System.Windows.Forms.Label();
			this.Kitapismi9 = new System.Windows.Forms.Label();
			this.Kitap13 = new System.Windows.Forms.Button();
			this.Kitap12 = new System.Windows.Forms.Button();
			this.Kitap11 = new System.Windows.Forms.Button();
			this.Kitap10 = new System.Windows.Forms.Button();
			this.Kitap9 = new System.Windows.Forms.Button();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.tabPage6 = new System.Windows.Forms.TabPage();
			this.tabPage7 = new System.Windows.Forms.TabPage();
			this.SepetimPanel = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.label23 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.ToplamFiyat = new System.Windows.Forms.Label();
			this.Vergi = new System.Windows.Forms.Label();
			this.NormalFiyat = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.SepetiTemizle = new System.Windows.Forms.Button();
			this.label14 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.SepetFiyat = new System.Windows.Forms.ListBox();
			this.Sepetİsim = new System.Windows.Forms.ListBox();
			this.panel9 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label54 = new System.Windows.Forms.Label();
			this.label53 = new System.Windows.Forms.Label();
			this.label52 = new System.Windows.Forms.Label();
			this.label51 = new System.Windows.Forms.Label();
			this.label50 = new System.Windows.Forms.Label();
			this.label49 = new System.Windows.Forms.Label();
			this.label48 = new System.Windows.Forms.Label();
			this.label47 = new System.Windows.Forms.Label();
			this.label46 = new System.Windows.Forms.Label();
			this.Kitap21 = new System.Windows.Forms.Button();
			this.Kitap20 = new System.Windows.Forms.Button();
			this.Kitap19 = new System.Windows.Forms.Button();
			this.Kitap18 = new System.Windows.Forms.Button();
			this.Kitap17 = new System.Windows.Forms.Button();
			this.Kitap16 = new System.Windows.Forms.Button();
			this.Kitap15 = new System.Windows.Forms.Button();
			this.Kitap14 = new System.Windows.Forms.Button();
			this.Kitap29 = new System.Windows.Forms.Button();
			this.Kitap28 = new System.Windows.Forms.Button();
			this.Kitap27 = new System.Windows.Forms.Button();
			this.Kitap26 = new System.Windows.Forms.Button();
			this.Kitap25 = new System.Windows.Forms.Button();
			this.Kitap24 = new System.Windows.Forms.Button();
			this.Kitap23 = new System.Windows.Forms.Button();
			this.Kitap22 = new System.Windows.Forms.Button();
			this.Kitap33 = new System.Windows.Forms.Button();
			this.Kitap32 = new System.Windows.Forms.Button();
			this.Kitap31 = new System.Windows.Forms.Button();
			this.Kitap30 = new System.Windows.Forms.Button();
			this.Kitap37 = new System.Windows.Forms.Button();
			this.Kitap36 = new System.Windows.Forms.Button();
			this.Kitap35 = new System.Windows.Forms.Button();
			this.Kitap34 = new System.Windows.Forms.Button();
			this.Kitap38 = new System.Windows.Forms.Button();
			this.Kitap42 = new System.Windows.Forms.Button();
			this.Kitap41 = new System.Windows.Forms.Button();
			this.Kitap40 = new System.Windows.Forms.Button();
			this.Kitap39 = new System.Windows.Forms.Button();
			this.Kitapismi21 = new System.Windows.Forms.Label();
			this.Kitapismi20 = new System.Windows.Forms.Label();
			this.Kitapismi19 = new System.Windows.Forms.Label();
			this.Kitapismi18 = new System.Windows.Forms.Label();
			this.Kitapismi17 = new System.Windows.Forms.Label();
			this.Kitapismi16 = new System.Windows.Forms.Label();
			this.Kitapismi15 = new System.Windows.Forms.Label();
			this.Kitapismi14 = new System.Windows.Forms.Label();
			this.Kitapismi29 = new System.Windows.Forms.Label();
			this.Kitapismi28 = new System.Windows.Forms.Label();
			this.Kitapismi27 = new System.Windows.Forms.Label();
			this.Kitapismi26 = new System.Windows.Forms.Label();
			this.Kitapismi25 = new System.Windows.Forms.Label();
			this.Kitapismi24 = new System.Windows.Forms.Label();
			this.Kitapismi23 = new System.Windows.Forms.Label();
			this.Kitapismi22 = new System.Windows.Forms.Label();
			this.Kitapismi33 = new System.Windows.Forms.Label();
			this.Kitapismi32 = new System.Windows.Forms.Label();
			this.Kitapismi31 = new System.Windows.Forms.Label();
			this.Kitapismi30 = new System.Windows.Forms.Label();
			this.Kitapismi37 = new System.Windows.Forms.Label();
			this.Kitapismi36 = new System.Windows.Forms.Label();
			this.Kitapismi35 = new System.Windows.Forms.Label();
			this.Kitapismi34 = new System.Windows.Forms.Label();
			this.Kitapismi38 = new System.Windows.Forms.Label();
			this.Kitapismi39 = new System.Windows.Forms.Label();
			this.Kitapismi40 = new System.Windows.Forms.Label();
			this.Kitapismi41 = new System.Windows.Forms.Label();
			this.Kitapismi42 = new System.Windows.Forms.Label();
			this.Kitap14Fiyat = new System.Windows.Forms.Label();
			this.Kitap15Fiyat = new System.Windows.Forms.Label();
			this.Kitap16Fiyat = new System.Windows.Forms.Label();
			this.Kitap17Fiyat = new System.Windows.Forms.Label();
			this.Kitap18Fiyat = new System.Windows.Forms.Label();
			this.Kitap19Fiyat = new System.Windows.Forms.Label();
			this.Kitap20Fiyat = new System.Windows.Forms.Label();
			this.Kitap21Fiyat = new System.Windows.Forms.Label();
			this.Kitap22Fiyat = new System.Windows.Forms.Label();
			this.Kitap23Fiyat = new System.Windows.Forms.Label();
			this.Kitap24Fiyat = new System.Windows.Forms.Label();
			this.Kitap25Fiyat = new System.Windows.Forms.Label();
			this.Kitap26Fiyat = new System.Windows.Forms.Label();
			this.Kitap27Fiyat = new System.Windows.Forms.Label();
			this.Kitap28Fiyat = new System.Windows.Forms.Label();
			this.Kitap29Fiyat = new System.Windows.Forms.Label();
			this.Kitap30Fiyat = new System.Windows.Forms.Label();
			this.Kitap31Fiyat = new System.Windows.Forms.Label();
			this.Kitap32Fiyat = new System.Windows.Forms.Label();
			this.Kitap33Fiyat = new System.Windows.Forms.Label();
			this.Kitap34Fiyat = new System.Windows.Forms.Label();
			this.Kitap35Fiyat = new System.Windows.Forms.Label();
			this.Kitap36Fiyat = new System.Windows.Forms.Label();
			this.Kitap37Fiyat = new System.Windows.Forms.Label();
			this.Kitap38Fiyat = new System.Windows.Forms.Label();
			this.Kitap39Fiyat = new System.Windows.Forms.Label();
			this.Kitap40Fiyat = new System.Windows.Forms.Label();
			this.Kitap41Fiyat = new System.Windows.Forms.Label();
			this.Kitap42Fiyat = new System.Windows.Forms.Label();
			this.label58 = new System.Windows.Forms.Label();
			this.label59 = new System.Windows.Forms.Label();
			this.label60 = new System.Windows.Forms.Label();
			this.label61 = new System.Windows.Forms.Label();
			this.label62 = new System.Windows.Forms.Label();
			this.label63 = new System.Windows.Forms.Label();
			this.label64 = new System.Windows.Forms.Label();
			this.label65 = new System.Windows.Forms.Label();
			this.label66 = new System.Windows.Forms.Label();
			this.label67 = new System.Windows.Forms.Label();
			this.label68 = new System.Windows.Forms.Label();
			this.label69 = new System.Windows.Forms.Label();
			this.label70 = new System.Windows.Forms.Label();
			this.label71 = new System.Windows.Forms.Label();
			this.label72 = new System.Windows.Forms.Label();
			this.label73 = new System.Windows.Forms.Label();
			this.label74 = new System.Windows.Forms.Label();
			this.label75 = new System.Windows.Forms.Label();
			this.label76 = new System.Windows.Forms.Label();
			this.label77 = new System.Windows.Forms.Label();
			this.label78 = new System.Windows.Forms.Label();
			this.label79 = new System.Windows.Forms.Label();
			this.label80 = new System.Windows.Forms.Label();
			this.label81 = new System.Windows.Forms.Label();
			this.label82 = new System.Windows.Forms.Label();
			this.label83 = new System.Windows.Forms.Label();
			this.label84 = new System.Windows.Forms.Label();
			this.label85 = new System.Windows.Forms.Label();
			this.label86 = new System.Windows.Forms.Label();
			this.panel12 = new System.Windows.Forms.Panel();
			this.label87 = new System.Windows.Forms.Label();
			this.panel15 = new System.Windows.Forms.Panel();
			this.label88 = new System.Windows.Forms.Label();
			this.panel16 = new System.Windows.Forms.Panel();
			this.label89 = new System.Windows.Forms.Label();
			this.panel17 = new System.Windows.Forms.Panel();
			this.label90 = new System.Windows.Forms.Label();
			this.panel18 = new System.Windows.Forms.Panel();
			this.label91 = new System.Windows.Forms.Label();
			this.label92 = new System.Windows.Forms.Label();
			this.label93 = new System.Windows.Forms.Label();
			this.label94 = new System.Windows.Forms.Label();
			this.panel19 = new System.Windows.Forms.Panel();
			this.panel20 = new System.Windows.Forms.Panel();
			this.label95 = new System.Windows.Forms.Label();
			this.label96 = new System.Windows.Forms.Label();
			this.label97 = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			this.panel10.SuspendLayout();
			this.panel4.SuspendLayout();
			this.KitapKiralaPencere.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabControl2.SuspendLayout();
			this.tabPage8.SuspendLayout();
			this.Hesabim.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage13.SuspendLayout();
			this.KapsayiciLogin.SuspendLayout();
			this.panel14.SuspendLayout();
			this.KayitPanel.SuspendLayout();
			this.panel13.SuspendLayout();
			this.tabPage14.SuspendLayout();
			this.panel11.SuspendLayout();
			this.tabPage9.SuspendLayout();
			this.panel5.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.tabPage6.SuspendLayout();
			this.tabPage7.SuspendLayout();
			this.SepetimPanel.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel8.SuspendLayout();
			this.panel12.SuspendLayout();
			this.panel15.SuspendLayout();
			this.panel16.SuspendLayout();
			this.panel17.SuspendLayout();
			this.panel18.SuspendLayout();
			this.panel19.SuspendLayout();
			this.panel20.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Gold;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			resources.ApplyResources(this.panel1, "panel1");
			this.panel1.Name = "panel1";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Black;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.label45);
			this.panel2.Controls.Add(this.label38);
			this.panel2.Controls.Add(this.panel10);
			this.panel2.Controls.Add(this.label11);
			this.panel2.Controls.Add(this.Sepetim);
			this.panel2.Controls.Add(this.cikis);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.button4);
			this.panel2.Controls.Add(this.KitapKiralama);
			this.panel2.Controls.Add(this.Anasayfa);
			resources.ApplyResources(this.panel2, "panel2");
			this.panel2.Name = "panel2";
			// 
			// label45
			// 
			resources.ApplyResources(this.label45, "label45");
			this.label45.ForeColor = System.Drawing.Color.White;
			this.label45.Name = "label45";
			// 
			// label38
			// 
			resources.ApplyResources(this.label38, "label38");
			this.label38.ForeColor = System.Drawing.Color.White;
			this.label38.Name = "label38";
			// 
			// panel10
			// 
			this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel10.Controls.Add(this.label24);
			this.panel10.Controls.Add(this.Sil);
			this.panel10.Controls.Add(this.SepetListesiFiyat);
			this.panel10.Controls.Add(this.SepeteEkleButonu);
			this.panel10.Controls.Add(this.SepetListesi);
			resources.ApplyResources(this.panel10, "panel10");
			this.panel10.Name = "panel10";
			// 
			// label24
			// 
			resources.ApplyResources(this.label24, "label24");
			this.label24.ForeColor = System.Drawing.Color.White;
			this.label24.Name = "label24";
			// 
			// Sil
			// 
			this.Sil.BackColor = System.Drawing.Color.Gold;
			resources.ApplyResources(this.Sil, "Sil");
			this.Sil.Name = "Sil";
			this.Sil.UseVisualStyleBackColor = false;
			this.Sil.Click += new System.EventHandler(this.Sil_Click);
			// 
			// SepetListesiFiyat
			// 
			this.SepetListesiFiyat.BackColor = System.Drawing.Color.Black;
			resources.ApplyResources(this.SepetListesiFiyat, "SepetListesiFiyat");
			this.SepetListesiFiyat.ForeColor = System.Drawing.Color.White;
			this.SepetListesiFiyat.FormattingEnabled = true;
			this.SepetListesiFiyat.Name = "SepetListesiFiyat";
			// 
			// SepeteEkleButonu
			// 
			this.SepeteEkleButonu.BackColor = System.Drawing.Color.Gold;
			resources.ApplyResources(this.SepeteEkleButonu, "SepeteEkleButonu");
			this.SepeteEkleButonu.Name = "SepeteEkleButonu";
			this.SepeteEkleButonu.UseVisualStyleBackColor = false;
			this.SepeteEkleButonu.Click += new System.EventHandler(this.SepeteEkleButonu_Click);
			// 
			// SepetListesi
			// 
			this.SepetListesi.BackColor = System.Drawing.Color.Black;
			resources.ApplyResources(this.SepetListesi, "SepetListesi");
			this.SepetListesi.ForeColor = System.Drawing.Color.White;
			this.SepetListesi.FormattingEnabled = true;
			this.SepetListesi.Name = "SepetListesi";
			// 
			// label11
			// 
			resources.ApplyResources(this.label11, "label11");
			this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label11.Name = "label11";
			// 
			// Sepetim
			// 
			this.Sepetim.BackColor = System.Drawing.Color.Gold;
			resources.ApplyResources(this.Sepetim, "Sepetim");
			this.Sepetim.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Sepetim.Name = "Sepetim";
			this.Sepetim.UseVisualStyleBackColor = false;
			this.Sepetim.Click += new System.EventHandler(this.Sepetim_Click);
			// 
			// cikis
			// 
			this.cikis.BackColor = System.Drawing.Color.Gold;
			resources.ApplyResources(this.cikis, "cikis");
			this.cikis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.cikis.Name = "cikis";
			this.cikis.UseVisualStyleBackColor = false;
			this.cikis.Click += new System.EventHandler(this.button5_Click);
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Name = "label2";
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Name = "label1";
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Gold;
			resources.ApplyResources(this.button4, "button4");
			this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button4.Name = "button4";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// KitapKiralama
			// 
			this.KitapKiralama.BackColor = System.Drawing.Color.Gold;
			resources.ApplyResources(this.KitapKiralama, "KitapKiralama");
			this.KitapKiralama.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.KitapKiralama.Name = "KitapKiralama";
			this.KitapKiralama.UseVisualStyleBackColor = false;
			this.KitapKiralama.Click += new System.EventHandler(this.KitapKiralama_Click);
			// 
			// Anasayfa
			// 
			this.Anasayfa.BackColor = System.Drawing.Color.Gold;
			resources.ApplyResources(this.Anasayfa, "Anasayfa");
			this.Anasayfa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Anasayfa.Name = "Anasayfa";
			this.Anasayfa.UseVisualStyleBackColor = false;
			this.Anasayfa.Click += new System.EventHandler(this.Anasayfa_Click);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Gold;
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			resources.ApplyResources(this.panel3, "panel3");
			this.panel3.Name = "panel3";
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.Black;
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel4.Controls.Add(this.Hesabim);
			this.panel4.Controls.Add(this.KitapKiralaPencere);
			this.panel4.Controls.Add(this.SepetimPanel);
			this.panel4.Controls.Add(this.label6);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.label54);
			this.panel4.Controls.Add(this.label53);
			this.panel4.Controls.Add(this.label52);
			this.panel4.Controls.Add(this.label51);
			this.panel4.Controls.Add(this.label50);
			this.panel4.Controls.Add(this.label49);
			this.panel4.Controls.Add(this.label48);
			this.panel4.Controls.Add(this.label47);
			this.panel4.Controls.Add(this.label46);
			resources.ApplyResources(this.panel4, "panel4");
			this.panel4.Name = "panel4";
			// 
			// KitapKiralaPencere
			// 
			this.KitapKiralaPencere.Controls.Add(this.tabPage1);
			this.KitapKiralaPencere.Controls.Add(this.tabPage2);
			this.KitapKiralaPencere.Controls.Add(this.tabPage3);
			this.KitapKiralaPencere.Controls.Add(this.tabPage4);
			this.KitapKiralaPencere.Controls.Add(this.tabPage6);
			this.KitapKiralaPencere.Controls.Add(this.tabPage7);
			resources.ApplyResources(this.KitapKiralaPencere, "KitapKiralaPencere");
			this.KitapKiralaPencere.Name = "KitapKiralaPencere";
			this.KitapKiralaPencere.SelectedIndex = 0;
			this.KitapKiralaPencere.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.Black;
			this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tabPage1.Controls.Add(this.tabControl2);
			this.tabPage1.Controls.Add(this.panel5);
			resources.ApplyResources(this.tabPage1, "tabPage1");
			this.tabPage1.Name = "tabPage1";
			// 
			// tabControl2
			// 
			resources.ApplyResources(this.tabControl2, "tabControl2");
			this.tabControl2.Controls.Add(this.tabPage8);
			this.tabControl2.Controls.Add(this.tabPage9);
			this.tabControl2.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.tabControl2.Multiline = true;
			this.tabControl2.Name = "tabControl2";
			this.tabControl2.SelectedIndex = 0;
			this.tabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			// 
			// tabPage8
			// 
			this.tabPage8.BackColor = System.Drawing.Color.Black;
			this.tabPage8.Controls.Add(this.label22);
			this.tabPage8.Controls.Add(this.label21);
			this.tabPage8.Controls.Add(this.label20);
			this.tabPage8.Controls.Add(this.label19);
			this.tabPage8.Controls.Add(this.label18);
			this.tabPage8.Controls.Add(this.label17);
			this.tabPage8.Controls.Add(this.label16);
			this.tabPage8.Controls.Add(this.label15);
			this.tabPage8.Controls.Add(this.Kitapismi8);
			this.tabPage8.Controls.Add(this.Kitapismi7);
			this.tabPage8.Controls.Add(this.Kitapismi6);
			this.tabPage8.Controls.Add(this.Kitapismi5);
			this.tabPage8.Controls.Add(this.Kitapismi4);
			this.tabPage8.Controls.Add(this.Kitapismi3);
			this.tabPage8.Controls.Add(this.Kitapismi2);
			this.tabPage8.Controls.Add(this.Kitapismi1);
			this.tabPage8.Controls.Add(this.Kitap8Fiyat);
			this.tabPage8.Controls.Add(this.Kitap7Fiyat);
			this.tabPage8.Controls.Add(this.Kitap6Fiyat);
			this.tabPage8.Controls.Add(this.Kitap5Fiyat);
			this.tabPage8.Controls.Add(this.Kitap4Fiyat);
			this.tabPage8.Controls.Add(this.Kitap3Fiyat);
			this.tabPage8.Controls.Add(this.Kitap2Fiyat);
			this.tabPage8.Controls.Add(this.Kitap1Fiyat);
			this.tabPage8.Controls.Add(this.Kitap8);
			this.tabPage8.Controls.Add(this.Kitap7);
			this.tabPage8.Controls.Add(this.Kitap6);
			this.tabPage8.Controls.Add(this.Kitap5);
			this.tabPage8.Controls.Add(this.Kitap4);
			this.tabPage8.Controls.Add(this.Kitap3);
			this.tabPage8.Controls.Add(this.Kitap2);
			this.tabPage8.Controls.Add(this.Kitap1);
			resources.ApplyResources(this.tabPage8, "tabPage8");
			this.tabPage8.Name = "tabPage8";
			// 
			// Hesabim
			// 
			this.Hesabim.BackColor = System.Drawing.Color.Black;
			this.Hesabim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Hesabim.Controls.Add(this.tabControl1);
			this.Hesabim.Controls.Add(this.panel11);
			resources.ApplyResources(this.Hesabim, "Hesabim");
			this.Hesabim.Name = "Hesabim";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage13);
			this.tabControl1.Controls.Add(this.tabPage14);
			resources.ApplyResources(this.tabControl1, "tabControl1");
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			// 
			// tabPage13
			// 
			this.tabPage13.BackColor = System.Drawing.Color.Black;
			this.tabPage13.Controls.Add(this.label55);
			this.tabPage13.Controls.Add(this.VeriGuncelle);
			this.tabPage13.Controls.Add(this.textBox4);
			this.tabPage13.Controls.Add(this.textBox3);
			this.tabPage13.Controls.Add(this.textBox2);
			this.tabPage13.Controls.Add(this.textBox1);
			this.tabPage13.Controls.Add(this.label37);
			this.tabPage13.Controls.Add(this.label36);
			this.tabPage13.Controls.Add(this.label35);
			this.tabPage13.Controls.Add(this.label34);
			resources.ApplyResources(this.tabPage13, "tabPage13");
			this.tabPage13.Name = "tabPage13";
			// 
			// KapsayiciLogin
			// 
			this.KapsayiciLogin.BackColor = System.Drawing.Color.Black;
			this.KapsayiciLogin.Controls.Add(this.panel20);
			this.KapsayiciLogin.Controls.Add(this.panel14);
			resources.ApplyResources(this.KapsayiciLogin, "KapsayiciLogin");
			this.KapsayiciLogin.Name = "KapsayiciLogin";
			// 
			// panel14
			// 
			this.panel14.BackColor = System.Drawing.Color.White;
			this.panel14.Controls.Add(this.label56);
			this.panel14.Controls.Add(this.kayitOl);
			this.panel14.Controls.Add(this.label41);
			this.panel14.Controls.Add(this.linkLabel1);
			this.panel14.Controls.Add(this.label42);
			this.panel14.Controls.Add(this.label43);
			this.panel14.Controls.Add(this.label44);
			this.panel14.Controls.Add(this.GirisButon);
			this.panel14.Controls.Add(this.sifreTextBox);
			this.panel14.Controls.Add(this.kullaniciAdiTextBox);
			resources.ApplyResources(this.panel14, "panel14");
			this.panel14.Name = "panel14";
			// 
			// KayitPanel
			// 
			this.KayitPanel.BackColor = System.Drawing.Color.Black;
			this.KayitPanel.Controls.Add(this.panel19);
			this.KayitPanel.Controls.Add(this.panel13);
			resources.ApplyResources(this.KayitPanel, "KayitPanel");
			this.KayitPanel.Name = "KayitPanel";
			// 
			// panel13
			// 
			this.panel13.BackColor = System.Drawing.Color.White;
			this.panel13.Controls.Add(this.label57);
			this.panel13.Controls.Add(this.linkLabel2);
			this.panel13.Controls.Add(this.label39);
			this.panel13.Controls.Add(this.label40);
			this.panel13.Controls.Add(this.GirisYapKO);
			this.panel13.Controls.Add(this.KayitOlOnay);
			this.panel13.Controls.Add(this.textBox5);
			this.panel13.Controls.Add(this.textBox6);
			this.panel13.Controls.Add(this.textBox7);
			this.panel13.Controls.Add(this.textBox8);
			this.panel13.Controls.Add(this.sifreKayitOl);
			this.panel13.Controls.Add(this.EmailKayitOl);
			this.panel13.Controls.Add(this.KullaniciAdiKayitOl);
			this.panel13.Controls.Add(this.İsimKayitOl);
			resources.ApplyResources(this.panel13, "panel13");
			this.panel13.Name = "panel13";
			// 
			// label57
			// 
			resources.ApplyResources(this.label57, "label57");
			this.label57.Name = "label57";
			// 
			// linkLabel2
			// 
			resources.ApplyResources(this.linkLabel2, "linkLabel2");
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.TabStop = true;
			// 
			// label39
			// 
			resources.ApplyResources(this.label39, "label39");
			this.label39.ForeColor = System.Drawing.Color.Black;
			this.label39.Name = "label39";
			// 
			// label40
			// 
			resources.ApplyResources(this.label40, "label40");
			this.label40.ForeColor = System.Drawing.Color.Black;
			this.label40.Name = "label40";
			// 
			// GirisYapKO
			// 
			this.GirisYapKO.BackColor = System.Drawing.Color.White;
			resources.ApplyResources(this.GirisYapKO, "GirisYapKO");
			this.GirisYapKO.ForeColor = System.Drawing.Color.Black;
			this.GirisYapKO.Name = "GirisYapKO";
			this.GirisYapKO.UseVisualStyleBackColor = false;
			this.GirisYapKO.Click += new System.EventHandler(this.GirisYapKO_Click_1);
			// 
			// KayitOlOnay
			// 
			this.KayitOlOnay.BackColor = System.Drawing.Color.Gold;
			resources.ApplyResources(this.KayitOlOnay, "KayitOlOnay");
			this.KayitOlOnay.ForeColor = System.Drawing.Color.Black;
			this.KayitOlOnay.Name = "KayitOlOnay";
			this.KayitOlOnay.UseVisualStyleBackColor = false;
			this.KayitOlOnay.Click += new System.EventHandler(this.KayitOlOnay_Click_1);
			// 
			// textBox5
			// 
			resources.ApplyResources(this.textBox5, "textBox5");
			this.textBox5.Name = "textBox5";
			// 
			// textBox6
			// 
			resources.ApplyResources(this.textBox6, "textBox6");
			this.textBox6.Name = "textBox6";
			// 
			// textBox7
			// 
			resources.ApplyResources(this.textBox7, "textBox7");
			this.textBox7.Name = "textBox7";
			// 
			// textBox8
			// 
			resources.ApplyResources(this.textBox8, "textBox8");
			this.textBox8.Name = "textBox8";
			// 
			// sifreKayitOl
			// 
			resources.ApplyResources(this.sifreKayitOl, "sifreKayitOl");
			this.sifreKayitOl.ForeColor = System.Drawing.Color.Black;
			this.sifreKayitOl.Name = "sifreKayitOl";
			// 
			// EmailKayitOl
			// 
			resources.ApplyResources(this.EmailKayitOl, "EmailKayitOl");
			this.EmailKayitOl.ForeColor = System.Drawing.Color.Black;
			this.EmailKayitOl.Name = "EmailKayitOl";
			// 
			// KullaniciAdiKayitOl
			// 
			resources.ApplyResources(this.KullaniciAdiKayitOl, "KullaniciAdiKayitOl");
			this.KullaniciAdiKayitOl.ForeColor = System.Drawing.Color.Black;
			this.KullaniciAdiKayitOl.Name = "KullaniciAdiKayitOl";
			// 
			// İsimKayitOl
			// 
			resources.ApplyResources(this.İsimKayitOl, "İsimKayitOl");
			this.İsimKayitOl.BackColor = System.Drawing.Color.White;
			this.İsimKayitOl.ForeColor = System.Drawing.Color.Black;
			this.İsimKayitOl.Name = "İsimKayitOl";
			// 
			// label56
			// 
			resources.ApplyResources(this.label56, "label56");
			this.label56.Name = "label56";
			// 
			// kayitOl
			// 
			this.kayitOl.BackColor = System.Drawing.Color.Gold;
			resources.ApplyResources(this.kayitOl, "kayitOl");
			this.kayitOl.ForeColor = System.Drawing.Color.Black;
			this.kayitOl.Name = "kayitOl";
			this.kayitOl.UseVisualStyleBackColor = false;
			this.kayitOl.Click += new System.EventHandler(this.kayitOl_Click_1);
			// 
			// label41
			// 
			resources.ApplyResources(this.label41, "label41");
			this.label41.Name = "label41";
			// 
			// linkLabel1
			// 
			resources.ApplyResources(this.linkLabel1, "linkLabel1");
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.TabStop = true;
			// 
			// label42
			// 
			resources.ApplyResources(this.label42, "label42");
			this.label42.Name = "label42";
			// 
			// label43
			// 
			resources.ApplyResources(this.label43, "label43");
			this.label43.Name = "label43";
			// 
			// label44
			// 
			resources.ApplyResources(this.label44, "label44");
			this.label44.Name = "label44";
			// 
			// GirisButon
			// 
			this.GirisButon.BackColor = System.Drawing.Color.Gold;
			resources.ApplyResources(this.GirisButon, "GirisButon");
			this.GirisButon.ForeColor = System.Drawing.Color.Black;
			this.GirisButon.Name = "GirisButon";
			this.GirisButon.UseVisualStyleBackColor = false;
			this.GirisButon.Click += new System.EventHandler(this.GirisButon_Click_1);
			// 
			// sifreTextBox
			// 
			resources.ApplyResources(this.sifreTextBox, "sifreTextBox");
			this.sifreTextBox.Name = "sifreTextBox";
			// 
			// kullaniciAdiTextBox
			// 
			resources.ApplyResources(this.kullaniciAdiTextBox, "kullaniciAdiTextBox");
			this.kullaniciAdiTextBox.Name = "kullaniciAdiTextBox";
			// 
			// label55
			// 
			resources.ApplyResources(this.label55, "label55");
			this.label55.ForeColor = System.Drawing.Color.White;
			this.label55.Name = "label55";
			// 
			// VeriGuncelle
			// 
			this.VeriGuncelle.BackColor = System.Drawing.Color.Gold;
			resources.ApplyResources(this.VeriGuncelle, "VeriGuncelle");
			this.VeriGuncelle.ForeColor = System.Drawing.Color.Black;
			this.VeriGuncelle.Name = "VeriGuncelle";
			this.VeriGuncelle.UseVisualStyleBackColor = false;
			this.VeriGuncelle.Click += new System.EventHandler(this.VeriGuncelle_Click);
			// 
			// textBox4
			// 
			resources.ApplyResources(this.textBox4, "textBox4");
			this.textBox4.Name = "textBox4";
			// 
			// textBox3
			// 
			resources.ApplyResources(this.textBox3, "textBox3");
			this.textBox3.Name = "textBox3";
			// 
			// textBox2
			// 
			resources.ApplyResources(this.textBox2, "textBox2");
			this.textBox2.Name = "textBox2";
			// 
			// textBox1
			// 
			resources.ApplyResources(this.textBox1, "textBox1");
			this.textBox1.Name = "textBox1";
			// 
			// label37
			// 
			resources.ApplyResources(this.label37, "label37");
			this.label37.ForeColor = System.Drawing.Color.White;
			this.label37.Name = "label37";
			// 
			// label36
			// 
			resources.ApplyResources(this.label36, "label36");
			this.label36.ForeColor = System.Drawing.Color.White;
			this.label36.Name = "label36";
			// 
			// label35
			// 
			resources.ApplyResources(this.label35, "label35");
			this.label35.ForeColor = System.Drawing.Color.White;
			this.label35.Name = "label35";
			// 
			// label34
			// 
			resources.ApplyResources(this.label34, "label34");
			this.label34.ForeColor = System.Drawing.Color.White;
			this.label34.Name = "label34";
			// 
			// tabPage14
			// 
			this.tabPage14.BackColor = System.Drawing.Color.Black;
			this.tabPage14.Controls.Add(this.Kalangun);
			this.tabPage14.Controls.Add(this.kiralamaZamani);
			this.tabPage14.Controls.Add(this.label31);
			this.tabPage14.Controls.Add(this.HesabimListbox);
			resources.ApplyResources(this.tabPage14, "tabPage14");
			this.tabPage14.Name = "tabPage14";
			// 
			// Kalangun
			// 
			this.Kalangun.BackColor = System.Drawing.Color.Black;
			this.Kalangun.BorderStyle = System.Windows.Forms.BorderStyle.None;
			resources.ApplyResources(this.Kalangun, "Kalangun");
			this.Kalangun.ForeColor = System.Drawing.Color.Gold;
			this.Kalangun.FormattingEnabled = true;
			this.Kalangun.Name = "Kalangun";
			// 
			// kiralamaZamani
			// 
			this.kiralamaZamani.BackColor = System.Drawing.Color.Black;
			this.kiralamaZamani.BorderStyle = System.Windows.Forms.BorderStyle.None;
			resources.ApplyResources(this.kiralamaZamani, "kiralamaZamani");
			this.kiralamaZamani.ForeColor = System.Drawing.Color.Gold;
			this.kiralamaZamani.FormattingEnabled = true;
			this.kiralamaZamani.Name = "kiralamaZamani";
			// 
			// label31
			// 
			resources.ApplyResources(this.label31, "label31");
			this.label31.ForeColor = System.Drawing.Color.Gold;
			this.label31.Name = "label31";
			// 
			// HesabimListbox
			// 
			this.HesabimListbox.BackColor = System.Drawing.Color.Black;
			this.HesabimListbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			resources.ApplyResources(this.HesabimListbox, "HesabimListbox");
			this.HesabimListbox.ForeColor = System.Drawing.Color.Gold;
			this.HesabimListbox.FormattingEnabled = true;
			this.HesabimListbox.Name = "HesabimListbox";
			// 
			// panel11
			// 
			this.panel11.BackColor = System.Drawing.Color.Gold;
			this.panel11.Controls.Add(this.label33);
			this.panel11.Controls.Add(this.label32);
			resources.ApplyResources(this.panel11, "panel11");
			this.panel11.Name = "panel11";
			// 
			// label33
			// 
			resources.ApplyResources(this.label33, "label33");
			this.label33.Name = "label33";
			// 
			// label32
			// 
			resources.ApplyResources(this.label32, "label32");
			this.label32.Name = "label32";
			// 
			// label22
			// 
			resources.ApplyResources(this.label22, "label22");
			this.label22.ForeColor = System.Drawing.Color.White;
			this.label22.Name = "label22";
			// 
			// label21
			// 
			resources.ApplyResources(this.label21, "label21");
			this.label21.ForeColor = System.Drawing.Color.White;
			this.label21.Name = "label21";
			// 
			// label20
			// 
			resources.ApplyResources(this.label20, "label20");
			this.label20.ForeColor = System.Drawing.Color.White;
			this.label20.Name = "label20";
			// 
			// label19
			// 
			resources.ApplyResources(this.label19, "label19");
			this.label19.ForeColor = System.Drawing.Color.White;
			this.label19.Name = "label19";
			// 
			// label18
			// 
			resources.ApplyResources(this.label18, "label18");
			this.label18.ForeColor = System.Drawing.Color.White;
			this.label18.Name = "label18";
			// 
			// label17
			// 
			resources.ApplyResources(this.label17, "label17");
			this.label17.ForeColor = System.Drawing.Color.White;
			this.label17.Name = "label17";
			// 
			// label16
			// 
			resources.ApplyResources(this.label16, "label16");
			this.label16.ForeColor = System.Drawing.Color.White;
			this.label16.Name = "label16";
			// 
			// label15
			// 
			resources.ApplyResources(this.label15, "label15");
			this.label15.ForeColor = System.Drawing.Color.White;
			this.label15.Name = "label15";
			// 
			// Kitapismi8
			// 
			resources.ApplyResources(this.Kitapismi8, "Kitapismi8");
			this.Kitapismi8.ForeColor = System.Drawing.Color.White;
			this.Kitapismi8.Name = "Kitapismi8";
			// 
			// Kitapismi7
			// 
			resources.ApplyResources(this.Kitapismi7, "Kitapismi7");
			this.Kitapismi7.ForeColor = System.Drawing.Color.White;
			this.Kitapismi7.Name = "Kitapismi7";
			// 
			// Kitapismi6
			// 
			resources.ApplyResources(this.Kitapismi6, "Kitapismi6");
			this.Kitapismi6.ForeColor = System.Drawing.Color.White;
			this.Kitapismi6.Name = "Kitapismi6";
			// 
			// Kitapismi5
			// 
			resources.ApplyResources(this.Kitapismi5, "Kitapismi5");
			this.Kitapismi5.ForeColor = System.Drawing.Color.White;
			this.Kitapismi5.Name = "Kitapismi5";
			// 
			// Kitapismi4
			// 
			resources.ApplyResources(this.Kitapismi4, "Kitapismi4");
			this.Kitapismi4.ForeColor = System.Drawing.Color.White;
			this.Kitapismi4.Name = "Kitapismi4";
			// 
			// Kitapismi3
			// 
			resources.ApplyResources(this.Kitapismi3, "Kitapismi3");
			this.Kitapismi3.ForeColor = System.Drawing.Color.White;
			this.Kitapismi3.Name = "Kitapismi3";
			// 
			// Kitapismi2
			// 
			resources.ApplyResources(this.Kitapismi2, "Kitapismi2");
			this.Kitapismi2.ForeColor = System.Drawing.Color.White;
			this.Kitapismi2.Name = "Kitapismi2";
			// 
			// Kitapismi1
			// 
			resources.ApplyResources(this.Kitapismi1, "Kitapismi1");
			this.Kitapismi1.ForeColor = System.Drawing.Color.White;
			this.Kitapismi1.Name = "Kitapismi1";
			// 
			// Kitap8Fiyat
			// 
			resources.ApplyResources(this.Kitap8Fiyat, "Kitap8Fiyat");
			this.Kitap8Fiyat.ForeColor = System.Drawing.Color.White;
			this.Kitap8Fiyat.Name = "Kitap8Fiyat";
			// 
			// Kitap7Fiyat
			// 
			resources.ApplyResources(this.Kitap7Fiyat, "Kitap7Fiyat");
			this.Kitap7Fiyat.ForeColor = System.Drawing.Color.White;
			this.Kitap7Fiyat.Name = "Kitap7Fiyat";
			// 
			// Kitap6Fiyat
			// 
			resources.ApplyResources(this.Kitap6Fiyat, "Kitap6Fiyat");
			this.Kitap6Fiyat.ForeColor = System.Drawing.Color.White;
			this.Kitap6Fiyat.Name = "Kitap6Fiyat";
			// 
			// Kitap5Fiyat
			// 
			resources.ApplyResources(this.Kitap5Fiyat, "Kitap5Fiyat");
			this.Kitap5Fiyat.ForeColor = System.Drawing.Color.White;
			this.Kitap5Fiyat.Name = "Kitap5Fiyat";
			// 
			// Kitap4Fiyat
			// 
			resources.ApplyResources(this.Kitap4Fiyat, "Kitap4Fiyat");
			this.Kitap4Fiyat.ForeColor = System.Drawing.Color.White;
			this.Kitap4Fiyat.Name = "Kitap4Fiyat";
			// 
			// Kitap3Fiyat
			// 
			resources.ApplyResources(this.Kitap3Fiyat, "Kitap3Fiyat");
			this.Kitap3Fiyat.ForeColor = System.Drawing.Color.White;
			this.Kitap3Fiyat.Name = "Kitap3Fiyat";
			// 
			// Kitap2Fiyat
			// 
			resources.ApplyResources(this.Kitap2Fiyat, "Kitap2Fiyat");
			this.Kitap2Fiyat.ForeColor = System.Drawing.Color.White;
			this.Kitap2Fiyat.Name = "Kitap2Fiyat";
			// 
			// Kitap1Fiyat
			// 
			resources.ApplyResources(this.Kitap1Fiyat, "Kitap1Fiyat");
			this.Kitap1Fiyat.ForeColor = System.Drawing.Color.White;
			this.Kitap1Fiyat.Name = "Kitap1Fiyat";
			// 
			// Kitap8
			// 
			resources.ApplyResources(this.Kitap8, "Kitap8");
			this.Kitap8.ForeColor = System.Drawing.Color.Transparent;
			this.Kitap8.Name = "Kitap8";
			this.Kitap8.UseVisualStyleBackColor = true;
			this.Kitap8.Click += new System.EventHandler(this.Kitap8_Click);
			// 
			// Kitap7
			// 
			this.Kitap7.ForeColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.Kitap7, "Kitap7");
			this.Kitap7.Name = "Kitap7";
			this.Kitap7.UseVisualStyleBackColor = true;
			this.Kitap7.Click += new System.EventHandler(this.Kitap7_Click);
			// 
			// Kitap6
			// 
			this.Kitap6.ForeColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.Kitap6, "Kitap6");
			this.Kitap6.Name = "Kitap6";
			this.Kitap6.UseVisualStyleBackColor = true;
			this.Kitap6.Click += new System.EventHandler(this.Kitap6_Click);
			// 
			// Kitap5
			// 
			this.Kitap5.ForeColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.Kitap5, "Kitap5");
			this.Kitap5.Name = "Kitap5";
			this.Kitap5.UseVisualStyleBackColor = true;
			this.Kitap5.Click += new System.EventHandler(this.Kitap5_Click);
			// 
			// Kitap4
			// 
			this.Kitap4.ForeColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.Kitap4, "Kitap4");
			this.Kitap4.Name = "Kitap4";
			this.Kitap4.UseVisualStyleBackColor = true;
			this.Kitap4.Click += new System.EventHandler(this.Kitap4_Click);
			// 
			// Kitap3
			// 
			this.Kitap3.ForeColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.Kitap3, "Kitap3");
			this.Kitap3.Name = "Kitap3";
			this.Kitap3.UseVisualStyleBackColor = true;
			this.Kitap3.Click += new System.EventHandler(this.Kitap3_Click);
			// 
			// Kitap2
			// 
			this.Kitap2.ForeColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.Kitap2, "Kitap2");
			this.Kitap2.Name = "Kitap2";
			this.Kitap2.UseVisualStyleBackColor = true;
			this.Kitap2.Click += new System.EventHandler(this.Kitap2_Click);
			// 
			// Kitap1
			// 
			this.Kitap1.ForeColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.Kitap1, "Kitap1");
			this.Kitap1.Name = "Kitap1";
			this.Kitap1.UseVisualStyleBackColor = true;
			this.Kitap1.Click += new System.EventHandler(this.Kitap1_Click);
			// 
			// tabPage9
			// 
			this.tabPage9.BackColor = System.Drawing.Color.Black;
			this.tabPage9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tabPage9.Controls.Add(this.label30);
			this.tabPage9.Controls.Add(this.label29);
			this.tabPage9.Controls.Add(this.label28);
			this.tabPage9.Controls.Add(this.label27);
			this.tabPage9.Controls.Add(this.label25);
			this.tabPage9.Controls.Add(this.Kitap12Fiyat);
			this.tabPage9.Controls.Add(this.Kitap11Fiyat);
			this.tabPage9.Controls.Add(this.Kitap10Fiyat);
			this.tabPage9.Controls.Add(this.Kitap9Fiyat);
			this.tabPage9.Controls.Add(this.Kitap13Fiyat);
			this.tabPage9.Controls.Add(this.Kitapismi13);
			this.tabPage9.Controls.Add(this.Kitapismi12);
			this.tabPage9.Controls.Add(this.Kitapismi11);
			this.tabPage9.Controls.Add(this.Kitapismi10);
			this.tabPage9.Controls.Add(this.Kitapismi9);
			this.tabPage9.Controls.Add(this.Kitap13);
			this.tabPage9.Controls.Add(this.Kitap12);
			this.tabPage9.Controls.Add(this.Kitap11);
			this.tabPage9.Controls.Add(this.Kitap10);
			this.tabPage9.Controls.Add(this.Kitap9);
			resources.ApplyResources(this.tabPage9, "tabPage9");
			this.tabPage9.Name = "tabPage9";
			// 
			// label30
			// 
			resources.ApplyResources(this.label30, "label30");
			this.label30.ForeColor = System.Drawing.Color.White;
			this.label30.Name = "label30";
			// 
			// label29
			// 
			resources.ApplyResources(this.label29, "label29");
			this.label29.ForeColor = System.Drawing.Color.White;
			this.label29.Name = "label29";
			// 
			// label28
			// 
			resources.ApplyResources(this.label28, "label28");
			this.label28.ForeColor = System.Drawing.Color.White;
			this.label28.Name = "label28";
			// 
			// label27
			// 
			resources.ApplyResources(this.label27, "label27");
			this.label27.ForeColor = System.Drawing.Color.White;
			this.label27.Name = "label27";
			// 
			// label25
			// 
			resources.ApplyResources(this.label25, "label25");
			this.label25.ForeColor = System.Drawing.Color.White;
			this.label25.Name = "label25";
			// 
			// Kitap12Fiyat
			// 
			resources.ApplyResources(this.Kitap12Fiyat, "Kitap12Fiyat");
			this.Kitap12Fiyat.ForeColor = System.Drawing.Color.White;
			this.Kitap12Fiyat.Name = "Kitap12Fiyat";
			// 
			// Kitap11Fiyat
			// 
			resources.ApplyResources(this.Kitap11Fiyat, "Kitap11Fiyat");
			this.Kitap11Fiyat.ForeColor = System.Drawing.Color.White;
			this.Kitap11Fiyat.Name = "Kitap11Fiyat";
			// 
			// Kitap10Fiyat
			// 
			resources.ApplyResources(this.Kitap10Fiyat, "Kitap10Fiyat");
			this.Kitap10Fiyat.ForeColor = System.Drawing.Color.White;
			this.Kitap10Fiyat.Name = "Kitap10Fiyat";
			// 
			// Kitap9Fiyat
			// 
			resources.ApplyResources(this.Kitap9Fiyat, "Kitap9Fiyat");
			this.Kitap9Fiyat.ForeColor = System.Drawing.Color.White;
			this.Kitap9Fiyat.Name = "Kitap9Fiyat";
			// 
			// Kitap13Fiyat
			// 
			resources.ApplyResources(this.Kitap13Fiyat, "Kitap13Fiyat");
			this.Kitap13Fiyat.ForeColor = System.Drawing.Color.White;
			this.Kitap13Fiyat.Name = "Kitap13Fiyat";
			// 
			// Kitapismi13
			// 
			resources.ApplyResources(this.Kitapismi13, "Kitapismi13");
			this.Kitapismi13.ForeColor = System.Drawing.Color.White;
			this.Kitapismi13.Name = "Kitapismi13";
			// 
			// Kitapismi12
			// 
			resources.ApplyResources(this.Kitapismi12, "Kitapismi12");
			this.Kitapismi12.ForeColor = System.Drawing.Color.White;
			this.Kitapismi12.Name = "Kitapismi12";
			// 
			// Kitapismi11
			// 
			resources.ApplyResources(this.Kitapismi11, "Kitapismi11");
			this.Kitapismi11.ForeColor = System.Drawing.Color.White;
			this.Kitapismi11.Name = "Kitapismi11";
			// 
			// Kitapismi10
			// 
			resources.ApplyResources(this.Kitapismi10, "Kitapismi10");
			this.Kitapismi10.ForeColor = System.Drawing.Color.White;
			this.Kitapismi10.Name = "Kitapismi10";
			// 
			// Kitapismi9
			// 
			resources.ApplyResources(this.Kitapismi9, "Kitapismi9");
			this.Kitapismi9.ForeColor = System.Drawing.Color.White;
			this.Kitapismi9.Name = "Kitapismi9";
			// 
			// Kitap13
			// 
			this.Kitap13.ForeColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.Kitap13, "Kitap13");
			this.Kitap13.Name = "Kitap13";
			this.Kitap13.UseVisualStyleBackColor = true;
			this.Kitap13.Click += new System.EventHandler(this.Kitap13_Click);
			// 
			// Kitap12
			// 
			this.Kitap12.ForeColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.Kitap12, "Kitap12");
			this.Kitap12.Name = "Kitap12";
			this.Kitap12.UseVisualStyleBackColor = true;
			this.Kitap12.Click += new System.EventHandler(this.Kitap12_Click);
			// 
			// Kitap11
			// 
			this.Kitap11.ForeColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.Kitap11, "Kitap11");
			this.Kitap11.Name = "Kitap11";
			this.Kitap11.UseVisualStyleBackColor = true;
			this.Kitap11.Click += new System.EventHandler(this.Kitap11_Click);
			// 
			// Kitap10
			// 
			this.Kitap10.ForeColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.Kitap10, "Kitap10");
			this.Kitap10.Name = "Kitap10";
			this.Kitap10.UseVisualStyleBackColor = true;
			this.Kitap10.Click += new System.EventHandler(this.Kitap10_Click);
			// 
			// Kitap9
			// 
			this.Kitap9.ForeColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.Kitap9, "Kitap9");
			this.Kitap9.Name = "Kitap9";
			this.Kitap9.UseVisualStyleBackColor = true;
			this.Kitap9.Click += new System.EventHandler(this.Kitap9_Click);
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.Gold;
			this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel5.Controls.Add(this.label3);
			resources.ApplyResources(this.panel5, "panel5");
			this.panel5.Name = "panel5";
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.Black;
			this.tabPage2.Controls.Add(this.panel12);
			this.tabPage2.Controls.Add(this.label65);
			this.tabPage2.Controls.Add(this.label64);
			this.tabPage2.Controls.Add(this.label63);
			this.tabPage2.Controls.Add(this.label62);
			this.tabPage2.Controls.Add(this.label61);
			this.tabPage2.Controls.Add(this.label60);
			this.tabPage2.Controls.Add(this.label59);
			this.tabPage2.Controls.Add(this.label58);
			this.tabPage2.Controls.Add(this.Kitap21Fiyat);
			this.tabPage2.Controls.Add(this.Kitap20Fiyat);
			this.tabPage2.Controls.Add(this.Kitap19Fiyat);
			this.tabPage2.Controls.Add(this.Kitap18Fiyat);
			this.tabPage2.Controls.Add(this.Kitap17Fiyat);
			this.tabPage2.Controls.Add(this.Kitap16Fiyat);
			this.tabPage2.Controls.Add(this.Kitap15Fiyat);
			this.tabPage2.Controls.Add(this.Kitap14Fiyat);
			this.tabPage2.Controls.Add(this.Kitapismi21);
			this.tabPage2.Controls.Add(this.Kitapismi20);
			this.tabPage2.Controls.Add(this.Kitapismi19);
			this.tabPage2.Controls.Add(this.Kitapismi18);
			this.tabPage2.Controls.Add(this.Kitapismi17);
			this.tabPage2.Controls.Add(this.Kitapismi16);
			this.tabPage2.Controls.Add(this.Kitapismi15);
			this.tabPage2.Controls.Add(this.Kitapismi14);
			this.tabPage2.Controls.Add(this.Kitap21);
			this.tabPage2.Controls.Add(this.Kitap20);
			this.tabPage2.Controls.Add(this.Kitap19);
			this.tabPage2.Controls.Add(this.Kitap18);
			this.tabPage2.Controls.Add(this.Kitap17);
			this.tabPage2.Controls.Add(this.Kitap16);
			this.tabPage2.Controls.Add(this.Kitap15);
			this.tabPage2.Controls.Add(this.Kitap14);
			resources.ApplyResources(this.tabPage2, "tabPage2");
			this.tabPage2.Name = "tabPage2";
			// 
			// tabPage3
			// 
			this.tabPage3.BackColor = System.Drawing.Color.Black;
			this.tabPage3.Controls.Add(this.panel15);
			this.tabPage3.Controls.Add(this.label73);
			this.tabPage3.Controls.Add(this.label72);
			this.tabPage3.Controls.Add(this.label71);
			this.tabPage3.Controls.Add(this.label70);
			this.tabPage3.Controls.Add(this.label69);
			this.tabPage3.Controls.Add(this.label68);
			this.tabPage3.Controls.Add(this.label67);
			this.tabPage3.Controls.Add(this.label66);
			this.tabPage3.Controls.Add(this.Kitap29Fiyat);
			this.tabPage3.Controls.Add(this.Kitap28Fiyat);
			this.tabPage3.Controls.Add(this.Kitap27Fiyat);
			this.tabPage3.Controls.Add(this.Kitap26Fiyat);
			this.tabPage3.Controls.Add(this.Kitap25Fiyat);
			this.tabPage3.Controls.Add(this.Kitap24Fiyat);
			this.tabPage3.Controls.Add(this.Kitap23Fiyat);
			this.tabPage3.Controls.Add(this.Kitap22Fiyat);
			this.tabPage3.Controls.Add(this.Kitapismi29);
			this.tabPage3.Controls.Add(this.Kitapismi28);
			this.tabPage3.Controls.Add(this.Kitapismi27);
			this.tabPage3.Controls.Add(this.Kitapismi26);
			this.tabPage3.Controls.Add(this.Kitapismi25);
			this.tabPage3.Controls.Add(this.Kitapismi24);
			this.tabPage3.Controls.Add(this.Kitapismi23);
			this.tabPage3.Controls.Add(this.Kitapismi22);
			this.tabPage3.Controls.Add(this.Kitap29);
			this.tabPage3.Controls.Add(this.Kitap28);
			this.tabPage3.Controls.Add(this.Kitap27);
			this.tabPage3.Controls.Add(this.Kitap26);
			this.tabPage3.Controls.Add(this.Kitap25);
			this.tabPage3.Controls.Add(this.Kitap24);
			this.tabPage3.Controls.Add(this.Kitap23);
			this.tabPage3.Controls.Add(this.Kitap22);
			resources.ApplyResources(this.tabPage3, "tabPage3");
			this.tabPage3.Name = "tabPage3";
			// 
			// tabPage4
			// 
			this.tabPage4.BackColor = System.Drawing.Color.Black;
			this.tabPage4.Controls.Add(this.panel16);
			this.tabPage4.Controls.Add(this.label77);
			this.tabPage4.Controls.Add(this.label76);
			this.tabPage4.Controls.Add(this.label75);
			this.tabPage4.Controls.Add(this.label74);
			this.tabPage4.Controls.Add(this.Kitap33Fiyat);
			this.tabPage4.Controls.Add(this.Kitap32Fiyat);
			this.tabPage4.Controls.Add(this.Kitap31Fiyat);
			this.tabPage4.Controls.Add(this.Kitap30Fiyat);
			this.tabPage4.Controls.Add(this.Kitapismi33);
			this.tabPage4.Controls.Add(this.Kitapismi32);
			this.tabPage4.Controls.Add(this.Kitapismi31);
			this.tabPage4.Controls.Add(this.Kitapismi30);
			this.tabPage4.Controls.Add(this.Kitap33);
			this.tabPage4.Controls.Add(this.Kitap32);
			this.tabPage4.Controls.Add(this.Kitap31);
			this.tabPage4.Controls.Add(this.Kitap30);
			resources.ApplyResources(this.tabPage4, "tabPage4");
			this.tabPage4.Name = "tabPage4";
			// 
			// tabPage6
			// 
			this.tabPage6.BackColor = System.Drawing.Color.Black;
			this.tabPage6.Controls.Add(this.panel17);
			this.tabPage6.Controls.Add(this.label82);
			this.tabPage6.Controls.Add(this.label81);
			this.tabPage6.Controls.Add(this.label80);
			this.tabPage6.Controls.Add(this.label79);
			this.tabPage6.Controls.Add(this.label78);
			this.tabPage6.Controls.Add(this.Kitap38Fiyat);
			this.tabPage6.Controls.Add(this.Kitap37Fiyat);
			this.tabPage6.Controls.Add(this.Kitap36Fiyat);
			this.tabPage6.Controls.Add(this.Kitap35Fiyat);
			this.tabPage6.Controls.Add(this.Kitap34Fiyat);
			this.tabPage6.Controls.Add(this.Kitapismi38);
			this.tabPage6.Controls.Add(this.Kitapismi37);
			this.tabPage6.Controls.Add(this.Kitapismi36);
			this.tabPage6.Controls.Add(this.Kitapismi35);
			this.tabPage6.Controls.Add(this.Kitapismi34);
			this.tabPage6.Controls.Add(this.Kitap38);
			this.tabPage6.Controls.Add(this.Kitap37);
			this.tabPage6.Controls.Add(this.Kitap36);
			this.tabPage6.Controls.Add(this.Kitap35);
			this.tabPage6.Controls.Add(this.Kitap34);
			resources.ApplyResources(this.tabPage6, "tabPage6");
			this.tabPage6.Name = "tabPage6";
			// 
			// tabPage7
			// 
			this.tabPage7.BackColor = System.Drawing.Color.Black;
			this.tabPage7.Controls.Add(this.panel18);
			this.tabPage7.Controls.Add(this.label86);
			this.tabPage7.Controls.Add(this.label85);
			this.tabPage7.Controls.Add(this.label84);
			this.tabPage7.Controls.Add(this.label83);
			this.tabPage7.Controls.Add(this.Kitap42Fiyat);
			this.tabPage7.Controls.Add(this.Kitap41Fiyat);
			this.tabPage7.Controls.Add(this.Kitap40Fiyat);
			this.tabPage7.Controls.Add(this.Kitap39Fiyat);
			this.tabPage7.Controls.Add(this.Kitapismi42);
			this.tabPage7.Controls.Add(this.Kitapismi41);
			this.tabPage7.Controls.Add(this.Kitapismi40);
			this.tabPage7.Controls.Add(this.Kitapismi39);
			this.tabPage7.Controls.Add(this.Kitap42);
			this.tabPage7.Controls.Add(this.Kitap41);
			this.tabPage7.Controls.Add(this.Kitap40);
			this.tabPage7.Controls.Add(this.Kitap39);
			resources.ApplyResources(this.tabPage7, "tabPage7");
			this.tabPage7.Name = "tabPage7";
			// 
			// SepetimPanel
			// 
			this.SepetimPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.SepetimPanel.Controls.Add(this.panel7);
			this.SepetimPanel.Controls.Add(this.panel6);
			this.SepetimPanel.Controls.Add(this.panel8);
			this.SepetimPanel.Controls.Add(this.panel9);
			resources.ApplyResources(this.SepetimPanel, "SepetimPanel");
			this.SepetimPanel.Name = "SepetimPanel";
			// 
			// panel7
			// 
			this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel7.Controls.Add(this.label23);
			this.panel7.Controls.Add(this.label26);
			this.panel7.Controls.Add(this.ToplamFiyat);
			this.panel7.Controls.Add(this.Vergi);
			this.panel7.Controls.Add(this.NormalFiyat);
			this.panel7.Controls.Add(this.button2);
			this.panel7.Controls.Add(this.label10);
			this.panel7.Controls.Add(this.label9);
			this.panel7.Controls.Add(this.label8);
			resources.ApplyResources(this.panel7, "panel7");
			this.panel7.Name = "panel7";
			// 
			// label23
			// 
			resources.ApplyResources(this.label23, "label23");
			this.label23.ForeColor = System.Drawing.Color.White;
			this.label23.Name = "label23";
			// 
			// label26
			// 
			resources.ApplyResources(this.label26, "label26");
			this.label26.ForeColor = System.Drawing.Color.White;
			this.label26.Name = "label26";
			// 
			// ToplamFiyat
			// 
			resources.ApplyResources(this.ToplamFiyat, "ToplamFiyat");
			this.ToplamFiyat.ForeColor = System.Drawing.Color.White;
			this.ToplamFiyat.Name = "ToplamFiyat";
			// 
			// Vergi
			// 
			resources.ApplyResources(this.Vergi, "Vergi");
			this.Vergi.ForeColor = System.Drawing.Color.White;
			this.Vergi.Name = "Vergi";
			// 
			// NormalFiyat
			// 
			resources.ApplyResources(this.NormalFiyat, "NormalFiyat");
			this.NormalFiyat.ForeColor = System.Drawing.Color.White;
			this.NormalFiyat.Name = "NormalFiyat";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Gold;
			resources.ApplyResources(this.button2, "button2");
			this.button2.Name = "button2";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label10
			// 
			resources.ApplyResources(this.label10, "label10");
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Name = "label10";
			// 
			// label9
			// 
			resources.ApplyResources(this.label9, "label9");
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Name = "label9";
			// 
			// label8
			// 
			resources.ApplyResources(this.label8, "label8");
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Name = "label8";
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.Gold;
			this.panel6.Controls.Add(this.label7);
			resources.ApplyResources(this.panel6, "panel6");
			this.panel6.Name = "panel6";
			// 
			// label7
			// 
			resources.ApplyResources(this.label7, "label7");
			this.label7.Name = "label7";
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.Black;
			this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel8.Controls.Add(this.SepetiTemizle);
			this.panel8.Controls.Add(this.label14);
			this.panel8.Controls.Add(this.label12);
			this.panel8.Controls.Add(this.label13);
			this.panel8.Controls.Add(this.SepetFiyat);
			this.panel8.Controls.Add(this.Sepetİsim);
			resources.ApplyResources(this.panel8, "panel8");
			this.panel8.Name = "panel8";
			// 
			// SepetiTemizle
			// 
			this.SepetiTemizle.BackColor = System.Drawing.Color.Gold;
			resources.ApplyResources(this.SepetiTemizle, "SepetiTemizle");
			this.SepetiTemizle.Name = "SepetiTemizle";
			this.SepetiTemizle.UseVisualStyleBackColor = false;
			this.SepetiTemizle.Click += new System.EventHandler(this.SepetiTemizle_Click);
			// 
			// label14
			// 
			resources.ApplyResources(this.label14, "label14");
			this.label14.ForeColor = System.Drawing.Color.White;
			this.label14.Name = "label14";
			// 
			// label12
			// 
			resources.ApplyResources(this.label12, "label12");
			this.label12.ForeColor = System.Drawing.Color.White;
			this.label12.Name = "label12";
			// 
			// label13
			// 
			resources.ApplyResources(this.label13, "label13");
			this.label13.ForeColor = System.Drawing.Color.White;
			this.label13.Name = "label13";
			// 
			// SepetFiyat
			// 
			this.SepetFiyat.BackColor = System.Drawing.Color.Black;
			this.SepetFiyat.BorderStyle = System.Windows.Forms.BorderStyle.None;
			resources.ApplyResources(this.SepetFiyat, "SepetFiyat");
			this.SepetFiyat.ForeColor = System.Drawing.Color.Gold;
			this.SepetFiyat.FormattingEnabled = true;
			this.SepetFiyat.Name = "SepetFiyat";
			// 
			// Sepetİsim
			// 
			this.Sepetİsim.BackColor = System.Drawing.Color.Black;
			this.Sepetİsim.BorderStyle = System.Windows.Forms.BorderStyle.None;
			resources.ApplyResources(this.Sepetİsim, "Sepetİsim");
			this.Sepetİsim.ForeColor = System.Drawing.Color.Gold;
			this.Sepetİsim.FormattingEnabled = true;
			this.Sepetİsim.Name = "Sepetİsim";
			// 
			// panel9
			// 
			this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			resources.ApplyResources(this.panel9, "panel9");
			this.panel9.Name = "panel9";
			// 
			// label6
			// 
			resources.ApplyResources(this.label6, "label6");
			this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label6.Name = "label6";
			// 
			// label4
			// 
			resources.ApplyResources(this.label4, "label4");
			this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label4.Name = "label4";
			// 
			// label5
			// 
			resources.ApplyResources(this.label5, "label5");
			this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label5.Name = "label5";
			// 
			// label54
			// 
			resources.ApplyResources(this.label54, "label54");
			this.label54.ForeColor = System.Drawing.Color.White;
			this.label54.Name = "label54";
			// 
			// label53
			// 
			resources.ApplyResources(this.label53, "label53");
			this.label53.ForeColor = System.Drawing.Color.White;
			this.label53.Name = "label53";
			// 
			// label52
			// 
			resources.ApplyResources(this.label52, "label52");
			this.label52.ForeColor = System.Drawing.Color.White;
			this.label52.Name = "label52";
			// 
			// label51
			// 
			resources.ApplyResources(this.label51, "label51");
			this.label51.ForeColor = System.Drawing.Color.White;
			this.label51.Name = "label51";
			// 
			// label50
			// 
			resources.ApplyResources(this.label50, "label50");
			this.label50.ForeColor = System.Drawing.Color.White;
			this.label50.Name = "label50";
			// 
			// label49
			// 
			resources.ApplyResources(this.label49, "label49");
			this.label49.ForeColor = System.Drawing.Color.White;
			this.label49.Name = "label49";
			// 
			// label48
			// 
			resources.ApplyResources(this.label48, "label48");
			this.label48.ForeColor = System.Drawing.Color.White;
			this.label48.Name = "label48";
			// 
			// label47
			// 
			resources.ApplyResources(this.label47, "label47");
			this.label47.ForeColor = System.Drawing.Color.White;
			this.label47.Name = "label47";
			// 
			// label46
			// 
			resources.ApplyResources(this.label46, "label46");
			this.label46.ForeColor = System.Drawing.Color.White;
			this.label46.Name = "label46";
			// 
			// Kitap21
			// 
			resources.ApplyResources(this.Kitap21, "Kitap21");
			this.Kitap21.ForeColor = System.Drawing.Color.Transparent;
			this.Kitap21.Name = "Kitap21";
			this.Kitap21.UseVisualStyleBackColor = true;
			this.Kitap21.Click += new System.EventHandler(this.Kitap21_Click_1);
			// 
			// Kitap20
			// 
			this.Kitap20.ForeColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.Kitap20, "Kitap20");
			this.Kitap20.Name = "Kitap20";
			this.Kitap20.UseVisualStyleBackColor = true;
			this.Kitap20.Click += new System.EventHandler(this.Kitap20_Click_1);
			// 
			// Kitap19
			// 
			this.Kitap19.ForeColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.Kitap19, "Kitap19");
			this.Kitap19.Name = "Kitap19";
			this.Kitap19.UseVisualStyleBackColor = true;
			this.Kitap19.Click += new System.EventHandler(this.Kitap19_Click_1);
			// 
			// Kitap18
			// 
			this.Kitap18.ForeColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.Kitap18, "Kitap18");
			this.Kitap18.Name = "Kitap18";
			this.Kitap18.UseVisualStyleBackColor = true;
			this.Kitap18.Click += new System.EventHandler(this.Kitap18_Click_1);
			// 
			// Kitap17
			// 
			this.Kitap17.ForeColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.Kitap17, "Kitap17");
			this.Kitap17.Name = "Kitap17";
			this.Kitap17.UseVisualStyleBackColor = true;
			this.Kitap17.Click += new System.EventHandler(this.Kitap17_Click_1);
			// 
			// Kitap16
			// 
			this.Kitap16.ForeColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.Kitap16, "Kitap16");
			this.Kitap16.Name = "Kitap16";
			this.Kitap16.UseVisualStyleBackColor = true;
			this.Kitap16.Click += new System.EventHandler(this.Kitap16_Click_1);
			// 
			// Kitap15
			// 
			this.Kitap15.ForeColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.Kitap15, "Kitap15");
			this.Kitap15.Name = "Kitap15";
			this.Kitap15.UseVisualStyleBackColor = true;
			this.Kitap15.Click += new System.EventHandler(this.Kitap15_Click_1);
			// 
			// Kitap14
			// 
			this.Kitap14.ForeColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.Kitap14, "Kitap14");
			this.Kitap14.Name = "Kitap14";
			this.Kitap14.UseVisualStyleBackColor = true;
			this.Kitap14.Click += new System.EventHandler(this.Kitap14_Click_1);
			// 
			// Kitap29
			// 
			resources.ApplyResources(this.Kitap29, "Kitap29");
			this.Kitap29.ForeColor = System.Drawing.Color.Transparent;
			this.Kitap29.Name = "Kitap29";
			this.Kitap29.UseVisualStyleBackColor = true;
			this.Kitap29.Click += new System.EventHandler(this.Kitap29_Click_1);
			// 
			// Kitap28
			// 
			this.Kitap28.ForeColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.Kitap28, "Kitap28");
			this.Kitap28.Name = "Kitap28";
			this.Kitap28.UseVisualStyleBackColor = true;
			this.Kitap28.Click += new System.EventHandler(this.Kitap28_Click_1);
			// 
			// Kitap27
			// 
			this.Kitap27.ForeColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.Kitap27, "Kitap27");
			this.Kitap27.Name = "Kitap27";
			this.Kitap27.UseVisualStyleBackColor = true;
			this.Kitap27.Click += new System.EventHandler(this.Kitap27_Click_1);
			// 
			// Kitap26
			// 
			this.Kitap26.ForeColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.Kitap26, "Kitap26");
			this.Kitap26.Name = "Kitap26";
			this.Kitap26.UseVisualStyleBackColor = true;
			this.Kitap26.Click += new System.EventHandler(this.Kitap26_Click_1);
			// 
			// Kitap25
			// 
			this.Kitap25.ForeColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.Kitap25, "Kitap25");
			this.Kitap25.Name = "Kitap25";
			this.Kitap25.UseVisualStyleBackColor = true;
			this.Kitap25.Click += new System.EventHandler(this.Kitap25_Click_1);
			// 
			// Kitap24
			// 
			this.Kitap24.ForeColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.Kitap24, "Kitap24");
			this.Kitap24.Name = "Kitap24";
			this.Kitap24.UseVisualStyleBackColor = true;
			this.Kitap24.Click += new System.EventHandler(this.Kitap24_Click_1);
			// 
			// Kitap23
			// 
			this.Kitap23.ForeColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.Kitap23, "Kitap23");
			this.Kitap23.Name = "Kitap23";
			this.Kitap23.UseVisualStyleBackColor = true;
			this.Kitap23.Click += new System.EventHandler(this.Kitap23_Click_1);
			// 
			// Kitap22
			// 
			this.Kitap22.ForeColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.Kitap22, "Kitap22");
			this.Kitap22.Name = "Kitap22";
			this.Kitap22.UseVisualStyleBackColor = true;
			this.Kitap22.Click += new System.EventHandler(this.Kitap22_Click_1);
			// 
			// Kitap33
			// 
			this.Kitap33.ForeColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.Kitap33, "Kitap33");
			this.Kitap33.Name = "Kitap33";
			this.Kitap33.UseVisualStyleBackColor = true;
			this.Kitap33.Click += new System.EventHandler(this.Kitap33_Click_1);
			// 
			// Kitap32
			// 
			this.Kitap32.ForeColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.Kitap32, "Kitap32");
			this.Kitap32.Name = "Kitap32";
			this.Kitap32.UseVisualStyleBackColor = true;
			this.Kitap32.Click += new System.EventHandler(this.Kitap32_Click_1);
			// 
			// Kitap31
			// 
			this.Kitap31.ForeColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.Kitap31, "Kitap31");
			this.Kitap31.Name = "Kitap31";
			this.Kitap31.UseVisualStyleBackColor = true;
			this.Kitap31.Click += new System.EventHandler(this.Kitap31_Click_1);
			// 
			// Kitap30
			// 
			this.Kitap30.ForeColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.Kitap30, "Kitap30");
			this.Kitap30.Name = "Kitap30";
			this.Kitap30.UseVisualStyleBackColor = true;
			this.Kitap30.Click += new System.EventHandler(this.Kitap30_Click_1);
			// 
			// Kitap37
			// 
			this.Kitap37.ForeColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.Kitap37, "Kitap37");
			this.Kitap37.Name = "Kitap37";
			this.Kitap37.UseVisualStyleBackColor = true;
			this.Kitap37.Click += new System.EventHandler(this.Kitap37_Click_1);
			// 
			// Kitap36
			// 
			this.Kitap36.ForeColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.Kitap36, "Kitap36");
			this.Kitap36.Name = "Kitap36";
			this.Kitap36.UseVisualStyleBackColor = true;
			this.Kitap36.Click += new System.EventHandler(this.Kitap36_Click_1);
			// 
			// Kitap35
			// 
			this.Kitap35.ForeColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.Kitap35, "Kitap35");
			this.Kitap35.Name = "Kitap35";
			this.Kitap35.UseVisualStyleBackColor = true;
			this.Kitap35.Click += new System.EventHandler(this.Kitap35_Click_1);
			// 
			// Kitap34
			// 
			this.Kitap34.ForeColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.Kitap34, "Kitap34");
			this.Kitap34.Name = "Kitap34";
			this.Kitap34.UseVisualStyleBackColor = true;
			this.Kitap34.Click += new System.EventHandler(this.Kitap34_Click_1);
			// 
			// Kitap38
			// 
			this.Kitap38.ForeColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.Kitap38, "Kitap38");
			this.Kitap38.Name = "Kitap38";
			this.Kitap38.UseVisualStyleBackColor = true;
			this.Kitap38.Click += new System.EventHandler(this.Kitap38_Click_1);
			// 
			// Kitap42
			// 
			this.Kitap42.ForeColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.Kitap42, "Kitap42");
			this.Kitap42.Name = "Kitap42";
			this.Kitap42.UseVisualStyleBackColor = true;
			this.Kitap42.Click += new System.EventHandler(this.Kitap42_Click_1);
			// 
			// Kitap41
			// 
			this.Kitap41.ForeColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.Kitap41, "Kitap41");
			this.Kitap41.Name = "Kitap41";
			this.Kitap41.UseVisualStyleBackColor = true;
			this.Kitap41.Click += new System.EventHandler(this.Kitap41_Click_1);
			// 
			// Kitap40
			// 
			this.Kitap40.ForeColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.Kitap40, "Kitap40");
			this.Kitap40.Name = "Kitap40";
			this.Kitap40.UseVisualStyleBackColor = true;
			this.Kitap40.Click += new System.EventHandler(this.Kitap40_Click_1);
			// 
			// Kitap39
			// 
			this.Kitap39.ForeColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.Kitap39, "Kitap39");
			this.Kitap39.Name = "Kitap39";
			this.Kitap39.UseVisualStyleBackColor = true;
			this.Kitap39.Click += new System.EventHandler(this.Kitap39_Click_1);
			// 
			// Kitapismi21
			// 
			resources.ApplyResources(this.Kitapismi21, "Kitapismi21");
			this.Kitapismi21.ForeColor = System.Drawing.Color.White;
			this.Kitapismi21.Name = "Kitapismi21";
			// 
			// Kitapismi20
			// 
			resources.ApplyResources(this.Kitapismi20, "Kitapismi20");
			this.Kitapismi20.ForeColor = System.Drawing.Color.White;
			this.Kitapismi20.Name = "Kitapismi20";
			// 
			// Kitapismi19
			// 
			resources.ApplyResources(this.Kitapismi19, "Kitapismi19");
			this.Kitapismi19.ForeColor = System.Drawing.Color.White;
			this.Kitapismi19.Name = "Kitapismi19";
			// 
			// Kitapismi18
			// 
			resources.ApplyResources(this.Kitapismi18, "Kitapismi18");
			this.Kitapismi18.ForeColor = System.Drawing.Color.White;
			this.Kitapismi18.Name = "Kitapismi18";
			// 
			// Kitapismi17
			// 
			resources.ApplyResources(this.Kitapismi17, "Kitapismi17");
			this.Kitapismi17.ForeColor = System.Drawing.Color.White;
			this.Kitapismi17.Name = "Kitapismi17";
			// 
			// Kitapismi16
			// 
			resources.ApplyResources(this.Kitapismi16, "Kitapismi16");
			this.Kitapismi16.ForeColor = System.Drawing.Color.White;
			this.Kitapismi16.Name = "Kitapismi16";
			// 
			// Kitapismi15
			// 
			resources.ApplyResources(this.Kitapismi15, "Kitapismi15");
			this.Kitapismi15.ForeColor = System.Drawing.Color.White;
			this.Kitapismi15.Name = "Kitapismi15";
			// 
			// Kitapismi14
			// 
			resources.ApplyResources(this.Kitapismi14, "Kitapismi14");
			this.Kitapismi14.ForeColor = System.Drawing.Color.White;
			this.Kitapismi14.Name = "Kitapismi14";
			// 
			// Kitapismi29
			// 
			resources.ApplyResources(this.Kitapismi29, "Kitapismi29");
			this.Kitapismi29.ForeColor = System.Drawing.Color.White;
			this.Kitapismi29.Name = "Kitapismi29";
			// 
			// Kitapismi28
			// 
			resources.ApplyResources(this.Kitapismi28, "Kitapismi28");
			this.Kitapismi28.ForeColor = System.Drawing.Color.White;
			this.Kitapismi28.Name = "Kitapismi28";
			// 
			// Kitapismi27
			// 
			resources.ApplyResources(this.Kitapismi27, "Kitapismi27");
			this.Kitapismi27.ForeColor = System.Drawing.Color.White;
			this.Kitapismi27.Name = "Kitapismi27";
			// 
			// Kitapismi26
			// 
			resources.ApplyResources(this.Kitapismi26, "Kitapismi26");
			this.Kitapismi26.ForeColor = System.Drawing.Color.White;
			this.Kitapismi26.Name = "Kitapismi26";
			// 
			// Kitapismi25
			// 
			resources.ApplyResources(this.Kitapismi25, "Kitapismi25");
			this.Kitapismi25.ForeColor = System.Drawing.Color.White;
			this.Kitapismi25.Name = "Kitapismi25";
			// 
			// Kitapismi24
			// 
			resources.ApplyResources(this.Kitapismi24, "Kitapismi24");
			this.Kitapismi24.ForeColor = System.Drawing.Color.White;
			this.Kitapismi24.Name = "Kitapismi24";
			// 
			// Kitapismi23
			// 
			resources.ApplyResources(this.Kitapismi23, "Kitapismi23");
			this.Kitapismi23.ForeColor = System.Drawing.Color.White;
			this.Kitapismi23.Name = "Kitapismi23";
			// 
			// Kitapismi22
			// 
			resources.ApplyResources(this.Kitapismi22, "Kitapismi22");
			this.Kitapismi22.ForeColor = System.Drawing.Color.White;
			this.Kitapismi22.Name = "Kitapismi22";
			// 
			// Kitapismi33
			// 
			resources.ApplyResources(this.Kitapismi33, "Kitapismi33");
			this.Kitapismi33.ForeColor = System.Drawing.Color.White;
			this.Kitapismi33.Name = "Kitapismi33";
			// 
			// Kitapismi32
			// 
			resources.ApplyResources(this.Kitapismi32, "Kitapismi32");
			this.Kitapismi32.ForeColor = System.Drawing.Color.White;
			this.Kitapismi32.Name = "Kitapismi32";
			// 
			// Kitapismi31
			// 
			resources.ApplyResources(this.Kitapismi31, "Kitapismi31");
			this.Kitapismi31.ForeColor = System.Drawing.Color.White;
			this.Kitapismi31.Name = "Kitapismi31";
			// 
			// Kitapismi30
			// 
			resources.ApplyResources(this.Kitapismi30, "Kitapismi30");
			this.Kitapismi30.ForeColor = System.Drawing.Color.White;
			this.Kitapismi30.Name = "Kitapismi30";
			// 
			// Kitapismi37
			// 
			resources.ApplyResources(this.Kitapismi37, "Kitapismi37");
			this.Kitapismi37.ForeColor = System.Drawing.Color.White;
			this.Kitapismi37.Name = "Kitapismi37";
			// 
			// Kitapismi36
			// 
			resources.ApplyResources(this.Kitapismi36, "Kitapismi36");
			this.Kitapismi36.ForeColor = System.Drawing.Color.White;
			this.Kitapismi36.Name = "Kitapismi36";
			// 
			// Kitapismi35
			// 
			resources.ApplyResources(this.Kitapismi35, "Kitapismi35");
			this.Kitapismi35.ForeColor = System.Drawing.Color.White;
			this.Kitapismi35.Name = "Kitapismi35";
			// 
			// Kitapismi34
			// 
			resources.ApplyResources(this.Kitapismi34, "Kitapismi34");
			this.Kitapismi34.ForeColor = System.Drawing.Color.White;
			this.Kitapismi34.Name = "Kitapismi34";
			// 
			// Kitapismi38
			// 
			resources.ApplyResources(this.Kitapismi38, "Kitapismi38");
			this.Kitapismi38.ForeColor = System.Drawing.Color.White;
			this.Kitapismi38.Name = "Kitapismi38";
			// 
			// Kitapismi39
			// 
			resources.ApplyResources(this.Kitapismi39, "Kitapismi39");
			this.Kitapismi39.ForeColor = System.Drawing.Color.White;
			this.Kitapismi39.Name = "Kitapismi39";
			// 
			// Kitapismi40
			// 
			resources.ApplyResources(this.Kitapismi40, "Kitapismi40");
			this.Kitapismi40.ForeColor = System.Drawing.Color.White;
			this.Kitapismi40.Name = "Kitapismi40";
			// 
			// Kitapismi41
			// 
			resources.ApplyResources(this.Kitapismi41, "Kitapismi41");
			this.Kitapismi41.ForeColor = System.Drawing.Color.White;
			this.Kitapismi41.Name = "Kitapismi41";
			// 
			// Kitapismi42
			// 
			resources.ApplyResources(this.Kitapismi42, "Kitapismi42");
			this.Kitapismi42.ForeColor = System.Drawing.Color.White;
			this.Kitapismi42.Name = "Kitapismi42";
			// 
			// Kitap14Fiyat
			// 
			resources.ApplyResources(this.Kitap14Fiyat, "Kitap14Fiyat");
			this.Kitap14Fiyat.ForeColor = System.Drawing.Color.White;
			this.Kitap14Fiyat.Name = "Kitap14Fiyat";
			// 
			// Kitap15Fiyat
			// 
			resources.ApplyResources(this.Kitap15Fiyat, "Kitap15Fiyat");
			this.Kitap15Fiyat.ForeColor = System.Drawing.Color.White;
			this.Kitap15Fiyat.Name = "Kitap15Fiyat";
			// 
			// Kitap16Fiyat
			// 
			resources.ApplyResources(this.Kitap16Fiyat, "Kitap16Fiyat");
			this.Kitap16Fiyat.ForeColor = System.Drawing.Color.White;
			this.Kitap16Fiyat.Name = "Kitap16Fiyat";
			// 
			// Kitap17Fiyat
			// 
			resources.ApplyResources(this.Kitap17Fiyat, "Kitap17Fiyat");
			this.Kitap17Fiyat.ForeColor = System.Drawing.Color.White;
			this.Kitap17Fiyat.Name = "Kitap17Fiyat";
			// 
			// Kitap18Fiyat
			// 
			resources.ApplyResources(this.Kitap18Fiyat, "Kitap18Fiyat");
			this.Kitap18Fiyat.ForeColor = System.Drawing.Color.White;
			this.Kitap18Fiyat.Name = "Kitap18Fiyat";
			// 
			// Kitap19Fiyat
			// 
			resources.ApplyResources(this.Kitap19Fiyat, "Kitap19Fiyat");
			this.Kitap19Fiyat.ForeColor = System.Drawing.Color.White;
			this.Kitap19Fiyat.Name = "Kitap19Fiyat";
			// 
			// Kitap20Fiyat
			// 
			resources.ApplyResources(this.Kitap20Fiyat, "Kitap20Fiyat");
			this.Kitap20Fiyat.ForeColor = System.Drawing.Color.White;
			this.Kitap20Fiyat.Name = "Kitap20Fiyat";
			// 
			// Kitap21Fiyat
			// 
			resources.ApplyResources(this.Kitap21Fiyat, "Kitap21Fiyat");
			this.Kitap21Fiyat.ForeColor = System.Drawing.Color.White;
			this.Kitap21Fiyat.Name = "Kitap21Fiyat";
			// 
			// Kitap22Fiyat
			// 
			resources.ApplyResources(this.Kitap22Fiyat, "Kitap22Fiyat");
			this.Kitap22Fiyat.ForeColor = System.Drawing.Color.White;
			this.Kitap22Fiyat.Name = "Kitap22Fiyat";
			// 
			// Kitap23Fiyat
			// 
			resources.ApplyResources(this.Kitap23Fiyat, "Kitap23Fiyat");
			this.Kitap23Fiyat.ForeColor = System.Drawing.Color.White;
			this.Kitap23Fiyat.Name = "Kitap23Fiyat";
			// 
			// Kitap24Fiyat
			// 
			resources.ApplyResources(this.Kitap24Fiyat, "Kitap24Fiyat");
			this.Kitap24Fiyat.ForeColor = System.Drawing.Color.White;
			this.Kitap24Fiyat.Name = "Kitap24Fiyat";
			// 
			// Kitap25Fiyat
			// 
			resources.ApplyResources(this.Kitap25Fiyat, "Kitap25Fiyat");
			this.Kitap25Fiyat.ForeColor = System.Drawing.Color.White;
			this.Kitap25Fiyat.Name = "Kitap25Fiyat";
			// 
			// Kitap26Fiyat
			// 
			resources.ApplyResources(this.Kitap26Fiyat, "Kitap26Fiyat");
			this.Kitap26Fiyat.ForeColor = System.Drawing.Color.White;
			this.Kitap26Fiyat.Name = "Kitap26Fiyat";
			// 
			// Kitap27Fiyat
			// 
			resources.ApplyResources(this.Kitap27Fiyat, "Kitap27Fiyat");
			this.Kitap27Fiyat.ForeColor = System.Drawing.Color.White;
			this.Kitap27Fiyat.Name = "Kitap27Fiyat";
			// 
			// Kitap28Fiyat
			// 
			resources.ApplyResources(this.Kitap28Fiyat, "Kitap28Fiyat");
			this.Kitap28Fiyat.ForeColor = System.Drawing.Color.White;
			this.Kitap28Fiyat.Name = "Kitap28Fiyat";
			// 
			// Kitap29Fiyat
			// 
			resources.ApplyResources(this.Kitap29Fiyat, "Kitap29Fiyat");
			this.Kitap29Fiyat.ForeColor = System.Drawing.Color.White;
			this.Kitap29Fiyat.Name = "Kitap29Fiyat";
			// 
			// Kitap30Fiyat
			// 
			resources.ApplyResources(this.Kitap30Fiyat, "Kitap30Fiyat");
			this.Kitap30Fiyat.ForeColor = System.Drawing.Color.White;
			this.Kitap30Fiyat.Name = "Kitap30Fiyat";
			// 
			// Kitap31Fiyat
			// 
			resources.ApplyResources(this.Kitap31Fiyat, "Kitap31Fiyat");
			this.Kitap31Fiyat.ForeColor = System.Drawing.Color.White;
			this.Kitap31Fiyat.Name = "Kitap31Fiyat";
			// 
			// Kitap32Fiyat
			// 
			resources.ApplyResources(this.Kitap32Fiyat, "Kitap32Fiyat");
			this.Kitap32Fiyat.ForeColor = System.Drawing.Color.White;
			this.Kitap32Fiyat.Name = "Kitap32Fiyat";
			// 
			// Kitap33Fiyat
			// 
			resources.ApplyResources(this.Kitap33Fiyat, "Kitap33Fiyat");
			this.Kitap33Fiyat.ForeColor = System.Drawing.Color.White;
			this.Kitap33Fiyat.Name = "Kitap33Fiyat";
			// 
			// Kitap34Fiyat
			// 
			resources.ApplyResources(this.Kitap34Fiyat, "Kitap34Fiyat");
			this.Kitap34Fiyat.ForeColor = System.Drawing.Color.White;
			this.Kitap34Fiyat.Name = "Kitap34Fiyat";
			// 
			// Kitap35Fiyat
			// 
			resources.ApplyResources(this.Kitap35Fiyat, "Kitap35Fiyat");
			this.Kitap35Fiyat.ForeColor = System.Drawing.Color.White;
			this.Kitap35Fiyat.Name = "Kitap35Fiyat";
			// 
			// Kitap36Fiyat
			// 
			resources.ApplyResources(this.Kitap36Fiyat, "Kitap36Fiyat");
			this.Kitap36Fiyat.ForeColor = System.Drawing.Color.White;
			this.Kitap36Fiyat.Name = "Kitap36Fiyat";
			// 
			// Kitap37Fiyat
			// 
			resources.ApplyResources(this.Kitap37Fiyat, "Kitap37Fiyat");
			this.Kitap37Fiyat.ForeColor = System.Drawing.Color.White;
			this.Kitap37Fiyat.Name = "Kitap37Fiyat";
			// 
			// Kitap38Fiyat
			// 
			resources.ApplyResources(this.Kitap38Fiyat, "Kitap38Fiyat");
			this.Kitap38Fiyat.ForeColor = System.Drawing.Color.White;
			this.Kitap38Fiyat.Name = "Kitap38Fiyat";
			// 
			// Kitap39Fiyat
			// 
			resources.ApplyResources(this.Kitap39Fiyat, "Kitap39Fiyat");
			this.Kitap39Fiyat.ForeColor = System.Drawing.Color.White;
			this.Kitap39Fiyat.Name = "Kitap39Fiyat";
			// 
			// Kitap40Fiyat
			// 
			resources.ApplyResources(this.Kitap40Fiyat, "Kitap40Fiyat");
			this.Kitap40Fiyat.ForeColor = System.Drawing.Color.White;
			this.Kitap40Fiyat.Name = "Kitap40Fiyat";
			// 
			// Kitap41Fiyat
			// 
			resources.ApplyResources(this.Kitap41Fiyat, "Kitap41Fiyat");
			this.Kitap41Fiyat.ForeColor = System.Drawing.Color.White;
			this.Kitap41Fiyat.Name = "Kitap41Fiyat";
			// 
			// Kitap42Fiyat
			// 
			resources.ApplyResources(this.Kitap42Fiyat, "Kitap42Fiyat");
			this.Kitap42Fiyat.ForeColor = System.Drawing.Color.White;
			this.Kitap42Fiyat.Name = "Kitap42Fiyat";
			// 
			// label58
			// 
			resources.ApplyResources(this.label58, "label58");
			this.label58.ForeColor = System.Drawing.Color.White;
			this.label58.Name = "label58";
			// 
			// label59
			// 
			resources.ApplyResources(this.label59, "label59");
			this.label59.ForeColor = System.Drawing.Color.White;
			this.label59.Name = "label59";
			// 
			// label60
			// 
			resources.ApplyResources(this.label60, "label60");
			this.label60.ForeColor = System.Drawing.Color.White;
			this.label60.Name = "label60";
			// 
			// label61
			// 
			resources.ApplyResources(this.label61, "label61");
			this.label61.ForeColor = System.Drawing.Color.White;
			this.label61.Name = "label61";
			// 
			// label62
			// 
			resources.ApplyResources(this.label62, "label62");
			this.label62.ForeColor = System.Drawing.Color.White;
			this.label62.Name = "label62";
			// 
			// label63
			// 
			resources.ApplyResources(this.label63, "label63");
			this.label63.ForeColor = System.Drawing.Color.White;
			this.label63.Name = "label63";
			// 
			// label64
			// 
			resources.ApplyResources(this.label64, "label64");
			this.label64.ForeColor = System.Drawing.Color.White;
			this.label64.Name = "label64";
			// 
			// label65
			// 
			resources.ApplyResources(this.label65, "label65");
			this.label65.ForeColor = System.Drawing.Color.White;
			this.label65.Name = "label65";
			// 
			// label66
			// 
			resources.ApplyResources(this.label66, "label66");
			this.label66.ForeColor = System.Drawing.Color.White;
			this.label66.Name = "label66";
			// 
			// label67
			// 
			resources.ApplyResources(this.label67, "label67");
			this.label67.ForeColor = System.Drawing.Color.White;
			this.label67.Name = "label67";
			// 
			// label68
			// 
			resources.ApplyResources(this.label68, "label68");
			this.label68.ForeColor = System.Drawing.Color.White;
			this.label68.Name = "label68";
			// 
			// label69
			// 
			resources.ApplyResources(this.label69, "label69");
			this.label69.ForeColor = System.Drawing.Color.White;
			this.label69.Name = "label69";
			// 
			// label70
			// 
			resources.ApplyResources(this.label70, "label70");
			this.label70.ForeColor = System.Drawing.Color.White;
			this.label70.Name = "label70";
			// 
			// label71
			// 
			resources.ApplyResources(this.label71, "label71");
			this.label71.ForeColor = System.Drawing.Color.White;
			this.label71.Name = "label71";
			// 
			// label72
			// 
			resources.ApplyResources(this.label72, "label72");
			this.label72.ForeColor = System.Drawing.Color.White;
			this.label72.Name = "label72";
			// 
			// label73
			// 
			resources.ApplyResources(this.label73, "label73");
			this.label73.ForeColor = System.Drawing.Color.White;
			this.label73.Name = "label73";
			// 
			// label74
			// 
			resources.ApplyResources(this.label74, "label74");
			this.label74.ForeColor = System.Drawing.Color.White;
			this.label74.Name = "label74";
			// 
			// label75
			// 
			resources.ApplyResources(this.label75, "label75");
			this.label75.ForeColor = System.Drawing.Color.White;
			this.label75.Name = "label75";
			// 
			// label76
			// 
			resources.ApplyResources(this.label76, "label76");
			this.label76.ForeColor = System.Drawing.Color.White;
			this.label76.Name = "label76";
			// 
			// label77
			// 
			resources.ApplyResources(this.label77, "label77");
			this.label77.ForeColor = System.Drawing.Color.White;
			this.label77.Name = "label77";
			// 
			// label78
			// 
			resources.ApplyResources(this.label78, "label78");
			this.label78.ForeColor = System.Drawing.Color.White;
			this.label78.Name = "label78";
			// 
			// label79
			// 
			resources.ApplyResources(this.label79, "label79");
			this.label79.ForeColor = System.Drawing.Color.White;
			this.label79.Name = "label79";
			// 
			// label80
			// 
			resources.ApplyResources(this.label80, "label80");
			this.label80.ForeColor = System.Drawing.Color.White;
			this.label80.Name = "label80";
			// 
			// label81
			// 
			resources.ApplyResources(this.label81, "label81");
			this.label81.ForeColor = System.Drawing.Color.White;
			this.label81.Name = "label81";
			// 
			// label82
			// 
			resources.ApplyResources(this.label82, "label82");
			this.label82.ForeColor = System.Drawing.Color.White;
			this.label82.Name = "label82";
			// 
			// label83
			// 
			resources.ApplyResources(this.label83, "label83");
			this.label83.ForeColor = System.Drawing.Color.White;
			this.label83.Name = "label83";
			// 
			// label84
			// 
			resources.ApplyResources(this.label84, "label84");
			this.label84.ForeColor = System.Drawing.Color.White;
			this.label84.Name = "label84";
			// 
			// label85
			// 
			resources.ApplyResources(this.label85, "label85");
			this.label85.ForeColor = System.Drawing.Color.White;
			this.label85.Name = "label85";
			// 
			// label86
			// 
			resources.ApplyResources(this.label86, "label86");
			this.label86.ForeColor = System.Drawing.Color.White;
			this.label86.Name = "label86";
			// 
			// panel12
			// 
			this.panel12.BackColor = System.Drawing.Color.Gold;
			this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel12.Controls.Add(this.label87);
			resources.ApplyResources(this.panel12, "panel12");
			this.panel12.Name = "panel12";
			// 
			// label87
			// 
			resources.ApplyResources(this.label87, "label87");
			this.label87.Name = "label87";
			// 
			// panel15
			// 
			this.panel15.BackColor = System.Drawing.Color.Gold;
			this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel15.Controls.Add(this.label88);
			resources.ApplyResources(this.panel15, "panel15");
			this.panel15.Name = "panel15";
			// 
			// label88
			// 
			resources.ApplyResources(this.label88, "label88");
			this.label88.Name = "label88";
			// 
			// panel16
			// 
			this.panel16.BackColor = System.Drawing.Color.Gold;
			this.panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel16.Controls.Add(this.label89);
			resources.ApplyResources(this.panel16, "panel16");
			this.panel16.Name = "panel16";
			// 
			// label89
			// 
			resources.ApplyResources(this.label89, "label89");
			this.label89.Name = "label89";
			// 
			// panel17
			// 
			this.panel17.BackColor = System.Drawing.Color.Gold;
			this.panel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel17.Controls.Add(this.label90);
			resources.ApplyResources(this.panel17, "panel17");
			this.panel17.Name = "panel17";
			// 
			// label90
			// 
			resources.ApplyResources(this.label90, "label90");
			this.label90.Name = "label90";
			// 
			// panel18
			// 
			this.panel18.BackColor = System.Drawing.Color.Gold;
			this.panel18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel18.Controls.Add(this.label91);
			resources.ApplyResources(this.panel18, "panel18");
			this.panel18.Name = "panel18";
			// 
			// label91
			// 
			resources.ApplyResources(this.label91, "label91");
			this.label91.Name = "label91";
			// 
			// label92
			// 
			resources.ApplyResources(this.label92, "label92");
			this.label92.ForeColor = System.Drawing.Color.Gold;
			this.label92.Name = "label92";
			// 
			// label93
			// 
			resources.ApplyResources(this.label93, "label93");
			this.label93.ForeColor = System.Drawing.Color.White;
			this.label93.Name = "label93";
			// 
			// label94
			// 
			resources.ApplyResources(this.label94, "label94");
			this.label94.ForeColor = System.Drawing.Color.White;
			this.label94.Name = "label94";
			// 
			// panel19
			// 
			this.panel19.Controls.Add(this.label94);
			this.panel19.Controls.Add(this.label92);
			this.panel19.Controls.Add(this.label93);
			resources.ApplyResources(this.panel19, "panel19");
			this.panel19.Name = "panel19";
			// 
			// panel20
			// 
			this.panel20.Controls.Add(this.label95);
			this.panel20.Controls.Add(this.label96);
			this.panel20.Controls.Add(this.label97);
			resources.ApplyResources(this.panel20, "panel20");
			this.panel20.Name = "panel20";
			// 
			// label95
			// 
			resources.ApplyResources(this.label95, "label95");
			this.label95.ForeColor = System.Drawing.Color.White;
			this.label95.Name = "label95";
			// 
			// label96
			// 
			resources.ApplyResources(this.label96, "label96");
			this.label96.ForeColor = System.Drawing.Color.Gold;
			this.label96.Name = "label96";
			// 
			// label97
			// 
			resources.ApplyResources(this.label97, "label97");
			this.label97.ForeColor = System.Drawing.Color.White;
			this.label97.Name = "label97";
			// 
			// Form1
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.Controls.Add(this.KayitPanel);
			this.Controls.Add(this.KapsayiciLogin);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel10.ResumeLayout(false);
			this.panel10.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.KitapKiralaPencere.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabControl2.ResumeLayout(false);
			this.tabPage8.ResumeLayout(false);
			this.tabPage8.PerformLayout();
			this.Hesabim.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage13.ResumeLayout(false);
			this.tabPage13.PerformLayout();
			this.KapsayiciLogin.ResumeLayout(false);
			this.panel14.ResumeLayout(false);
			this.panel14.PerformLayout();
			this.KayitPanel.ResumeLayout(false);
			this.panel13.ResumeLayout(false);
			this.panel13.PerformLayout();
			this.tabPage14.ResumeLayout(false);
			this.tabPage14.PerformLayout();
			this.panel11.ResumeLayout(false);
			this.panel11.PerformLayout();
			this.tabPage9.ResumeLayout(false);
			this.tabPage9.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			this.tabPage6.ResumeLayout(false);
			this.tabPage6.PerformLayout();
			this.tabPage7.ResumeLayout(false);
			this.tabPage7.PerformLayout();
			this.SepetimPanel.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel7.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.panel8.ResumeLayout(false);
			this.panel8.PerformLayout();
			this.panel12.ResumeLayout(false);
			this.panel12.PerformLayout();
			this.panel15.ResumeLayout(false);
			this.panel15.PerformLayout();
			this.panel16.ResumeLayout(false);
			this.panel16.PerformLayout();
			this.panel17.ResumeLayout(false);
			this.panel17.PerformLayout();
			this.panel18.ResumeLayout(false);
			this.panel18.PerformLayout();
			this.panel19.ResumeLayout(false);
			this.panel19.PerformLayout();
			this.panel20.ResumeLayout(false);
			this.panel20.PerformLayout();
			this.ResumeLayout(false);

		}
		

		#endregion
		private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button KitapKiralama;
        private System.Windows.Forms.Button Anasayfa;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TabControl KitapKiralaPencere;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.Button Sepetim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel SepetimPanel;
        private System.Windows.Forms.ListBox SepetFiyat;
        private System.Windows.Forms.ListBox Sepetİsim;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button Kitap8;
        private System.Windows.Forms.Button Kitap7;
        private System.Windows.Forms.Button Kitap6;
        private System.Windows.Forms.Button Kitap5;
        private System.Windows.Forms.Button Kitap4;
        private System.Windows.Forms.Button Kitap3;
        private System.Windows.Forms.Button Kitap2;
        private System.Windows.Forms.Button Kitap1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ListBox SepetListesi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label Kitap8Fiyat;
        private System.Windows.Forms.Label Kitap7Fiyat;
        private System.Windows.Forms.Label Kitap6Fiyat;
        private System.Windows.Forms.Label Kitap5Fiyat;
        private System.Windows.Forms.Label Kitap4Fiyat;
        private System.Windows.Forms.Label Kitap3Fiyat;
        private System.Windows.Forms.Label Kitap2Fiyat;
        private System.Windows.Forms.Label Kitap1Fiyat;
        private System.Windows.Forms.Button SepeteEkleButonu;
        private System.Windows.Forms.ListBox SepetListesiFiyat;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.Button SepetiTemizle;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label ToplamFiyat;
        private System.Windows.Forms.Label Vergi;
        private System.Windows.Forms.Label NormalFiyat;
        private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label Kitapismi1;
		private System.Windows.Forms.Label Kitapismi4;
		private System.Windows.Forms.Label Kitapismi3;
		private System.Windows.Forms.Label Kitapismi2;
		private System.Windows.Forms.Label Kitapismi5;
		private System.Windows.Forms.Label Kitapismi8;
		private System.Windows.Forms.Label Kitapismi7;
		private System.Windows.Forms.Label Kitapismi6;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Button Kitap9;
		private System.Windows.Forms.Button Kitap12;
		private System.Windows.Forms.Button Kitap11;
		private System.Windows.Forms.Button Kitap10;
		private System.Windows.Forms.Button Kitap13;
		private System.Windows.Forms.Label Kitap12Fiyat;
		private System.Windows.Forms.Label Kitap11Fiyat;
		private System.Windows.Forms.Label Kitap10Fiyat;
		private System.Windows.Forms.Label Kitap9Fiyat;
		private System.Windows.Forms.Label Kitap13Fiyat;
		private System.Windows.Forms.Label Kitapismi13;
		private System.Windows.Forms.Label Kitapismi12;
		private System.Windows.Forms.Label Kitapismi11;
		private System.Windows.Forms.Label Kitapismi10;
		private System.Windows.Forms.Label Kitapismi9;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Panel Hesabim;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage13;
		private System.Windows.Forms.TabPage tabPage14;
		private System.Windows.Forms.ListBox HesabimListbox;
		private System.Windows.Forms.Panel panel11;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.ListBox kiralamaZamani;
		private System.Windows.Forms.ListBox Kalangun;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label37;
		private Label label38;
		private Panel KapsayiciLogin;
		private Panel KayitPanel;
		private Panel panel13;
		private Label label39;
		private Label label40;
		private Button GirisYapKO;
		private Button KayitOlOnay;
		private TextBox textBox5;
		private TextBox textBox6;
		private TextBox textBox7;
		private TextBox textBox8;
		private Label sifreKayitOl;
		private Label EmailKayitOl;
		private Label KullaniciAdiKayitOl;
		private Label İsimKayitOl;
		private Panel panel14;
		private Button kayitOl;
		private Label label41;
		private LinkLabel linkLabel1;
		private Label label42;
		private Label label43;
		private Label label44;
		private Button GirisButon;
		private TextBox sifreTextBox;
		private TextBox kullaniciAdiTextBox;
		private Button VeriGuncelle;
		private Label label45;
		private Label label47;
		private Label label46;
		private Label label49;
		private Label label48;
		private Label label52;
		private Label label51;
		private Label label50;
		private Label label54;
		private Label label53;
		private Label label55;
		private Label label56;
		private Label label57;
		private LinkLabel linkLabel2;
		private Button Kitap21;
		private Button Kitap20;
		private Button Kitap19;
		private Button Kitap18;
		private Button Kitap17;
		private Button Kitap16;
		private Button Kitap15;
		private Button Kitap14;
		private Button Kitap29;
		private Button Kitap28;
		private Button Kitap27;
		private Button Kitap26;
		private Button Kitap25;
		private Button Kitap24;
		private Button Kitap23;
		private Button Kitap22;
		private Button Kitap33;
		private Button Kitap32;
		private Button Kitap31;
		private Button Kitap30;
		private Button Kitap38;
		private Button Kitap37;
		private Button Kitap36;
		private Button Kitap35;
		private Button Kitap34;
		private Button Kitap42;
		private Button Kitap41;
		private Button Kitap40;
		private Button Kitap39;
		private Label Kitapismi21;
		private Label Kitapismi20;
		private Label Kitapismi19;
		private Label Kitapismi18;
		private Label Kitapismi17;
		private Label Kitapismi16;
		private Label Kitapismi15;
		private Label Kitapismi14;
		private Label Kitapismi29;
		private Label Kitapismi28;
		private Label Kitapismi27;
		private Label Kitapismi26;
		private Label Kitapismi25;
		private Label Kitapismi24;
		private Label Kitapismi23;
		private Label Kitapismi22;
		private Label Kitapismi33;
		private Label Kitapismi32;
		private Label Kitapismi31;
		private Label Kitapismi30;
		private Label Kitapismi38;
		private Label Kitapismi37;
		private Label Kitapismi36;
		private Label Kitapismi35;
		private Label Kitapismi34;
		private Label Kitapismi42;
		private Label Kitapismi41;
		private Label Kitapismi40;
		private Label Kitapismi39;
		private Label Kitap14Fiyat;
		private Label Kitap21Fiyat;
		private Label Kitap20Fiyat;
		private Label Kitap19Fiyat;
		private Label Kitap18Fiyat;
		private Label Kitap17Fiyat;
		private Label Kitap16Fiyat;
		private Label Kitap15Fiyat;
		private Label Kitap29Fiyat;
		private Label Kitap28Fiyat;
		private Label Kitap27Fiyat;
		private Label Kitap26Fiyat;
		private Label Kitap25Fiyat;
		private Label Kitap24Fiyat;
		private Label Kitap23Fiyat;
		private Label Kitap22Fiyat;
		private Label Kitap33Fiyat;
		private Label Kitap32Fiyat;
		private Label Kitap31Fiyat;
		private Label Kitap30Fiyat;
		private Label Kitap38Fiyat;
		private Label Kitap37Fiyat;
		private Label Kitap36Fiyat;
		private Label Kitap35Fiyat;
		private Label Kitap34Fiyat;
		private Label Kitap42Fiyat;
		private Label Kitap41Fiyat;
		private Label Kitap40Fiyat;
		private Label Kitap39Fiyat;
		private Label label65;
		private Label label64;
		private Label label63;
		private Label label62;
		private Label label61;
		private Label label60;
		private Label label59;
		private Label label58;
		private Label label73;
		private Label label72;
		private Label label71;
		private Label label70;
		private Label label69;
		private Label label68;
		private Label label67;
		private Label label66;
		private Label label77;
		private Label label76;
		private Label label75;
		private Label label74;
		private Label label82;
		private Label label81;
		private Label label80;
		private Label label79;
		private Label label78;
		private Label label86;
		private Label label85;
		private Label label84;
		private Label label83;
		private Panel panel12;
		private Label label87;
		private Panel panel15;
		private Label label88;
		private Panel panel16;
		private Label label89;
		private Panel panel17;
		private Label label90;
		private Panel panel18;
		private Label label91;
		private Panel panel19;
		private Label label94;
		private Label label92;
		private Label label93;
		private Panel panel20;
		private Label label95;
		private Label label96;
		private Label label97;
	}
}

