using System;
using GameSimulation.Concrete;
using GameSimulation.Entities;

namespace GameSimulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Gamer gamer1 = new Gamer();
            gamer1.FirstName = "Ümit";
            gamer1.LastName = "Arlı";
            gamer1.IdentityNumber = 39811892146;
            gamer1.BirthYear = 2000;
            gamer1.Id = 1;

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.GamerAdd(gamer1);

            Console.WriteLine("--------------------------");

            Game game1 = new Game();
            game1.GameName = "God Of War";
            game1.Price = 300;
            game1.Id = 1;

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);

            Console.WriteLine("--------------------------");

            Campaign campaign1 = new Campaign();
            campaign1.CampaignName = "Bahar İndirimi!!!";
            campaign1.DiscountRate = 20;
            campaign1.Id = 1;

            CampaignManager campaignManager1 = new CampaignManager();
            campaignManager1.Add(campaign1);

            Console.WriteLine("--------------------------");

            SalesManager salesManager1 = new SalesManager();
            salesManager1.Sell(gamer1, game1, campaign1);


        }
    }
}