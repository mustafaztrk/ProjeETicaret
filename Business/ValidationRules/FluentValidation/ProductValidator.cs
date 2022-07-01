using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()//bu kurallar ctor içine yazılır
        {
            RuleFor(p => p.ProductName).NotEmpty();//Boş olamaz
            RuleFor(p => p.ProductName).MinimumLength(2);
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);//büyük olmalı
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);
            //uniPrice 10 dan büyük olmalı ne zaman categoryId 1 oldugunda
           RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürünler A harfi ile başlamalı"); // Kendi oluşturdugumuz bir kurala uymak için Must  kullanırız
            //.WithMessage default mesaj yerine özel mesaj yazmak için



        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
