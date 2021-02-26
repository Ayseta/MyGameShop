using MyGame.Abstracts;
using MyGame.Adapter;
using MyGame.Concrete;
using MyGame.Entities;
using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t MyGame'e Hoşgeldiniz");

            ProductManager productManager = new ProductManager();
            productManager.SignIn();
            productManager.Update();

            Console.WriteLine("\n Oyunlar : ");
           
            Product game1 = new Product();
            game1.Name = "Puzzle";
            game1.Price = 19.9;
            game1.Description = "Son Versiyon";

            Product game2 = new Product();
            game2.Name = "Karaoke";
            game2.Price = 45.5;
            game2.Description = "Yeni Ürün";
          

            Product game3 = new Product();
            game3.Name = "Platform";
            game3.Price = 70.0;
            game3.Description = "Online Oyun";

            Product[] games = new Product[] { game1, game2, game3 };
            foreach (var game in games)
            {
                Console.WriteLine("\t" +game.Name + " " + game.Price + "Tl" + " " + game.Description);
                Console.WriteLine("\t\t\t Satın al");
            }

           

            Console.WriteLine("\n Satın alabilmek için kayıt ol");

            Member member1 = new Member();
            member1.FirstName = "Badem";
            member1.LastName = "Selvi";
            member1.DateOfBirthYear = 1990;
            member1.NationalId = 12345678910;

            BaseManager memberManager = new MemberManager(new EDevletServiceAdapter());
            memberManager.LogIn(member1);
            Console.WriteLine("\t Giriş Yap");
            memberManager.SignIn();

            Console.WriteLine("\n Size Özel Kampanyalar:");

            Campaign campaign1 = new Campaign();
            campaign1.Id = 00000;
            campaign1.Name = "Bir Alana Diğeri Yarı Fiyatına";
            campaign1.DiscountOfPercentage = 50;

            Campaign campaign2 = new Campaign();
            campaign2.Id = 00001;
            campaign2.Name = "Yeni Üye İndirimli";
            campaign2.DiscountOfPercentage = 30;

            Campaign campaign3 = new Campaign();
            campaign3.Id = 00002;
            campaign3.Name = "Kampanyasız";
            campaign3.DiscountOfPercentage = 0;


            Campaign[] campaigns = new Campaign[] { campaign1, campaign2 };
            foreach(Campaign campaign in campaigns) 
            {
                Console.WriteLine("\t" + campaign.Name);
            }
            
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.SignIn();
            campaignManager.Delete();
            campaignManager.Update();

            Console.WriteLine("\n");

            SaleManager saleManager = new SaleManager();
            saleManager.Add(member1,campaign2,game2);
            saleManager.Purchase(member1,campaign2,game2);
            saleManager.Pay(member1,campaign2,game2);

            memberManager.Update();
            Console.WriteLine("\t\n Mutlu Oyunlar!");
            
            Console.ReadLine();
        }
    }
}
