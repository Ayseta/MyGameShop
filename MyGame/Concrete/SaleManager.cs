using MyGame.Abstracts;
using MyGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame.Concrete
{
    public class SaleManager : ISaleService
    {
       
        public void Add(Member member, Campaign campaign, Product game)
        {
            Console.WriteLine("Sayın:  " + member.FirstName + ", " +campaign.Name + ", " +game.Name +"  Oyunu Sepete Eklediniz");
        }

       
        public void Pay(Member member, Campaign campaign, Product game)
        {
            
            Console.WriteLine("\t" + game.Price +"Tl"+" "+ campaign.DiscountOfPercentage +"% indirimle " + "  Oyunu Satın Aldınız");
        }

        public void Purchase(Member member, Campaign campaign, Product game)
        {
            Console.WriteLine("Sayın:  " + member.FirstName + ", " + game.Description + ", " + game.Name+"  için Ödemeniz Başarılı ");
        }
    }
}
