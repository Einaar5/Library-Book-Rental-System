USE [master]
GO
/****** Object:  Database [kutuphaneProjesi]    Script Date: 7.01.2025 20:28:00 ******/
CREATE DATABASE [kutuphaneProjesi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'kutuphaneProjesi', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\kutuphaneProjesi.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'kutuphaneProjesi_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\kutuphaneProjesi_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [kutuphaneProjesi] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [kutuphaneProjesi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [kutuphaneProjesi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [kutuphaneProjesi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [kutuphaneProjesi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [kutuphaneProjesi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [kutuphaneProjesi] SET ARITHABORT OFF 
GO
ALTER DATABASE [kutuphaneProjesi] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [kutuphaneProjesi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [kutuphaneProjesi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [kutuphaneProjesi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [kutuphaneProjesi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [kutuphaneProjesi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [kutuphaneProjesi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [kutuphaneProjesi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [kutuphaneProjesi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [kutuphaneProjesi] SET  ENABLE_BROKER 
GO
ALTER DATABASE [kutuphaneProjesi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [kutuphaneProjesi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [kutuphaneProjesi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [kutuphaneProjesi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [kutuphaneProjesi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [kutuphaneProjesi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [kutuphaneProjesi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [kutuphaneProjesi] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [kutuphaneProjesi] SET  MULTI_USER 
GO
ALTER DATABASE [kutuphaneProjesi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [kutuphaneProjesi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [kutuphaneProjesi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [kutuphaneProjesi] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [kutuphaneProjesi] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [kutuphaneProjesi] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [kutuphaneProjesi] SET QUERY_STORE = ON
GO
ALTER DATABASE [kutuphaneProjesi] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [kutuphaneProjesi]
GO
/****** Object:  Table [dbo].[kitaplarStok]    Script Date: 7.01.2025 20:28:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kitaplarStok](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[kitap_ad] [varchar](50) NOT NULL,
	[kitap_tur] [varchar](30) NOT NULL,
	[kitap_fiyat] [nvarchar](50) NULL,
	[kitap_yazar] [nvarchar](50) NOT NULL,
	[kitap_gorsel] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[kullanici]    Script Date: 7.01.2025 20:28:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kullanici](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ad] [varchar](50) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[sifre] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[siparis]    Script Date: 7.01.2025 20:28:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[siparis](
	[siparisId] [int] IDENTITY(1,1) NOT NULL,
	[kullaniciId] [int] NULL,
	[kitapId] [int] NULL,
	[siparisTarihi] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[siparisId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[kitaplarStok] ON 

INSERT [dbo].[kitaplarStok] ([id], [kitap_ad], [kitap_tur], [kitap_fiyat], [kitap_yazar], [kitap_gorsel]) VALUES (29, N'1984', N'En Popüler', N'70', N'George Orwell', N'C:\Users\canba\Desktop\Kütüphane Projesi\KutuphaneProjesiOdev\KutuphaneProjesi\asseds\PopularBooks\1984.jpg')
INSERT [dbo].[kitaplarStok] ([id], [kitap_ad], [kitap_tur], [kitap_fiyat], [kitap_yazar], [kitap_gorsel]) VALUES (30, N'Hayvan Çiftliği', N'En Popüler', N'77', N'George Orwell', N'C:\Users\canba\Desktop\Kütüphane Projesi\KutuphaneProjesiOdev\KutuphaneProjesi\asseds\PopularBooks\HayvanCiftligi.jpg')
INSERT [dbo].[kitaplarStok] ([id], [kitap_ad], [kitap_tur], [kitap_fiyat], [kitap_yazar], [kitap_gorsel]) VALUES (31, N'Sefiller', N'En Popüler', N'120', N'Victor Hugo', N'C:\Users\canba\Desktop\Kütüphane Projesi\KutuphaneProjesiOdev\KutuphaneProjesi\asseds\PopularBooks\Sefiller.jpg')
INSERT [dbo].[kitaplarStok] ([id], [kitap_ad], [kitap_tur], [kitap_fiyat], [kitap_yazar], [kitap_gorsel]) VALUES (32, N'Dönüşüm', N'En Popüler', N'60', N'Franz Kafka', N'C:\Users\canba\Desktop\Kütüphane Projesi\KutuphaneProjesiOdev\KutuphaneProjesi\asseds\PopularBooks\Donusum.jpg')
INSERT [dbo].[kitaplarStok] ([id], [kitap_ad], [kitap_tur], [kitap_fiyat], [kitap_yazar], [kitap_gorsel]) VALUES (33, N'Suç ve Ceza', N'En Popüler', N'40', N'Fyodor Dostoyevski', N'C:\Users\canba\Desktop\Kütüphane Projesi\KutuphaneProjesiOdev\KutuphaneProjesi\asseds\PopularBooks\SucveCeza.jpg')
INSERT [dbo].[kitaplarStok] ([id], [kitap_ad], [kitap_tur], [kitap_fiyat], [kitap_yazar], [kitap_gorsel]) VALUES (34, N'Simyacı', N'En Popüler', N'44.95', N'Paulo Coelho', N'C:\Users\canba\Desktop\Kütüphane Projesi\KutuphaneProjesiOdev\KutuphaneProjesi\asseds\PopularBooks\Simyaci.jpg')
INSERT [dbo].[kitaplarStok] ([id], [kitap_ad], [kitap_tur], [kitap_fiyat], [kitap_yazar], [kitap_gorsel]) VALUES (35, N'Tutunamayanlar ', N'En Popüler', N'50', N'Oğuz Atay', N'C:\Users\canba\Desktop\Kütüphane Projesi\KutuphaneProjesiOdev\KutuphaneProjesi\asseds\PopularBooks\Tutunamayanlar.jpg')
INSERT [dbo].[kitaplarStok] ([id], [kitap_ad], [kitap_tur], [kitap_fiyat], [kitap_yazar], [kitap_gorsel]) VALUES (38, N'Satranc', N'En Popüler', N'80', N'Stefan Zweig', N'C:\Users\canba\Desktop\Kütüphane Projesi\KutuphaneProjesiOdev\KutuphaneProjesi\asseds\PopularBooks\Satranc.jpg')
INSERT [dbo].[kitaplarStok] ([id], [kitap_ad], [kitap_tur], [kitap_fiyat], [kitap_yazar], [kitap_gorsel]) VALUES (39, N'Kürk Mantolu Madonna', N'En Popüler', N'50', N'Sabahattin Ali', N'C:\Users\canba\Desktop\Kütüphane Projesi\KutuphaneProjesiOdev\KutuphaneProjesi\asseds\PopularBooks\kmm.jpg')
INSERT [dbo].[kitaplarStok] ([id], [kitap_ad], [kitap_tur], [kitap_fiyat], [kitap_yazar], [kitap_gorsel]) VALUES (40, N'Uçurtma Avcısı', N'En Popüler', N'35', N'Khaled Hosseini', N'C:\Users\canba\Desktop\Kütüphane Projesi\KutuphaneProjesiOdev\KutuphaneProjesi\asseds\PopularBooks\UcurtmaAvcisi.jpg')
INSERT [dbo].[kitaplarStok] ([id], [kitap_ad], [kitap_tur], [kitap_fiyat], [kitap_yazar], [kitap_gorsel]) VALUES (41, N'Şeker Portakalı', N'En Popüler', N'90', N'José Mauro', N'C:\Users\canba\Desktop\Kütüphane Projesi\KutuphaneProjesiOdev\KutuphaneProjesi\asseds\PopularBooks\SekerPortakali.jpg')
INSERT [dbo].[kitaplarStok] ([id], [kitap_ad], [kitap_tur], [kitap_fiyat], [kitap_yazar], [kitap_gorsel]) VALUES (43, N'Beyaz Geceler', N'En Popüler', N'75', N'Fyodor Dostoyevski', N'C:\Users\canba\Desktop\Kütüphane Projesi\KutuphaneProjesiOdev\KutuphaneProjesi\asseds\PopularBooks\BeyazGeceler.jpg')
INSERT [dbo].[kitaplarStok] ([id], [kitap_ad], [kitap_tur], [kitap_fiyat], [kitap_yazar], [kitap_gorsel]) VALUES (44, N'Harry Potter Serisi', N'En Popüler', N'75', N'J. K. Rowling', N'C:\Users\canba\Desktop\Kütüphane Projesi\KutuphaneProjesiOdev\KutuphaneProjesi\asseds\PopularBooks\HarryPotter.jpg')
INSERT [dbo].[kitaplarStok] ([id], [kitap_ad], [kitap_tur], [kitap_fiyat], [kitap_yazar], [kitap_gorsel]) VALUES (46, N'Savaş ve Barış', N'Klasik', N'45', N'Lev Tolstoy', N'C:\Users\canba\Desktop\Kütüphane Projesi\KutuphaneProjesiOdev\KutuphaneProjesi\asseds\PopularBooks\SvB.jpg')
INSERT [dbo].[kitaplarStok] ([id], [kitap_ad], [kitap_tur], [kitap_fiyat], [kitap_yazar], [kitap_gorsel]) VALUES (47, N'Anna Karenina', N'Klasik', N'100', N'Lev Tolstoy', N'C:\Users\canba\Desktop\Kütüphane Projesi\KutuphaneProjesiOdev\KutuphaneProjesi\asseds\PopularBooks\annaKarenina.jpg')
INSERT [dbo].[kitaplarStok] ([id], [kitap_ad], [kitap_tur], [kitap_fiyat], [kitap_yazar], [kitap_gorsel]) VALUES (48, N'Suç ve Ceza', N'Klasik', N'22', N'Fyodor Dostoyevski', N'C:\Users\canba\Desktop\Kütüphane Projesi\KutuphaneProjesiOdev\KutuphaneProjesi\asseds\PopularBooks\SucveCeza.jpg')
INSERT [dbo].[kitaplarStok] ([id], [kitap_ad], [kitap_tur], [kitap_fiyat], [kitap_yazar], [kitap_gorsel]) VALUES (50, N'1984', N'Klasik', N'70', N'George Orwell', N'C:\Users\canba\Desktop\Kütüphane Projesi\KutuphaneProjesiOdev\KutuphaneProjesi\asseds\PopularBooks\1984.jpg')
INSERT [dbo].[kitaplarStok] ([id], [kitap_ad], [kitap_tur], [kitap_fiyat], [kitap_yazar], [kitap_gorsel]) VALUES (51, N'Hayvan Çiftliği', N'Klasik', N'77', N'George Orwell', N'C:\Users\canba\Desktop\Kütüphane Projesi\KutuphaneProjesiOdev\KutuphaneProjesi\asseds\PopularBooks\HayvanCiftligi.jpg')
INSERT [dbo].[kitaplarStok] ([id], [kitap_ad], [kitap_tur], [kitap_fiyat], [kitap_yazar], [kitap_gorsel]) VALUES (52, N'Üç Silahşörler', N'Klasik', N'150', N'Alexandre Dumas', N'C:\Users\canba\Desktop\Kütüphane Projesi\KutuphaneProjesiOdev\KutuphaneProjesi\asseds\PopularBooks\ucsilah.jpg')
INSERT [dbo].[kitaplarStok] ([id], [kitap_ad], [kitap_tur], [kitap_fiyat], [kitap_yazar], [kitap_gorsel]) VALUES (55, N'Uçurtma Avcısı', N'Klasik', N'90', N'Khaled Hosseini', N'C:\Users\canba\Desktop\Kütüphane Projesi\KutuphaneProjesiOdev\KutuphaneProjesi\asseds\PopularBooks\UcurtmaAvcisi.jpg')
INSERT [dbo].[kitaplarStok] ([id], [kitap_ad], [kitap_tur], [kitap_fiyat], [kitap_yazar], [kitap_gorsel]) VALUES (56, N'Karamazov Kardeşler', N'Klasik', N'120', N'Fyodor Dostoyevski', N'C:\Users\canba\Desktop\Kütüphane Projesi\KutuphaneProjesiOdev\KutuphaneProjesi\asseds\PopularBooks\kardesler.jpg')
INSERT [dbo].[kitaplarStok] ([id], [kitap_ad], [kitap_tur], [kitap_fiyat], [kitap_yazar], [kitap_gorsel]) VALUES (57, N'Tarihin İzinde', N'Tarih', N'100', N'Arnold J. Toynbee', N'C:\Users\canba\Desktop\Kütüphane Projesi\KutuphaneProjesiOdev\KutuphaneProjesi\asseds\PopularBooks\tarihizinde.jpg')
INSERT [dbo].[kitaplarStok] ([id], [kitap_ad], [kitap_tur], [kitap_fiyat], [kitap_yazar], [kitap_gorsel]) VALUES (58, N'Dünya Tarihi', N'Tarih', N'99', N'William H. McNeill', N'C:\Users\canba\Desktop\Kütüphane Projesi\KutuphaneProjesiOdev\KutuphaneProjesi\asseds\PopularBooks\dunya.jpg')
INSERT [dbo].[kitaplarStok] ([id], [kitap_ad], [kitap_tur], [kitap_fiyat], [kitap_yazar], [kitap_gorsel]) VALUES (59, N'Peloponez Savaşı', N'Tarih', N'40', N'Thukydides', N'C:\Users\canba\Desktop\Kütüphane Projesi\KutuphaneProjesiOdev\KutuphaneProjesi\asseds\PopularBooks\Pelop.jpg')
INSERT [dbo].[kitaplarStok] ([id], [kitap_ad], [kitap_tur], [kitap_fiyat], [kitap_yazar], [kitap_gorsel]) VALUES (60, N'Orta Çağ Avrupa''sı', N'Tarih', N'30', N'Chris Wickham', N'C:\Users\canba\Desktop\Kütüphane Projesi\KutuphaneProjesiOdev\KutuphaneProjesi\asseds\PopularBooks\ortacag.jpg')
INSERT [dbo].[kitaplarStok] ([id], [kitap_ad], [kitap_tur], [kitap_fiyat], [kitap_yazar], [kitap_gorsel]) VALUES (61, N'İkinci Dünya Savaşı', N'Tarih', N'200', N'Antony Beevor', N'C:\Users\canba\Desktop\Kütüphane Projesi\KutuphaneProjesiOdev\KutuphaneProjesi\asseds\PopularBooks\wwii.png')
INSERT [dbo].[kitaplarStok] ([id], [kitap_ad], [kitap_tur], [kitap_fiyat], [kitap_yazar], [kitap_gorsel]) VALUES (62, N'Fransız Devrimi', N'Tarih', N'55', N'Simon Schama', N'C:\Users\canba\Desktop\Kütüphane Projesi\KutuphaneProjesiOdev\KutuphaneProjesi\asseds\PopularBooks\fra.jpg')
INSERT [dbo].[kitaplarStok] ([id], [kitap_ad], [kitap_tur], [kitap_fiyat], [kitap_yazar], [kitap_gorsel]) VALUES (63, N'Osmanlı Tarihi', N'Tarih', N'60', N'Halil İnalcık', N'C:\Users\canba\Desktop\Kütüphane Projesi\KutuphaneProjesiOdev\KutuphaneProjesi\asseds\PopularBooks\osman.jpg')
INSERT [dbo].[kitaplarStok] ([id], [kitap_ad], [kitap_tur], [kitap_fiyat], [kitap_yazar], [kitap_gorsel]) VALUES (64, N'Nutuk', N'Tarih', N'23', N'Mustafa Kemal Atatürk', N'C:\Users\canba\Desktop\Kütüphane Projesi\KutuphaneProjesiOdev\KutuphaneProjesi\asseds\PopularBooks\Nutuk.jpg')
INSERT [dbo].[kitaplarStok] ([id], [kitap_ad], [kitap_tur], [kitap_fiyat], [kitap_yazar], [kitap_gorsel]) VALUES (65, N'Kuzuların Sessizliği', N'Gerilim', N'40', N'Thomas Harris', N'C:\Users\canba\Desktop\Kütüphane Projesi\KutuphaneProjesiOdev\KutuphaneProjesi\asseds\PopularBooks\kuzg.jpg')
INSERT [dbo].[kitaplarStok] ([id], [kitap_ad], [kitap_tur], [kitap_fiyat], [kitap_yazar], [kitap_gorsel]) VALUES (66, N'Dracula', N'Gerilim', N'100', N'Bram Stoker
', N'C:\Users\canba\Desktop\Kütüphane Projesi\KutuphaneProjesiOdev\KutuphaneProjesi\asseds\PopularBooks\dra.jpg')
INSERT [dbo].[kitaplarStok] ([id], [kitap_ad], [kitap_tur], [kitap_fiyat], [kitap_yazar], [kitap_gorsel]) VALUES (67, N'Frankenstein', N'Gerilim', N'150', N'Mary Shelley', N'C:\Users\canba\Desktop\Kütüphane Projesi\KutuphaneProjesiOdev\KutuphaneProjesi\asseds\PopularBooks\frank.jpg')
INSERT [dbo].[kitaplarStok] ([id], [kitap_ad], [kitap_tur], [kitap_fiyat], [kitap_yazar], [kitap_gorsel]) VALUES (68, N'Rebecca', N'Gerilim', N'19', N'Daphne du Maurier', N'C:\Users\canba\Desktop\Kütüphane Projesi\KutuphaneProjesiOdev\KutuphaneProjesi\asseds\PopularBooks\reb.jpg')
INSERT [dbo].[kitaplarStok] ([id], [kitap_ad], [kitap_tur], [kitap_fiyat], [kitap_yazar], [kitap_gorsel]) VALUES (69, N'Savaş ve Barış', N'Edebiyat', N'29', N'Lev Tolstoy', N'C:\Users\canba\Desktop\Kütüphane Projesi\KutuphaneProjesiOdev\KutuphaneProjesi\asseds\PopularBooks\SvB.jpg')
INSERT [dbo].[kitaplarStok] ([id], [kitap_ad], [kitap_tur], [kitap_fiyat], [kitap_yazar], [kitap_gorsel]) VALUES (70, N'Madame Bovary', N'Edebiyat', N'55', N'Gustave Flaubert', N'C:\Users\canba\Desktop\Kütüphane Projesi\KutuphaneProjesiOdev\KutuphaneProjesi\asseds\PopularBooks\madame.jpg')
INSERT [dbo].[kitaplarStok] ([id], [kitap_ad], [kitap_tur], [kitap_fiyat], [kitap_yazar], [kitap_gorsel]) VALUES (71, N'Don Kişot', N'Edebiyat', N'45', N'Miguel de Cervantes', N'C:\Users\canba\Desktop\Kütüphane Projesi\KutuphaneProjesiOdev\KutuphaneProjesi\asseds\PopularBooks\donkis.jpg')
INSERT [dbo].[kitaplarStok] ([id], [kitap_ad], [kitap_tur], [kitap_fiyat], [kitap_yazar], [kitap_gorsel]) VALUES (72, N'Karamazov Kardeşler', N'Edebiyat', N'78', N'Fyodor Dostoyevski', N'C:\Users\canba\Desktop\Kütüphane Projesi\KutuphaneProjesiOdev\KutuphaneProjesi\asseds\PopularBooks\kardesler.jpg')
INSERT [dbo].[kitaplarStok] ([id], [kitap_ad], [kitap_tur], [kitap_fiyat], [kitap_yazar], [kitap_gorsel]) VALUES (73, N'Jane Eyre', N'Edebiyat', N'90', N'Charlotte Brontë', N'C:\Users\canba\Desktop\Kütüphane Projesi\KutuphaneProjesiOdev\KutuphaneProjesi\asseds\PopularBooks\janeeyre.png')
INSERT [dbo].[kitaplarStok] ([id], [kitap_ad], [kitap_tur], [kitap_fiyat], [kitap_yazar], [kitap_gorsel]) VALUES (74, N'Öğrenmeyi Öğrenmek', N'Egitim', N'20', N'Barbara Oakley', N'C:\Users\canba\Desktop\Kütüphane Projesi\KutuphaneProjesiOdev\KutuphaneProjesi\asseds\PopularBooks\ogrenme.png')
INSERT [dbo].[kitaplarStok] ([id], [kitap_ad], [kitap_tur], [kitap_fiyat], [kitap_yazar], [kitap_gorsel]) VALUES (75, N'Düşün ve Zengin Ol', N'Egitim', N'49', N'Napoleon Hill', N'C:\Users\canba\Desktop\Kütüphane Projesi\KutuphaneProjesiOdev\KutuphaneProjesi\asseds\PopularBooks\dusunzengin.jpg')
INSERT [dbo].[kitaplarStok] ([id], [kitap_ad], [kitap_tur], [kitap_fiyat], [kitap_yazar], [kitap_gorsel]) VALUES (77, N'Akıl ve Zeka Oyunları', N'Egitim', N'90', N'Türker Toker', N'C:\Users\canba\Desktop\Kütüphane Projesi\KutuphaneProjesiOdev\KutuphaneProjesi\asseds\PopularBooks\zeka.jpg')
INSERT [dbo].[kitaplarStok] ([id], [kitap_ad], [kitap_tur], [kitap_fiyat], [kitap_yazar], [kitap_gorsel]) VALUES (78, N'C# 9.0 ve .NET 5', N'Egitim', N'29', N'Mark J. Price', N'C:\Users\canba\Desktop\Kütüphane Projesi\KutuphaneProjesiOdev\KutuphaneProjesi\asseds\PopularBooks\c#.jpg')
SET IDENTITY_INSERT [dbo].[kitaplarStok] OFF
GO
SET IDENTITY_INSERT [dbo].[kullanici] ON 

INSERT [dbo].[kullanici] ([id], [ad], [username], [email], [sifre]) VALUES (1, N'Can Bayır', N'Einarr', N'canbayirr055@gmail.com', N'123')
SET IDENTITY_INSERT [dbo].[kullanici] OFF
GO
ALTER TABLE [dbo].[siparis] ADD  DEFAULT (getdate()) FOR [siparisTarihi]
GO
ALTER TABLE [dbo].[siparis]  WITH CHECK ADD FOREIGN KEY([kitapId])
REFERENCES [dbo].[kitaplarStok] ([id])
GO
ALTER TABLE [dbo].[siparis]  WITH CHECK ADD FOREIGN KEY([kullaniciId])
REFERENCES [dbo].[kullanici] ([id])
GO
USE [master]
GO
ALTER DATABASE [kutuphaneProjesi] SET  READ_WRITE 
GO
