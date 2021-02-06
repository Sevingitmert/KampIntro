using System;
using System.Collections.Generic;
using System.Text;
using Homework5.Abstract;

namespace Homework5.Entity
{
    class Player:IPlayer 
    {
    

        public int Id { get; set; }
        public string TcNo { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public int YearOfBirth { get; set; }
    }
}
