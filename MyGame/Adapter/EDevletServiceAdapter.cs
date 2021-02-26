using MyGame.Abstracts;
using MyGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame.Adapter
{
    public class EDevletServiceAdapter : IMemberCheckService
    {
        public List<Member> GetList()
        {
            return null;
        }

        public bool VerifyPerson(Member member)
        {
            return true;
        }

        
    }
}
