using MyGame.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
    public class ProductManager : IOperationService
    {
        public void SignIn()
        {
            Console.WriteLine("\n Oyun Girişi Yapıldı");
        }

        public void Delete()
        {
            Console.WriteLine("Oyun Silindi");
        }

        public void Update()
        {
            Console.WriteLine("Oyun Güncellendi");
        }
    }
}
