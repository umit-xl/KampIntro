using GameSimulation.Abstract;
using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation.Concrete
{
    internal class SalesManager : ISalesService
    {
        public void Sell(Gamer gamer, Game game , Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName + " Adlı oyuncuya " + 
                campaign.CampaignName + " Kampanyasıyla birlikte " + game.GameName + " Oyunu satıldı");
        }
    }
}
