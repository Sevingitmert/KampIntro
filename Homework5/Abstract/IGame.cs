using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5.Abstract
{
    interface IGame
    {
         int Id { get; set; }
         string Name { get; set; }
         double GamePrice { get; set; }
    }
}
