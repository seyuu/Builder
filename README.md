# Builder Tasarım Deseni - Bilgisayar Oluşturma Senaryosu

Bu proje, Builder tasarım desenini kullanarak bir bilgisayar oluşturma senaryosunu uygulamaktadır. Builder tasarım deseni, karmaşık nesnelerin adım adım oluşturulmasını ve farklı özelliklere sahip nesnelerin oluşturulmasını kolaylaştıran bir tasarım desenidir.

## Sınıflar ve İlişkiler

- `ComputerBuilder` sınıfı, `IBuilder` arayüzünü uygulayan bir sınıftır ve bilgisayarın farklı parçalarını ayarlamaktan sorumludur.
- `Computer` sınıfı, oluşturulan bilgisayarın özelliklerini temsil eder. CPU, RAM, depolama ve grafik kartı gibi özelliklere sahip olabilir.
- `ComputerDirector` sınıfı, inşaatçıyı yönetir ve farklı türde bilgisayarların oluşturulması için gerekli adımları belirler. Yüksek performanslı ve düşük performanslı bilgisayarların oluşturulması gibi farklı inşaat senaryolarını içerebilir.

## Uygulama Aşaması

Kodda, önce yüksek performanslı bir bilgisayarın oluşturulması için `ComputerDirector` sınıfına bir construct işlemi verilir. `ComputerDirector` sınıfı, `ComputerBuilder` nesnesini kullanarak adım adım bilgisayarın özelliklerini ayarlar. Ardından, oluşturulan bilgisayarın özellikleri ekrana yazdırılır.

Daha sonra, düşük performanslı bir bilgisayarın oluşturulması için `ComputerDirector` sınıfına başka bir construct işlemi verilir. Yine, `ComputerBuilder` nesnesi kullanılarak bilgisayarın özellikleri ayarlanır ve bu bilgisayarın özellikleri ekrana yazdırılır.

Bu şekilde, Builder tasarım deseni kullanılarak farklı türde bilgisayarların oluşturulması ve özelliklerinin belirlenmesi sağlanır. Builder deseni, karmaşık nesnelerin oluşturulması sürecini soyutlar ve daha esnek bir yapı sunar.
