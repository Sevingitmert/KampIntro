using System;
using System.Collections.Generic;
using System.Text;
using Homework5.Entity;

namespace Homework5.Abstract
{
    interface IPlayerService
    {
        void Add(IPlayer player);
        void Update(int Id, IPlayer player);
        void Delete(IPlayer player);
        void List();
    }
}
