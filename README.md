# 🚗 Rent A Car Project

Bu proje, bir araba kiralama uygulamasının **backend API'sini** içerir.  
Kullanıcılar araba kiralayabilir, rezervasyon oluşturabilir ve ürünleri görebilir.  
Proje, **katmanlı mimari** ve **modüler yapı** ile geliştirilmiştir.

---

## 🛠️ Kullanılan Teknolojiler ve Kütüphaneler
- **.NET 8 / C#**
- **Entity Framework Core** (SQL Server, InMemory)
- **AutoMapper**
- **FluentValidation**
- **MediatR (CQRS)**
- **Serilog** (Dosya ve SQL Logging)
- **Redis Cache (StackExchange.Redis)**
- **Swagger / Swashbuckle**
- **System.Linq.Dynamic.Core**

---

## 📂 Projede Katmanlar
- **Core Packages**: Ortak modüller, güvenlik ve persistence paketleri  
- **Domain**: Entity ve domain modelleri  
- **Application**: İş kuralları ve CQRS  
- **Persistence**: Veritabanı işlemleri  
- **Web/API**: API controller ve endpointler  

---

## 🔗 Core Paketleri
Projenin **ortak paketlerini** incelemek ve kullanmak istersen [Rent A Car Core Packages](https://github.com/SevilayOnogul/RentACarProject-CorePackages) reposuna göz atabilirsin.

---

## ⚡ Kurulum
1. Reponuzu klonlayın:  
```bash
git clone https://github.com/SevilayOnogul/RentACarProject.git
```
2.Visual Studio’da çözümü açın.

3.Önce Core Packages projelerini build edin (bu paketler, ana projede kullanılan ortak katmanları içerir).

4.Ardından Web/API projesini başlatın.

5.Tarayıcıda veya Postman ile API endpointlerini test edebilirsiniz.
