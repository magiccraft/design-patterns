# Design Patterns in C# (.NET 9)

Bu depo, tüm 23 **Gang of Four (GoF)** tasarım deseninin C# (.NET 9) ile hazırlanmış, derlenebilir ve çalıştırılabilir örneklerini içermektedir.

Tüm desenler 3 ana kategori altında toplanmış ve her biri için bağımsız bir konsol projesi (`.csproj`, `Program.cs` ve `Sample1/` klasörü) hazırlanmıştır.

---

## 🏗️ 1. Creational Patterns (Yaratımsal Desenler)
Nesne oluşturma mekanizmalarını soyutlayarak, nesnelerin nasıl oluşturulduğundan, birleştirildiğinden ve temsil edildiğinden bağımsız sistemler kurmayı sağlar.

| Tasarım Deseni | Klasör | Açıklama / Senaryo |
| :--- | :--- | :--- |
| **Singleton** | [`Creational/Singleton`](Creational/Singleton) | Bir sınıfın yalnızca tek bir örneğinin olmasını (`Lazy<T>`) ve buna global erişim sağlanmasını garanti eder (Veritabanı Yöneticisi). |
| **Factory Method** | [`Creational/FactoryMethod`](Creational/FactoryMethod) | Nesne oluşturma arayüzü tanımlar ancak hangi somut sınıfın örnekleneceğine alt sınıfların karar vermesini sağlar (Bildirim Sistemi). |
| **Abstract Factory** | [`Creational/AbstractFactory`](Creational/AbstractFactory) | Birbirleriyle ilişkili veya bağımlı nesne ailelerini somut sınıflarını belirtmeden üretir (Çapraz Platform UI Bileşenleri). |
| **Builder** | [`Creational/Builder`](Creational/Builder) | Karmaşık bir nesnenin adım adım (Fluent API / Director) oluşturulmasını sağlar (Özelleştirilebilir Bilgisayar Konfigürasyonu). |
| **Prototype** | [`Creational/Prototype`](Creational/Prototype) | Mevcut nesneleri kopyalayarak (Shallow ve Deep Copy) yeni nesneler üretmeyi sağlar (Belge Klonlama). |

---

## 🧩 2. Structural Patterns (Yapısal Desenler)
Nesnelerin ve sınıfların daha büyük yapılar oluşturmak üzere nasıl bir araya getirileceğini ve esnek kalacağını düzenler.

| Tasarım Deseni | Klasör | Açıklama / Senaryo |
| :--- | :--- | :--- |
| **Adapter** | [`Structural/Adapter`](Structural/Adapter) | Uyumsuz arayüzlere sahip iki sınıfın birlikte çalışmasını sağlar (3. Parti PayPal Ödeme Entegrasyonu). |
| **Bridge** | [`Structural/Bridge`](Structural/Bridge) | Bir soyutlamayı (Abstraction) uygulamasından (Implementation) ayırarak ikisinin de bağımsız olarak geliştirilmesini sağlar (Kumanda & Cihazlar). |
| **Composite** | [`Structural/Composite`](Structural/Composite) | Nesneleri ağaç hiyerarşisi şeklinde düzenleyerek tekil ve bileşik nesnelere aynı şekilde davranılmasını sağlar (Dosya & Klasör Sistemi). |
| **Decorator** | [`Structural/Decorator`](Structural/Decorator) | Nesnelere dinamik olarak yeni davranış ve sorumluluklar ekler (Kahve Sipariş ve Ek Malzeme Sistemi). |
| **Facade** | [`Structural/Facade`](Structural/Facade) | Karmaşık bir kütüphane veya alt sistem kümesine basitleştirilmiş bir ön arayüz sunar (E-Ticaret Sipariş Yönetimi). |
| **Flyweight** | [`Structural/Flyweight`](Structural/Flyweight) | Ortak durumu (Intrinsic State) paylaşarak çok sayıda benzer nesnenin bellek tüketimini en aza indirir (Orman Ağaç Çizim Motoru). |
| **Proxy** | [`Structural/Proxy`](Structural/Proxy) | Başka bir nesneye erişimi kontrol etmek ve yönetmek için bir vekil nesne sunar (Virtual / Lazy Loading Resim Yükleyici). |

---

## 🔄 3. Behavioral Patterns (Davranışsal Desenler)
Nesneler arasındaki etkileşim, iletişim, algoritma akışı ve sorumluluk dağılımını optimize eder.

| Tasarım Deseni | Klasör | Açıklama / Senaryo |
| :--- | :--- | :--- |
| **Chain of Responsibility** | [`Behavioral/ChainOfResponsibility`](Behavioral/ChainOfResponsibility) | Bir isteği işleyebilecek nesneler zinciri boyunca ileterek uygun nesnenin isteği karşılamasını sağlar (Masraf Onay Hiyerarşisi). |
| **Command** | [`Behavioral/Command`](Behavioral/Command) | Bir isteği bir nesneye dönüştürerek parametreleştirmeyi, sıraya almayı ve geri almayı (Undo) destekler (Akıllı Ev Kumandası). |
| **Interpreter** | [`Behavioral/Interpreter`](Behavioral/Interpreter) | Bir dilin dilbilgisini ve ifadelerini yorumlamak için sözdizimi ağacı tanımlar (Matematiksel İfade Yorumlayıcı). |
| **Iterator** | [`Behavioral/Iterator`](Behavioral/Iterator) | Bir koleksiyonun iç yapısını ifşa etmeden elemanlarına sırayla erişim sağlar (Kitap Koleksiyonu Gezgini). |
| **Mediator** | [`Behavioral/Mediator`](Behavioral/Mediator) | Nesnelerin birbiriyle doğrudan iletişim kurmasını engelleyerek bağımlılıkları azaltan bir arabulucu sunar (Sohbet Odası). |
| **Memento** | [`Behavioral/Memento`](Behavioral/Memento) | Bir nesnenin iç durumunu kapsüllemeyi bozmadan saklayıp daha sonra geri yüklemeyi sağlar (Metin Editörü Geri Al/Yinele). |
| **Observer** | [`Behavioral/Observer`](Behavioral/Observer) | Bir nesnede meydana gelen değişiklikleri abone olan diğer nesnelere otomatik olarak bildirir (Borsa / Fiyat Takip Sistemi). |
| **State** | [`Behavioral/State`](Behavioral/State) | Bir nesnenin iç durumu değiştiğinde davranışını değiştirmesini sağlar (Doküman Yayınlama İş Akışı: Taslak -> İnceleme -> Yayınlandı). |
| **Strategy** | [`Behavioral/Strategy`](Behavioral/Strategy) | Bir dizi algoritmayı tanımlayıp kapsülleyerek çalışma zamanında değiştirilebilir olmalarını sağlar (Ödeme Yöntemi Stratejileri). |
| **Template Method** | [`Behavioral/TemplateMethod`](Behavioral/TemplateMethod) | Bir algoritmanın iskeletini temel sınıfta tanımlayıp bazı adımların alt sınıflarda ezilmesine izin verir (Veri Madenciliği Raporlayıcı). |
| **Visitor** | [`Behavioral/Visitor`](Behavioral/Visitor) | Nesne yapısını değiştirmeden nesneler üzerinde çalışacak yeni operasyonlar tanımlamayı sağlar (Vergi & Kargo Hesaplama). |

---

## 🚀 Çalıştırma

Herhangi bir desenin örneğini çalıştırmak için ilgili klasöre gidip terminalde şu komutu çalıştırabilirsiniz:

```bash
cd Creational/Singleton
dotnet run
```
veya
```bash
dotnet run --project Behavioral/Observer
```
