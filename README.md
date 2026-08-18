Design Patterns (.NET 9)
Bu repo, C# ve .NET 9 kullanarak GoF (Gang of Four) tasarım desenlerini öğrenirken yazdığım kodları ve aldığım notları içeriyor.

Her desen için bağımsız, derlenebilir ve çalıştırılabilir birer konsol projesi hazırladım.

1. Yaratımsal Desenler (Creational)
Singleton (Creational/Singleton): Sınıftan tek bir örnek alınmasını garanti eder (Lazy<T> kullanımı).

Factory Method (Creational/FactoryMethod): Nesne üretim işini alt sınıflara bırakır (Bildirim sistemi örneği).

Abstract Factory (Creational/AbstractFactory): İlişkili nesne ailelerini üretir (UI bileşenleri örneği).

Builder (Creational/Builder): Karmaşık nesneleri adım adım inşa eder (Bilgisayar toplama örneği).

Prototype (Creational/Prototype): Nesneleri klonlayarak çoğaltır (Shallow & Deep copy).

2. Yapısal Desenler (Structural)
Adapter (Structural/Adapter): Farklı arayüzleri birbiriyle uyumlu hale getirir (Ödeme entegrasyonu örneği).

Bridge (Structural/Bridge): Soyutlama ile uygulamayı birbirinden ayırır (Cihaz ve kumanda örneği).

Composite (Structural/Composite): Ağaç hiyerarşisindeki nesneleri tek bir arayüzle yönetir (Dosya/klasör yapısı).

Decorator (Structural/Decorator): Nesneye dinamik olarak yeni özellikler ekler (Kahve sipariş örneği).

Facade (Structural/Facade): Karmaşık bir sistemi tek ve basit bir arayüz arkasına gizler (Sipariş süreci).

Flyweight (Structural/Flyweight): Ortak veriyi paylaşarak bellek kullanımını azaltır.

Proxy (Structural/Proxy): Asıl nesneye erişimi kontrol eden bir vekil sunar (Gecikmeli yükleme).

3. Davranışsal Desenler (Behavioral)
Chain of Responsibility (Behavioral/ChainOfResponsibility): İsteği işleyecek nesneler zinciri oluşturur (Onay mekanizması).

Command (Behavioral/Command): İşlemleri nesneye dönüştürüp sıraya alma ve geri alma (Undo) imkanı verir.

Interpreter (Behavioral/Interpreter): Basit bir dil/ifade yorumlayıcı oluşturur (Matematiksel ifadeler).

Iterator (Behavioral/Iterator): Koleksiyon elemanlarını sırayla gezmeyi sağlar.

Mediator (Behavioral/Mediator): Nesneler arası doğrudan bağımlılığı arabulucu ile çözer (Sohbet odası).

Memento (Behavioral/Memento): Nesnenin durumunu kaydedip daha sonra geri yükler (Metin editörü).

Observer (Behavioral/Observer): Durum değiştiğinde abonelere otomatik haber verir (Fiyat takibi).

State (Behavioral/State): Nesnenin durumuna göre davranış değiştirmesini sağlar (İş akışı adımları).

Strategy (Behavioral/Strategy): Çalışma anında değiştirilebilen algoritmalar tanımlar (Ödeme yöntemleri).

Template Method (Behavioral/TemplateMethod): Algoritmanın ana iskeletini koruyup adımlarını özelleştirir.

Visitor (Behavioral/Visitor): Sınıf yapısını değiştirmeden yeni operasyonlar ekler.
