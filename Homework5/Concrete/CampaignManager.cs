using System;
using System.Collections.Generic;
using System.Text;
using Homework5.Abstract;

namespace Homework5.Concrete
{
    class CampaignManager : ICampaignService
    {
        private List<ICampaign> campaigns = new List<ICampaign>();
        public void Add(ICampaign campaign)
        {
            campaigns.Add(campaign);
        }

        public void Delete(ICampaign campaign)
        {
            campaigns.Remove(campaign);
        }

        public void List()
        {
            foreach(var campaing in campaigns)
            {
                Console.WriteLine("Campaing {0} = {1}  %{2} ", campaing.Id, campaing.name, campaing.Discont);
            }
        }

        public void ApplyDiscont(IGame game , ICampaign campaign)
        {
            var discont = campaign.Discont;
            var price = game.GamePrice;
            var newPrice = price - (price* discont/100);
            game.GamePrice = newPrice;

                Console.WriteLine("{0} is {1} right now via {2}  ", game.Name, game.GamePrice,campaign.name);
        }

        public void SellGame(IPlayer player, IGame game)
        {
           Console.WriteLine(" {0} bought {1} for {2} liras ", player.FirstName , game.Name, game.GamePrice);
        }
    }
}
