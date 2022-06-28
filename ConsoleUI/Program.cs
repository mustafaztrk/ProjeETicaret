﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();

           // CategoryTest();


        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var item in categoryManager.GetAll())
            {
                Console.WriteLine(item.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var item in productManager.GetAll())
            {
                Console.WriteLine(item.ProductName);
            }
            Console.WriteLine("---------------------------");

            foreach (var item in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(item.ProductName);
            }
            Console.WriteLine("---------------------------");

            foreach (var item in productManager.GetProductDetails())
            {
                Console.WriteLine(item.ProductName+" /"+ item.CategoryName);
            }
        }
    }
}
