using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5.Abstract
{
    interface ICampaign
    {
         int Id { get; set; }
         int Discont { get; set; }
         String name { get; set; }
    }
}
