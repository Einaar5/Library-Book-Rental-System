📚 Library Book Rental System
Bu proje, kullanıcıların kitapları kolayca sepete ekleyip kiralayabileceği bir Kitap Kiralama Sistemidir. Varsayılan kiralama süresi 3 hafta olarak belirlenmiştir ve gerektiğinde bu süre ayarlanabilir. Proje, ADO.NET kullanılarak geliştirilmiş olup veritabanı işlemleri için özel bir DataHelper kütüphanesi kullanmaktadır.

✨ Özellikler
📚 Kitap Sepeti: Kullanıcılar diledikleri kitapları sepete ekleyebilir ve toplu kiralama yapabilir.
⏳ Kiralama Süresi: Varsayılan olarak 3 hafta ayarlanmıştır. Kullanıcı isteğine göre değiştirilebilir.
👤 Kullanıcı Yönetimi: Kullanıcılar kendi bilgilerini kolayca güncelleyebilir.
🗄️ Veritabanı Yönetimi: Kitaplar, kullanıcılar ve kiralamalar veritabanında güvenli bir şekilde saklanır.
🖥️ Modern Arayüz: Kullanıcı dostu ve modern bir tasarıma sahiptir.
💻 Kullanılan Teknolojiler
C#: Uygulamanın geliştirilmesi.
Windows Forms veya WPF: Modern kullanıcı arayüzü tasarımı.
ADO.NET: Veritabanı işlemleri.
SQL Server: Kitap, kullanıcı ve kiralama bilgilerini saklamak için.
Custom DataHelper Library: Veritabanı bağlantıları ve sorguları yönetmek için özel bir kütüphane.
🚀 Kurulum ve Çalıştırma
Bu Depoyu Klonlayın:

bash
Kodu kopyala
git clone https://github.com/Einaar5/Library-Book-Rental-System.git
cd Library-Book-Rental-System
Veritabanını Ayarlayın:

SQL Server üzerinde LibrarySystem adında bir veritabanı oluşturun.
Proje dosyalarında bulunan DatabaseScript.sql dosyasını çalıştırarak tabloları oluşturun.
Veritabanı Bağlantısını Yapılandırın:

App.config dosyasında veritabanı bağlantı dizinini güncelleyin:
DataHelper.cs
Kodu kopyala
private string baglantiAnahtari = @"Data Source=YOUR_SERVER_NAME;Initial Catalog=kutuphaneProjesi;Integrated Security=True;TrustServerCertificate=True";
Projeyi Çalıştırın:

Visual Studio'da projeyi açın.
Çalıştırmak için F5 tuşuna basın.

🎮 Nasıl Kullanılır?
Kitap Sepeti

Kullanıcı, kitapları sepete ekleyebilir ve toplu kiralama yapabilir.
Kiralama süresi varsayılan olarak 3 haftadır, ancak kullanıcı isteğine göre değiştirilebilir.
Kullanıcı Yönetimi

Kullanıcılar, ad, soyad, e-posta ve diğer bilgilerini güncelleyebilir.
Kitap Kiralama

Sepete eklenen kitaplar "Kiralama Onayı" işlemiyle veritabanına kaydedilir.
🛠️ Yapılabilecek Geliştirmeler
🌐 Web Paneli: ASP.NET Core veya Blazor ile bir web arayüzü eklenebilir.
📱 Mobil Destek: Xamarin veya MAUI ile mobil uygulama geliştirilmesi.
🔔 Bildirim Sistemi: Kiralama süresi dolmadan önce kullanıcıya hatırlatma bildirimleri gönderilebilir.
📊 Gelişmiş Raporlama: Kiralama geçmişi ve envanter bilgileriyle kapsamlı raporlama.
🖇️ Bağımlılıklar

Microsoft .NET Framework/5.0+
SQL Server
Özel DataHelper Kütüphanesi (Proje içinde sağlanmıştır)
📧 İletişim
Bu proje hakkında geri bildirim vermek veya katkıda bulunmak isterseniz benimle iletişime geçebilirsiniz:

E-posta: canbayirr055@gmail.com
GitHub: Einaar5
