using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5.Abstract
{
    interface ICampaignService 
    {
        void Add(ICampaign campaign);
        void Delete(ICampaign campaign);
        void List();
        void ApplyDiscont(IGame game, ICampaign campaign);
        void SellGame(IPlayer player, IGame game);
    }
}
