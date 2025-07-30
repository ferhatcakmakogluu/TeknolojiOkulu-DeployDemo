## Proje Özeti

Bu Web API projesi:

- .NET 7 ile yazılmıştır.
- Basit bir `Product` modelini bellekte saklar ve `/api/Products` endpoint'i ile sunar.
- Veritabanı bağlantısı içermez.
- Docker ile containerize edilmiştir.
- GitHub Actions workflow ile her `main` branch'e push yapıldığında otomatik olarak yeniden deploy edilir.
- Render.com üzerinde barındırılmaktadır.

- ---

## Deployment Süreci

1. Proje içerisinde bir `Dockerfile` oluşturuldu.
2. GitHub Actions kullanılarak `.github/workflows/render-deploy.yml` dosyası ile otomasyon sağlandı.
3. Her `main` branch'e push sonrası:
   - Docker image oluşturulur.
   - Render platformundaki API otomatik olarak yeniden deploy edilir.
4. Render üzerinde yayına alınan uygulama endpoint'i aşağıdadır.

---

## Yayındaki API

Canlı ortam:  
➡️ [https://teknolojiokulu-deploy-demo.onrender.com/api/Products](https://teknolojiokulu-deploy-demo.onrender.com/api/Products)

---

## Örnek API İsteği

```bash
curl https://teknolojiokulu-deploy-demo.onrender.com/api/Products
