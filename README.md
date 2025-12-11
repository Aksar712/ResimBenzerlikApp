# 📸 Resim Benzerlik Analizi (Image Similarity App)

C# Windows Forms ile geliştirilmiş, yüklenen iki görsel arasındaki benzerlik oranını matematiksel olarak hesaplayan masaüstü uygulamasıdır.

## 🚀 Özellikler
* **Görsel Yükleme:** `.jpg`, `.jpeg` ve `.png` formatlarını destekler.
* **Benzerlik Skoru:** İki resim arasındaki benzerliği %0 ile %100 arasında bir oranla gösterir.
* **Kullanıcı Dostu:** Basit arayüz ve "Temizle" seçeneği ile kolay kullanım.

## ⚙️ Nasıl Çalışır?
Uygulama, **Piksel Karşılaştırma (Thumbnail Algorithm)** mantığını kullanır:
1.  Yüklenen görselleri hafızada **16x16** boyutuna küçültür.
2.  Her iki resmin piksellerini (RGB değerlerini) tek tek karşılaştırır.
3.  Renk farklarına göre matematiksel bir ortalama çıkararak sonucu ekrana yazar.
---
**Geliştirici:** Abdulkadir Sar
**Dil:** C# .NET Framework
