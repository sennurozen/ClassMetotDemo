﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleIU
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());
            
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.DailyPrice);
            }

            
        }
    }
}
