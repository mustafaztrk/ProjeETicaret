using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]//nasıl istekte bulunulacagı
    [ApiController]// clas ın controler oldugunu belirtti
    public class ProductsController : ControllerBase
    {
        IProductService _productService;

        public ProductsController(IProductService productService)//veri baglantısı IoC cContainer üzerinden yönetiliyor
        {                                                        //WepApi-Startup içerisinde karşıklarını verdik
            _productService = productService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()//IActionResult sayesinde statu  kodlarımızı da döndüre biliyoruz, örn data message ve state de döndürcez
        {
            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok(result);// ok durum kodu 200 başarılı anlamı var, içidnde datada döndüre biliriz
            }
            return BadRequest(result.Message);//  BadRequest durum kodu 400 hata

        }

        [HttpGet("getbyid")]// iki tane get oparasyonumuz oldugu için client hangisini çalıştırcagını bilemez bundan dolayı isim veriyoruz, yada  [HttpGet(id)] alıcam gibi belirleye biliiz
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                Ok(result);
            }
            return BadRequest(result);
        }
        
    }
}
