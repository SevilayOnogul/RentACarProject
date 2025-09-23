# RentACarProject

Bu depo, araç kiralama işlemlerini yönetmek için geliştirilmiş bir backend uygulamasıdır. CorePackages bağımlılığını kullanarak araç kiralama işlemlerini yönetebilirsiniz.

![Java](https://img.shields.io/badge/Java-17-blue)
![Spring Boot](https://img.shields.io/badge/Spring_Boot-3.x-green)
![PostgreSQL](https://img.shields.io/badge/PostgreSQL-15-blueviolet)
![Maven](https://img.shields.io/badge/Maven-3.9-red)

## 🚀 Başlangıç

Projeyi çalıştırmak için aşağıdaki adımları izleyebilirsiniz:

1. Repository'i klonlayın:

   ```bash
   git clone https://github.com/SevilayOnogul/RentACarProject.git
   ```

2. Gerekli bağımlılıkları yükleyin:

   ```bash
   mvn install
   ```

3. PostgreSQL veritabanını oluşturun:

   ```sql
   CREATE DATABASE rentacar;
   ```

4. `application.properties` dosyasını güncelleyin:

   ```properties
   spring.datasource.url=jdbc:postgresql://localhost:5432/rentacar
   spring.datasource.username=postgres
   spring.datasource.password=your_password
   ```

5. Uygulamayı başlatın:

   ```bash
   mvn spring-boot:run
   ```

6. Uygulama çalışmaya başladığında, API'yi kullanmaya başlayabilirsiniz.

## 💻 Kullanılan Teknolojiler

- Java 17  
- Spring Boot 3.x  
- PostgreSQL  
- Maven  

## ✨ Özellikler

- Araç ekleme, güncelleme ve silme  
- Araç listesi görüntüleme  
- Müşteri ve kiralama yönetimi  
- REST API endpointleri  

## 📝 Notlar

- Bu proje sadece backend tarafını içerir. Frontend için ayrı bir proje gereklidir.  
- Katmanlı mimari, SOLID prensipleri ve Dependency Injection kullanılmıştır.  
- API dökümantasyonu için Swagger eklemeyi planlayabilirsiniz.
