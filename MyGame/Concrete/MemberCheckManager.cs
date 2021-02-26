using MyGame.Abstracts;
using MyGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame.Concrete
{
    public class MemberCheckManager : IMemberCheckService
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
