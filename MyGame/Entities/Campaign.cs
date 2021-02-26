using MyGame.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame.Entities
{
    public class Campaign:IEntity

    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double DiscountOfPercentage { get; set; }

    }
}
