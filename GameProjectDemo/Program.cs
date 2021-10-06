using GameProjectDemo.Abstract;
using GameProjectDemo.Consrete;
using GameProjectDemo.Entities;
using System;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer
            {
                Id = 1,
                NationalityNumber = "123456789",
                FirstName = "Alper",
                LastName = "Bayram",
                DateOfBirth = new DateTime(1993,6,5)
            };

            IGamerService gamerService = new GamerManager();           
            gamerService.Add(gamer1);
            

            Gamer gamer2 = new Gamer
            {
                Id = 2,
                NationalityNumber = "123456789",
                FirstName = "Atakan",
                LastName = "Bayram",
                DateOfBirth = new DateTime(2000,7,15)
            };

            gamerService.Update(gamer2);
            Console.WriteLine("------------------");

            Game game1 = new Game { Id=1, GameName="Valorant", Category="FPS", GamePrice=50 };
            Game game2 = new Game { Id = 2, GameName = "Knight Online", Category = "MMORPG", GamePrice = 200 };
            Game game3 = new Game { Id = 3, GameName = "Counter Strike", Category = "FPS", GamePrice = 500 };

            IGameService gameService = new GameManager();
            gameService.Delete(game1);
            Console.WriteLine("-------------------");

            IOrderService order = new OrderManager();
            order.Order(game1, gamer2);
            order.Order(game2, gamer1);
            Console.WriteLine("-------------------");


            Campaign campaign1 = new Campaign { Id = 1, CampaignName = "Yil Sonu indirimleri ", DiscountRate = 0.05 };
            Campaign campaign2 = new Campaign { Id = 2, CampaignName = "Yaza Merhaba indirimleri ", DiscountRate = 0.25};
            
            order.CampaignOrder(game3, gamer1, campaign1);
            order.CampaignOrder(game1, gamer2, campaign2);



        }
    }
}
