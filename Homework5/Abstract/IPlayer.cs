using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5.Abstract
{
    interface IPlayer
    {
         int Id { get; set; }
         string TcNo { get; set; }
         string FirstName { get; set; }
         string Surname { get; set; }
         int YearOfBirth { get; set; }
    }
}
