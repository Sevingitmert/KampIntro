using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5.Abstract
{
    interface IGameService
    {
        void Add(IGame game);
        void Delete(IGame game);
        void Update(int Id, IGame game);
        void List();



    }
}
