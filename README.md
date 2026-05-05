# 🏥 Hastane Yönetim Sistemi (Hospital Management System)

C# Windows Forms ve MSSQL veritabanı altyapısı ile geliştirilmiş, çok kullanıcılı bir hastane otomasyon sistemidir. Bu proje, bir hastanenin temel iş akışlarını dijital ortamda yönetmek, randevu süreçlerini hızlandırmak ve personel-hasta iletişimini kolaylaştırmak için tasarlanmıştır.

---

## 📋 Proje Genel Bakışı

Bu sistem; **Sekreter**, **Doktor** ve **Hasta** olmak üzere 3 farklı kullanıcı panelinden oluşmaktadır. ADO.NET teknolojisi kullanılarak merkezi bir SQL bağlantı yönetimi (`sqlbaglantisi.cs`) ile veriler gerçek zamanlı ve güvenli olarak işlenmektedir.

---

## 🌟 Temel Modüller ve Özellikler

### 👤 Sekreter Paneli 
* **Kayıt Yönetimi:** Sisteme yeni doktor ve branş ekleme, silme, bilgi güncelleme (CRUD) işlemleri.
* **Randevu Organizasyonu:** Randevu saatlerini tanımlama, randevuları listeleme ve durum (geçerli/geçersiz) güncelleme.
* **İletişim & Duyuru:** Hastane personelinin görebileceği sistem genelindeki duyuruları oluşturma ve yayınlama.

### 👨‍⚕️ Doktor Paneli
* **Randevu Takibi:** Kendisine atanan hastaların listesini görme, randevu saatlerini ve hasta şikayet detaylarını inceleme.
* **Profil Yönetimi:** Kişisel şifre ve iletişim bilgilerini güncelleme.
* **Duyuru Ekranı:** Sekreter tarafından yayınlanan hastane içi bildirimleri anlık olarak izleme.

### 🤒 Hasta Paneli
* **Üyelik Sistemi:** TC Kimlik No ve kişisel şifre ile sisteme güvenli kayıt ve giriş.
* **Randevu İşlemleri:** Poliklinik (Branş) ve ilgili Doktor seçimi yaparak sistemdeki boş saatlerden kolayca randevu alma.
* **Geçmiş İzleme:** Aktif randevularını ve geçmiş randevu kayıtlarını listeleme.

---

## 🗄️ Veritabanı Mimarisi (MSSQL)

Proje, ilişkisel veritabanı modeli üzerine kurulmuştur (`hastaneProje`). Kullanılan temel tablolar şunlardır:

* `dbo.TBL_Hastalar`: Hasta kişisel verileri ve giriş şifreleri.
* `dbo.TBL_Doktorlar`: Doktor kimlik, iletişim, uzmanlık alanları ve giriş bilgileri.
* `dbo.TBL_Randevular`: Randevu tarih, saat, branş, doktor, hasta eşleşmeleri ve hasta şikayetleri.
* `dbo.TBL_Branslar`: Hastane poliklinik listesi.
* `dbo.TBL_Sekreter`: Yönetici/Sekreter yetkili giriş bilgileri.
* `dbo.TBL_Duyurular`: Sistem geneli bildirim metinleri.

---

## 🛠️ Teknik Detaylar

* **Platform:** .NET Framework / Windows Forms
* **Programlama Dili:** C#
* **Veritabanı:** Microsoft SQL Server (MSSQL)
* **Veri Erişim Teknolojisi:** ADO.NET (Merkezi `sqlbaglantisi.cs` sınıfı)
* **Öne Çıkan Kontroller:** MaskedTextBox (TC/Telefon formatlamaları), DataGridView (Tabloları listeleme), ComboBox (İlişkisel branş/doktor seçimi)
<img width="577" height="398" alt="image" src="https://github.com/user-attachments/assets/8608b778-bde1-4660-a99d-e2f0649e9623" />
<img width="572" height="233" alt="image" src="https://github.com/user-attachments/assets/db43160b-14cf-4d96-91ad-cb36104d02e7" />
<img width="547" height="333" alt="image" src="https://github.com/user-attachments/assets/596b54ec-5e7e-447d-92cd-de00edc95726" />
<img width="558" height="269" alt="image" src="https://github.com/user-attachments/assets/2589862e-9c60-4fff-b293-03a99417b74e" />
<img width="559" height="326" alt="image" src="https://github.com/user-attachments/assets/0b5ac18e-e70c-4195-96d2-8a4d61b09e07" />
<img width="558" height="205" alt="image" src="https://github.com/user-attachments/assets/f50265d8-d39f-45df-adcc-9f2339f02131" />
<img width="550" height="356" alt="image" src="https://github.com/user-attachments/assets/8e5f4bd3-2886-46cd-9e88-f2dfbc4aee74" />
<img width="554" height="309" alt="image" src="https://github.com/user-attachments/assets/91871499-54ca-49c0-8802-6e6790f12bfc" />
<img width="565" height="371" alt="image" src="https://github.com/user-attachments/assets/0bbdee6d-4ba4-4853-aaa7-d3b3ce1f7676" />
<img width="558" height="349" alt="image" src="https://github.com/user-attachments/assets/41966d3c-f3e9-49be-a6f9-07e8890dc6b7" />
<img width="550" height="421" alt="image" src="https://github.com/user-attachments/assets/a09a85c1-03df-42fb-a0f7-195af9c79174" />
<img width="557" height="334" alt="image" src="https://github.com/user-attachments/assets/83f023ba-af2f-4a37-874f-2b6e12d85777" />
<img width="562" height="306" alt="image" src="https://github.com/user-attachments/assets/df941f37-ad3a-479c-a18e-e051d074d3b9" />
<img width="558" height="306" alt="image" src="https://github.com/user-attachments/assets/4c95b214-e36c-404a-b1b2-23f9af2da233" />


