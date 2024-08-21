Bu C# uygulaması kullanıcının girdiği bir sayının karesini hesaplayarak ekranda gösterir. Kullanıcıdan gelen girdinin bir sayı olup olmadığını kontrol eder ve geçerli bir sayı değilse kullanıcıyı uyarır.

Kullanılan Teknolojiler
Dil: C#

Nasıl Çalışır?
Uygulama kullanıcıdan bir sayı girmesini ister.
Kullanıcı girdiğini girdikten sonra, program bu girdiyi bir sayıya dönüştürmeye çalışır.
Girdi geçerli bir sayı ise, program bu sayının karesini hesaplayarak ekrana yazdırır.
Girdi bir sayı değilse, program kullanıcıyı "Invalid Entry! Please enter a number" mesajıyla uyarır ve işlem sona erer.
Hata Yönetimi
Uygulama, kullanıcıdan alınan girdiyi sayıya dönüştürürken bir FormatException oluşma ihtimaline karşı koruma sağlar. Eğer kullanıcı geçersiz bir girdi (örneğin harfler veya semboller) girerse, program yakalanan bu hatayı yönetir ve kullanıcıyı doğru bir giriş yapmaya yönlendirir.
