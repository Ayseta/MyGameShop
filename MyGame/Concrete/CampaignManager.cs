using MyGame.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame.Concrete
{
    public class CampaignManager : IOperationService
    {
        
        public void SignIn()
        {
            Console.WriteLine("\n Kampanya Girişi Yapıldı");
        }

        public void Update()
        {
            Console.WriteLine(" Kampanya Güncellendi");
        }

        public void Delete()
        {
            Console.WriteLine("Kampanya Silindi");
        }
    }
}
