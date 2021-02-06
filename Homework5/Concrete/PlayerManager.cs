using System;
using System.Collections.Generic;
using System.Text;
using Homework5.Abstract;
using Homework5.Entity;

namespace Homework5.Concrete
{
    class PlayerManager : IPlayerService
    { 
        public List<IPlayer> players = new List<IPlayer>();
        public void Add(IPlayer player)
        {
            if (CheckIfRealPerson(player)==true)
            {
                foreach (var checkplayer in players)
                {
                    if (player.Id == checkplayer.Id)
                    {
                        throw new Exception();
                       
                    }

                }
                players.Add(player);
                
                
            }
           

            else
            {
                Console.WriteLine("{0} \b {1} is not real person",player.FirstName,player.Surname);
            }


        }

      

        public void Update(int Id, IPlayer UpPlayer)
        {
            foreach (var player in players)
            {
                player.FirstName = (player.Id == Id) ? UpPlayer.FirstName : player.FirstName;
                player.Surname = (player.Id == Id) ? UpPlayer.Surname : player.Surname;
                player.TcNo = (player.Id == Id) ? UpPlayer.TcNo : player.TcNo;
                player.YearOfBirth = (player.Id == Id) ? UpPlayer.YearOfBirth : player.YearOfBirth;
            }

            Console.WriteLine("Person {0} person updated as an {1} \b {2}", Id , UpPlayer.FirstName, UpPlayer.Surname);
        }

        public void Delete(IPlayer player)
        {
            players.Remove(player);
        }

        public bool CheckIfRealPerson(IPlayer player)
        {
            
            if (player.TcNo.Length == 11)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public void List()
        {
            foreach (var player in players)
            {
                 Console.WriteLine("{0} \t\t {1} \t\t",player.FirstName, player.Surname );
            }
        }
    }
}
