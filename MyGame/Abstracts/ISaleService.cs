using MyGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame.Abstracts
{
    public interface ISaleService
    {
        void Add(Member member, Campaign campaign, Product game);

        void Purchase(Member member, Campaign campaign, Product game);

        void Pay(Member member,Campaign campaign ,Product game);

    }
}
