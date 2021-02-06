using System;
using System.Collections.Generic;
using System.Text;
using Homework5.Abstract;

namespace Homework5.Entity
{
    class Game : IGame
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double GamePrice { get; set; }

    }
}
