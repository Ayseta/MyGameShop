using MyGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame.Abstracts
{
    public interface IMemberCheckService
    {
        bool VerifyPerson(Member member);
        public List<Member> GetList();
    }
}
