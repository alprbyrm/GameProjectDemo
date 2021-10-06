using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Consrete
{
    class OrderManager : IOrderService

    {     
        public void Order(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+" " +gamer.LastName+" " +game.GameName+" oyununu "+ game.GamePrice +"TL satin aldi.");
        }

        public void CampaignOrder(Game game, Gamer gamer, Campaign campaign)
        {          
            double indirimOranı = game.GamePrice - (game.GamePrice * campaign.DiscountRate);

            Console.WriteLine(gamer.FirstName+" " + gamer.LastName + " " + game.GameName + " oyununu " + indirimOranı + "TL satin aldi.");
        }

    }
}
