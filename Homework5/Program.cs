using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Homework5.Abstract;
using Homework5.Concrete;
using Homework5.Entity;

namespace Homework5
{
    class Program
    {
       public static List<string> Deneme = new List<string>();
        static void Main(string[] args)
        {
            PlayerManager playerManager = new PlayerManager();
           
            IPlayer player1 = new Player();
            player1.Id = 1;
            player1.FirstName = "Mert";
            player1.Surname = "Sevingit";
            player1.TcNo = "12345678910";
            player1.YearOfBirth = 1994 ;
            playerManager.Add(player1);
        

            IPlayer player2 = new Player();
            player2.Id = 2;
            player2.FirstName = "Emre";
            player2.Surname = "Ozturk";
            player2.TcNo = "12345698710";
            player2.YearOfBirth = 1994;
            playerManager.Add(player2);
            
            playerManager.List();
            playerManager.Update(2, new Player() { Id = 2, FirstName = "Efe", Surname = "Onder", TcNo = "12345678911", YearOfBirth = 1994 });
            playerManager.List();

            GameManager gameManager = new GameManager();
            IGame game1 = new Game();
            game1.Id = 1;
            game1.Name = "Outlast";
            game1.GamePrice = 35;
            gameManager.Add(game1);
            gameManager.Add(new Game(){Id = 2,Name = "Outlast 2",GamePrice = 80});

            gameManager.List();

            CampaignManager campaignManager = new CampaignManager();
            ICampaign campaign1 = new Campaign();
            campaign1.Id = 1;
            campaign1.name = "BlackFriday";
            campaign1.Discont = 50;

            campaignManager.Add(new Campaign());
            campaignManager.ApplyDiscont(game1,campaign1);
            campaignManager.SellGame(player1,game1);



        }

    
    }
}
