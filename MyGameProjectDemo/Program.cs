using System;

namespace MyGameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.FirstName = "BUĞRA";
            gamer1.LastName = "ARSLAN";
            gamer1.BirthYear = 2002;
            gamer1.IdentityNumber = 12345;
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer1);

            Game game1 = new Game();
            game1.GameId = 1;
            game1.GameName = "FİFA 21";
            game1.GameCategory = "futbol";
            game1.GamePrice = 280;
            GameManager gameManager = new GameManager();
            gameManager.Add(game1);

            Campaign campaign1 = new Campaign();
            campaign1.CampaignId = 1;
            campaign1.CampaignName = "FİFA 21 için % 10 indirim!";
            campaign1.CampaignCategory = 5;
            campaign1.CampaignForGame = "FİFA 21";
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);

            GameSellManager gameSellManager = new GameSellManager(campaign1);
            gameSellManager.Sell(game1, gamer1);
        }
    }
}
