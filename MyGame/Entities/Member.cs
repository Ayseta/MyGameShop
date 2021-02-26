using MyGame.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame.Entities
{
    public class Member:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DateOfBirthYear { get; set; }
        public long NationalId { get; set; }
    }
}
