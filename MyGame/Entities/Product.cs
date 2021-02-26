using MyGame.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
    public class Product:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

    }
}
