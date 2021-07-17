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
 - `docker build -t StockControl .` komutunu çalıştırarak Docker image yaratın.
 - `docker run -d -p 8080:80 StockControl` komutunu çalıştırarak image üzerinden container'ı ayağa kaldırın.
 - Tarayıcı üzerinden http://localhost:8080 adresine giderek uygulamaya erişilebilir.

### Endpointler
#### POST /Cart
Sepete ürün eklemek için kullanılır

##### Örnek Request
`{
"itemId":"5",
"quantity":"1",
"userId":"5000"
}`