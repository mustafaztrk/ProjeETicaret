using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    class Not
    {

        /*
         * 
         *  RESTFUL --> HTTP --> 
         * Web api 
         * WebAPI.Controllers/WeatherForecastController sınıfı gelen bütün isteleri bura karşılar-hava alanı kule
         * ekleme silme güncelleme gibi
         * Bu dosya icerisinde sistemimize yapıla bilecek istekleri kodluyoruz 
         * 
         * WebAPI.Controllers altına isteklerimizi karşılıya bilmek için controller lar yazıcaz, add -controler- api controler
         * 
         * Controlorun ctorunda I..Dal a karşılık gelecek olan ..Dal sınıfını IoC kullanarak   WepApi-Startup içerisinde eşleştirdik
         * Bunları daha sonra bussiness içine taşıyoruz çünkü burda yaptıgımız eşleştirmeler bu api nin içinde kalıyo başka api eklesek sıkıntı
         * autofac kullanarak yapcaz
         * 
         * Autofac,Ninject,CastleWindros,StructureMap,LightInject,DryInject --> Ioc Container altarnatifleri İlerleye zamanlarda bunlardan birine taşıycaz
         * AOP Yacagımız için taşıyoruz
         * Autofac AoP imkanı sunar
         * AOP örnegin;
         * [LogAspect] metot üstüne böyle bişey yazacagız
         * git bu metotu logla demek
         *  AoP--> bir metotun önünde bir metotun sonunda o metot hata verdiginde çalışan kod paracıkları
         *  Loglama yönetimi, hata yönetimi....
         *  örn;
         *  [LogAspect] 
         *  [Validate]  yani dogrular, ürün eklenecek bu ürün iş kuralalrıma uyuyor mu
         *  [Cache] cache den calış 
         *  [RemoveCache] cache den ucur, ürün ekleme olduysa cache den at
         *  [Transaction] bu bir banka uygulaması x in hesabında y ye para gönderdi, x den para cıktı y de gecerken hata aldı, işlemleri geri al
         *  [Performance] bu methodun calışması x saniyeyi gecerse beni uyar gibi..
         * 
         * 
         *  200 - "OK" (istek başarılı)
            201 - "Created" (istek başarılı ve yeni bir kaynak oluşturuldu)
            301 - "Moved Permanently" (istenilen kaynağın urlsi kalıcı olarak değiştirildi)
            400 - "Bad Request" (client hatası olarak algılanan bir şey nedeniyle sunucu isteği işleyemiyor veya işlemeyecek)
            401 - "Unauthorized" (client kimliğini doğrulanmamış.)
            403 - "Forbidden" (client'ın içeriğe erişim hakkı yoktur, 401'den farkı sunucu client'ın kimliğini bilir)
            404 - "Not Found" (Sunucu istenilen kaynağı bulamıyor)
            500 - "Internal Server Error" (Sunucu istenmeyen türden bir durumla karşılaştı)
            502 - "Bad Gateway" ( Bu hata, sunucu gereken yanıtı almak için getaway olarak çalışırken aldığı bir geçersiz yanıt durumunda oluşur.)

            100-199 "Informational Responses"
            200-299 "Successful Responses"
            300-399 "Redirection Responses"
            400-499 "Client Error Responses"
            500-599 "Server Error Resonses"
         * 
         * 
         * 
         * validation dogrulama kodları, bussines ile karıştırma
         */
    }
}
