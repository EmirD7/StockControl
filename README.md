﻿
# Stok Kontrol Uygulaması

### Proje Açıklaması

- Stock kontrolü gibi ekleyebileceğiniz yeni kontroller varsa sepete ekleme aşamasında bu kontrollerin yapılması.
- Kodun niceliğinden çok niteliğine dikkat edilmesi.
- Yazılan kodların genel kabul görmüş kalite standartlarında olması.
- Kodun, üzerinde geliştirme yapılmaya açık ve anlaşılır olması.
- Test edilebilir olması.
- Ekstra konfigurasyon gerektirmeden (manuel DB kurulumu vs.) kolayca çalışabilir olması.
- Yazılım mimarisi ve pratiklerine, teknolojiye ve bu alandaki yeniliklere bakış açınızı yansıtıyor olması.

### Uygulamayı çalıştırmak için
 - Uygulamanın bulunduğu (DockerFile ve solution dosyalarının bulunduğu) ana dizine gidin.
 - `docker build -t stockcontrol .` komutunu çalıştırarak Docker image yaratın.
 - `docker run -d -p 8080:80 stockcontrol` komutunu çalıştırarak image üzerinden container'ı ayağa kaldırın.
 - Postman vb bir uygulama üzerinden aşağıdaki endpoint'e istek gönderilerek uygulamaya erişilebilir.
 
### Ek Bilgiler
 - Uygulamanın test edilebilmesi için 5000 itemId'li üründen 5 adet stok DatabaseSeeder.cs class'ı ile veritabanına eklenmiştir.
 - Uygulama, stokta bulunan miktardan fazla ürünü sepete eklemeye izin vermemektedir.
 - Uygulama, başka kullanıcıların sepetinde olan aynı ürünleri rezerve edilmiş olarak görmekte ve sepetinize eklemeye izin vermemektedir.

### Endpointler
#### POST http://localhost:8080/Cart
Sepete ürün eklemek için kullanılır

##### Örnek Request
`{
"itemId":"5",
"quantity":"1",
"userId":"5000"
}`

