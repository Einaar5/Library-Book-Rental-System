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
			this.Hesabim = new System.Windows.Forms.Panel();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage13 = new System.Windows.Forms.TabPage();
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
			this.KitapKiralaPencere = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabControl2 = new System.Windows.Forms.TabControl();
			this.tabPage8 = new System.Windows.Forms.TabPage();
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
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.tabPage6 = new System.Windows.Forms.TabPage();
			this.tabPage7 = new System.Windows.Forms.TabPage();
			this.tabPage10 = new System.Windows.Forms.TabPage();
			this.tabPage11 = new System.Windows.Forms.TabPage();
			this.tabPage12 = new System.Windows.Forms.TabPage();
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
			this.panel9 = new System.Windows.Forms.Panel();
			this.SepetFiyat = new System.Windows.Forms.ListBox();
			this.Sepetİsim = new System.Windows.Forms.ListBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.KapsayiciLogin = new System.Windows.Forms.Panel();
			this.KayitPanel = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel13 = new System.Windows.Forms.Panel();
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
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel14 = new System.Windows.Forms.Panel();
			this.kayitOl = new System.Windows.Forms.Button();
			this.label41 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.label42 = new System.Windows.Forms.Label();
			this.label43 = new System.Windows.Forms.Label();
			this.label44 = new System.Windows.Forms.Label();
			this.GirisButon = new System.Windows.Forms.Button();
			this.sifreTextBox = new System.Windows.Forms.TextBox();
			this.kullaniciAdiTextBox = new System.Windows.Forms.TextBox();
			this.VeriGuncelle = new System.Windows.Forms.Button();
			this.label45 = new System.Windows.Forms.Label();
			this.label46 = new System.Windows.Forms.Label();
			this.label47 = new System.Windows.Forms.Label();
			this.label48 = new System.Windows.Forms.Label();
			this.label49 = new System.Windows.Forms.Label();
			this.label50 = new System.Windows.Forms.Label();
			this.label51 = new System.Windows.Forms.Label();
			this.label52 = new System.Windows.Forms.Label();
			this.label53 = new System.Windows.Forms.Label();
			this.label54 = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			this.panel10.SuspendLayout();
			this.panel4.SuspendLayout();
			this.Hesabim.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage13.SuspendLayout();
			this.tabPage14.SuspendLayout();
			this.panel11.SuspendLayout();
			this.KitapKiralaPencere.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabControl2.SuspendLayout();
			this.tabPage8.SuspendLayout();
			this.tabPage9.SuspendLayout();
			this.panel5.SuspendLayout();
			this.SepetimPanel.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel8.SuspendLayout();
			this.KapsayiciLogin.SuspendLayout();
			this.KayitPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel13.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panel14.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			resources.ApplyResources(this.panel1, "panel1");
			this.panel1.Name = "panel1";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Purple;
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
			this.SepetListesiFiyat.BackColor = System.Drawing.Color.Purple;
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
			this.SepetListesi.BackColor = System.Drawing.Color.Purple;
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
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			resources.ApplyResources(this.panel3, "panel3");
			this.panel3.Name = "panel3";
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.Purple;
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
			// Hesabim
			// 
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
			this.tabPage13.BackColor = System.Drawing.Color.Purple;
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
			this.tabPage14.BackColor = System.Drawing.Color.Purple;
			this.tabPage14.Controls.Add(this.Kalangun);
			this.tabPage14.Controls.Add(this.kiralamaZamani);
			this.tabPage14.Controls.Add(this.label31);
			this.tabPage14.Controls.Add(this.HesabimListbox);
			resources.ApplyResources(this.tabPage14, "tabPage14");
			this.tabPage14.Name = "tabPage14";
			// 
			// Kalangun
			// 
			this.Kalangun.BackColor = System.Drawing.Color.Purple;
			this.Kalangun.BorderStyle = System.Windows.Forms.BorderStyle.None;
			resources.ApplyResources(this.Kalangun, "Kalangun");
			this.Kalangun.ForeColor = System.Drawing.Color.White;
			this.Kalangun.FormattingEnabled = true;
			this.Kalangun.Name = "Kalangun";
			// 
			// kiralamaZamani
			// 
			this.kiralamaZamani.BackColor = System.Drawing.Color.Purple;
			this.kiralamaZamani.BorderStyle = System.Windows.Forms.BorderStyle.None;
			resources.ApplyResources(this.kiralamaZamani, "kiralamaZamani");
			this.kiralamaZamani.ForeColor = System.Drawing.Color.White;
			this.kiralamaZamani.FormattingEnabled = true;
			this.kiralamaZamani.Name = "kiralamaZamani";
			// 
			// label31
			// 
			resources.ApplyResources(this.label31, "label31");
			this.label31.ForeColor = System.Drawing.Color.White;
			this.label31.Name = "label31";
			// 
			// HesabimListbox
			// 
			this.HesabimListbox.BackColor = System.Drawing.Color.Purple;
			this.HesabimListbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			resources.ApplyResources(this.HesabimListbox, "HesabimListbox");
			this.HesabimListbox.ForeColor = System.Drawing.Color.White;
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
			// KitapKiralaPencere
			// 
			this.KitapKiralaPencere.Controls.Add(this.tabPage1);
			this.KitapKiralaPencere.Controls.Add(this.tabPage2);
			this.KitapKiralaPencere.Controls.Add(this.tabPage3);
			this.KitapKiralaPencere.Controls.Add(this.tabPage4);
			this.KitapKiralaPencere.Controls.Add(this.tabPage5);
			this.KitapKiralaPencere.Controls.Add(this.tabPage6);
			this.KitapKiralaPencere.Controls.Add(this.tabPage7);
			this.KitapKiralaPencere.Controls.Add(this.tabPage10);
			this.KitapKiralaPencere.Controls.Add(this.tabPage11);
			this.KitapKiralaPencere.Controls.Add(this.tabPage12);
			resources.ApplyResources(this.KitapKiralaPencere, "KitapKiralaPencere");
			this.KitapKiralaPencere.Name = "KitapKiralaPencere";
			this.KitapKiralaPencere.SelectedIndex = 0;
			this.KitapKiralaPencere.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.Purple;
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
			this.tabPage8.BackColor = System.Drawing.Color.Purple;
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
			this.tabPage9.BackColor = System.Drawing.Color.Purple;
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
			this.tabPage2.BackColor = System.Drawing.Color.Purple;
			resources.ApplyResources(this.tabPage2, "tabPage2");
			this.tabPage2.Name = "tabPage2";
			// 
			// tabPage3
			// 
			this.tabPage3.BackColor = System.Drawing.Color.Purple;
			resources.ApplyResources(this.tabPage3, "tabPage3");
			this.tabPage3.Name = "tabPage3";
			// 
			// tabPage4
			// 
			this.tabPage4.BackColor = System.Drawing.Color.Purple;
			resources.ApplyResources(this.tabPage4, "tabPage4");
			this.tabPage4.Name = "tabPage4";
			// 
			// tabPage5
			// 
			this.tabPage5.BackColor = System.Drawing.Color.Purple;
			resources.ApplyResources(this.tabPage5, "tabPage5");
			this.tabPage5.Name = "tabPage5";
			// 
			// tabPage6
			// 
			this.tabPage6.BackColor = System.Drawing.Color.Purple;
			resources.ApplyResources(this.tabPage6, "tabPage6");
			this.tabPage6.Name = "tabPage6";
			// 
			// tabPage7
			// 
			this.tabPage7.BackColor = System.Drawing.Color.Purple;
			resources.ApplyResources(this.tabPage7, "tabPage7");
			this.tabPage7.Name = "tabPage7";
			// 
			// tabPage10
			// 
			this.tabPage10.BackColor = System.Drawing.Color.Purple;
			resources.ApplyResources(this.tabPage10, "tabPage10");
			this.tabPage10.Name = "tabPage10";
			// 
			// tabPage11
			// 
			this.tabPage11.BackColor = System.Drawing.Color.Purple;
			resources.ApplyResources(this.tabPage11, "tabPage11");
			this.tabPage11.Name = "tabPage11";
			// 
			// tabPage12
			// 
			this.tabPage12.BackColor = System.Drawing.Color.Purple;
			resources.ApplyResources(this.tabPage12, "tabPage12");
			this.tabPage12.Name = "tabPage12";
			// 
			// SepetimPanel
			// 
			this.SepetimPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.SepetimPanel.Controls.Add(this.panel7);
			this.SepetimPanel.Controls.Add(this.panel6);
			this.SepetimPanel.Controls.Add(this.panel8);
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
			this.panel8.BackColor = System.Drawing.Color.Purple;
			this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel8.Controls.Add(this.SepetiTemizle);
			this.panel8.Controls.Add(this.label14);
			this.panel8.Controls.Add(this.label12);
			this.panel8.Controls.Add(this.label13);
			this.panel8.Controls.Add(this.panel9);
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
			this.label12.Name = "label12";
			// 
			// label13
			// 
			resources.ApplyResources(this.label13, "label13");
			this.label13.ForeColor = System.Drawing.Color.White;
			this.label13.Name = "label13";
			// 
			// panel9
			// 
			this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			resources.ApplyResources(this.panel9, "panel9");
			this.panel9.Name = "panel9";
			// 
			// SepetFiyat
			// 
			this.SepetFiyat.BackColor = System.Drawing.Color.Purple;
			this.SepetFiyat.BorderStyle = System.Windows.Forms.BorderStyle.None;
			resources.ApplyResources(this.SepetFiyat, "SepetFiyat");
			this.SepetFiyat.ForeColor = System.Drawing.Color.White;
			this.SepetFiyat.FormattingEnabled = true;
			this.SepetFiyat.Name = "SepetFiyat";
			// 
			// Sepetİsim
			// 
			this.Sepetİsim.BackColor = System.Drawing.Color.Purple;
			this.Sepetİsim.BorderStyle = System.Windows.Forms.BorderStyle.None;
			resources.ApplyResources(this.Sepetİsim, "Sepetİsim");
			this.Sepetİsim.ForeColor = System.Drawing.Color.White;
			this.Sepetİsim.FormattingEnabled = true;
			this.Sepetİsim.Name = "Sepetİsim";
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
			// KapsayiciLogin
			// 
			this.KapsayiciLogin.BackColor = System.Drawing.Color.Purple;
			this.KapsayiciLogin.Controls.Add(this.KayitPanel);
			this.KapsayiciLogin.Controls.Add(this.panel14);
			this.KapsayiciLogin.Controls.Add(this.pictureBox2);
			resources.ApplyResources(this.KapsayiciLogin, "KapsayiciLogin");
			this.KapsayiciLogin.Name = "KapsayiciLogin";
			// 
			// KayitPanel
			// 
			this.KayitPanel.BackColor = System.Drawing.Color.Purple;
			this.KayitPanel.Controls.Add(this.pictureBox1);
			this.KayitPanel.Controls.Add(this.panel13);
			resources.ApplyResources(this.KayitPanel, "KayitPanel");
			this.KayitPanel.Name = "KayitPanel";
			// 
			// pictureBox1
			// 
			resources.ApplyResources(this.pictureBox1, "pictureBox1");
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.TabStop = false;
			// 
			// panel13
			// 
			this.panel13.BackColor = System.Drawing.Color.White;
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
			this.GirisYapKO.ForeColor = System.Drawing.Color.Purple;
			this.GirisYapKO.Name = "GirisYapKO";
			this.GirisYapKO.UseVisualStyleBackColor = false;
			this.GirisYapKO.Click += new System.EventHandler(this.GirisYapKO_Click_1);
			// 
			// KayitOlOnay
			// 
			this.KayitOlOnay.BackColor = System.Drawing.Color.Purple;
			resources.ApplyResources(this.KayitOlOnay, "KayitOlOnay");
			this.KayitOlOnay.ForeColor = System.Drawing.Color.White;
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
			// pictureBox2
			// 
			resources.ApplyResources(this.pictureBox2, "pictureBox2");
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.TabStop = false;
			// 
			// panel14
			// 
			this.panel14.BackColor = System.Drawing.Color.White;
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
			// kayitOl
			// 
			this.kayitOl.BackColor = System.Drawing.Color.Purple;
			resources.ApplyResources(this.kayitOl, "kayitOl");
			this.kayitOl.ForeColor = System.Drawing.Color.White;
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
			this.GirisButon.BackColor = System.Drawing.Color.Purple;
			resources.ApplyResources(this.GirisButon, "GirisButon");
			this.GirisButon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
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
			// VeriGuncelle
			// 
			resources.ApplyResources(this.VeriGuncelle, "VeriGuncelle");
			this.VeriGuncelle.Name = "VeriGuncelle";
			this.VeriGuncelle.UseVisualStyleBackColor = true;
			this.VeriGuncelle.Click += new System.EventHandler(this.VeriGuncelle_Click);
			// 
			// label45
			// 
			resources.ApplyResources(this.label45, "label45");
			this.label45.ForeColor = System.Drawing.Color.White;
			this.label45.Name = "label45";
			// 
			// label46
			// 
			resources.ApplyResources(this.label46, "label46");
			this.label46.ForeColor = System.Drawing.Color.White;
			this.label46.Name = "label46";
			// 
			// label47
			// 
			resources.ApplyResources(this.label47, "label47");
			this.label47.ForeColor = System.Drawing.Color.White;
			this.label47.Name = "label47";
			// 
			// label48
			// 
			resources.ApplyResources(this.label48, "label48");
			this.label48.ForeColor = System.Drawing.Color.White;
			this.label48.Name = "label48";
			// 
			// label49
			// 
			resources.ApplyResources(this.label49, "label49");
			this.label49.ForeColor = System.Drawing.Color.White;
			this.label49.Name = "label49";
			// 
			// label50
			// 
			resources.ApplyResources(this.label50, "label50");
			this.label50.ForeColor = System.Drawing.Color.White;
			this.label50.Name = "label50";
			// 
			// label51
			// 
			resources.ApplyResources(this.label51, "label51");
			this.label51.ForeColor = System.Drawing.Color.White;
			this.label51.Name = "label51";
			// 
			// label52
			// 
			resources.ApplyResources(this.label52, "label52");
			this.label52.ForeColor = System.Drawing.Color.White;
			this.label52.Name = "label52";
			// 
			// label53
			// 
			resources.ApplyResources(this.label53, "label53");
			this.label53.ForeColor = System.Drawing.Color.White;
			this.label53.Name = "label53";
			// 
			// label54
			// 
			resources.ApplyResources(this.label54, "label54");
			this.label54.ForeColor = System.Drawing.Color.White;
			this.label54.Name = "label54";
			// 
			// Form1
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.Controls.Add(this.KapsayiciLogin);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel10.ResumeLayout(false);
			this.panel10.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.Hesabim.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage13.ResumeLayout(false);
			this.tabPage13.PerformLayout();
			this.tabPage14.ResumeLayout(false);
			this.tabPage14.PerformLayout();
			this.panel11.ResumeLayout(false);
			this.panel11.PerformLayout();
			this.KitapKiralaPencere.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabControl2.ResumeLayout(false);
			this.tabPage8.ResumeLayout(false);
			this.tabPage8.PerformLayout();
			this.tabPage9.ResumeLayout(false);
			this.tabPage9.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.SepetimPanel.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel7.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.panel8.ResumeLayout(false);
			this.panel8.PerformLayout();
			this.KapsayiciLogin.ResumeLayout(false);
			this.KayitPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel13.ResumeLayout(false);
			this.panel13.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panel14.ResumeLayout(false);
			this.panel14.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPage5;
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
		private System.Windows.Forms.TabPage tabPage10;
		private System.Windows.Forms.TabPage tabPage11;
		private System.Windows.Forms.TabPage tabPage12;
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
		private PictureBox pictureBox1;
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
		private PictureBox pictureBox2;
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
	}
}

