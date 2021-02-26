using MyGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame.Abstracts
{
    public interface IOperationService
    {
        void SignIn();

        void Update();

        void Delete();
    }
}
