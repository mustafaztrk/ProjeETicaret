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

            foreach (var item in productManager.GetAllByUnitPrice(10,200))
            {
                Console.WriteLine(item.ProductName);
            }
        }
    }
}
