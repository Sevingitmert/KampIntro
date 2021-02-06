using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using Homework5.Abstract;

namespace Homework5.Concrete
{
    class GameManager : IGameService
    {
        public List<IGame> games = new List<IGame>();
        public void Add(IGame AddGame)
        {
            foreach (var game in games)
            {
                if (game.Id == AddGame.Id)
                {
                    
                    Console.WriteLine("Game is already exist");
                    throw new Exception();
                }

            }
         
            games.Add(AddGame);

            
            

        }

        public void Delete(IGame game)
        {
            games.Remove(game);
        }

        public void Update(int Id, IGame UpGame)
        {
            foreach (var game in games)
            {
                game.Name = (Id == game.Id) ? UpGame.Name : game.Name;
                game.GamePrice = (Id == game.Id) ? UpGame.GamePrice : game.GamePrice;
            }
        }

        public void List()
        {
            foreach (var game in games)
            {
                Console.WriteLine("Game {0} = {1} Price = {2}",game.Id,game.Name, game.GamePrice);
            }
        }
    }
}
