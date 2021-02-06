using System;
using System.Collections.Generic;
using System.Text;
using Homework5.Abstract;

namespace Homework5.Entity
{
    class Campaign : ICampaign
    {
        public int Id { get; set; }
        public int Discont { get; set; }
        public string name { get; set; }
    }
}
