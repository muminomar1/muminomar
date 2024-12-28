# OOP İlkeleri ve Proje Değerlendirmesi

Bu proje içerisinde kullanılan dört temel OOP (Nesne Yönelimli Programlama) ilkesinin açıklamaları ve hangi kısımlarda kullanıldıklarına dair bir değerlendirme bulunmaktadır.

## 1. Abstraction (Soyutlama)

**Tanım:**

Soyutlama, bir sınıfın yalnızca önemli özelliklerini ortaya çıkararak detaylardan soyutlanmasını sağlar. Bu, kullanıcıların bir nesnenin iç detaylarını bilmeden onu kullanabilmelerine olanak tanır.

**Kullanımı:**

`Animal` sınıfı, hayvanların genel özelliklerini (`Name` ve `Age`) temsil eder. Bu sınıf, hayvanlarla ilgili ortak özelliklerin bir araya getirilmesiyle soyutlama yapılmıştır. Ancak bu sınıf `abstract` (soyut) olarak tanımlanmış ve doğrudan örneklenmesi engellenmiştir. Bu, hayvanların türetilmiş sınıflar (örneğin, `Lion` veya `Elephant`) tarafından kullanılmasını sağlar.

## 2. Encapsulation (Kapsülleme)

**Tanım:**

Encapsulation, bir nesnenin verilerinin doğrudan erişilmesini engelleyerek, bu verilere yalnızca belirli yöntemler (getter/setter) aracılığıyla erişilmesini sağlar. Bu, verinin kontrolünü ve güvenliğini artırır.

**Kullanımı:**

`Animal` sınıfındaki `Name` ve `Age` alanları, `private set` ile tanımlanarak doğrudan dışarıdan değiştirilmesi engellenmiştir. Bu alanlara yalnızca yapıcı metot (constructor) ile değer atanabilir ve dışarıdan erişim sadece `get` özelliğiyle sağlanır.

## 3. Inheritance (Kalıtım)

**Tanım:**

Inheritance, bir sınıfın başka bir sınıfın özelliklerini ve davranışlarını miras almasını sağlar. Bu, kod tekrarını azaltır ve sınıflar arasında bir hiyerarşi oluşturur.

**Kullanımı:**

`Animal` sınıfı, hayvanlar için temel bir soyut sınıf olarak kullanılmıştır. Diğer hayvan türleri (`Lion`, `Elephant` gibi) bu sınıftan türeyebilir ve ortak özellikleri miras alır. Ancak kodun bu versiyonunda türetme yerine `Animal` doğrudan kullanılmaktadır.

## 4. Polymorphism (Çok Biçimlilik)

**Tanım:**

Polymorphism, bir sınıfın aynı adlı metotlarının farklı şekillerde çalıştırılmasını sağlar. Aynı zamanda, bir nesnenin referansı üzerinden farklı davranışlar sergileyebilmesine olanak tanır.

**Kullanımı:**

Polimorfizm, soyut sınıf ve arayüzlerin (interface) kullanımıyla desteklenmiştir. Örneğin, `IZooManager` arayüzü, `ZooManager` sınıfı için farklı implementasyonların kolayca oluşturulmasına olanak tanır.

## Ekstra İlke: Dependency Inversion (Bağımlılığı Tersine Çevirme)

**Tanım:**

Üst düzey modüller, alt düzey modüllere doğrudan bağımlı olmamalıdır. Bunun yerine, her iki taraf da bir arayüz veya soyutlama üzerinden iletişim kurmalıdır.

**Kullanımı:**

`IZooManager` arayüzü, bağımlılığı tersine çevirme ilkesine uygun olarak tasarlanmıştır. `Program` sınıfı, doğrudan `ZooManager` sınıfına bağımlı değildir. Bunun yerine, `IZooManager` arayüzüne bağımlıdır ve bu, farklı `ZooManager` implementasyonlarının kullanılmasını kolaylaştırır.

## Sonuç:

Bu proje, OOP'nin dört temel ilkesi olan Soyutlama, Kapsülleme, Kalıtım ve Çok Biçimlilik ilkelerini etkili bir şekilde kullanmaktadır. Ayrıca, Bağımlılığı Tersine Çevirme ilkesi sayesinde kod daha esnek ve genişletilebilir hale getirilmiştir.
