using MyGame.Abstracts;
using MyGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame.Concrete
{
    public class MemberManager : BaseManager, IOperationService
    {
        private IMemberCheckService _memberCheckService;
        public MemberManager (IMemberCheckService memberCheckService) 
        {
            _memberCheckService = memberCheckService;
        }

        public override void LogIn (Member member) 
        {
            if (_memberCheckService.VerifyPerson(member)) 
            {
                base.LogIn(member);
                Console.WriteLine("\n Kimlik Doğrulandı");
                base.SignIn();

            }
            else 
            {
                Console.WriteLine("\a Doğrulama Yapılamadı");
            }
        }

        public override void SignIn()
        {
           
            Console.WriteLine("\t Üye Girişi Yapıldı");
        }

        public override void Delete()
        {
            Console.WriteLine("Kayıt Silindi");
        }

        public override void Update()
        {
            Console.WriteLine("Bilgiler Güncellendi");
        }

    }
}
