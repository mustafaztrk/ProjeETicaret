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
         */
    }
}
