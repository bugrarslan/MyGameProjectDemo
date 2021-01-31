using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProjectDemo
{
    class GameSellManager : IGameSellService
    {
        Campaign _campaign;

        public GameSellManager(Campaign campaign)
        {
            _campaign = campaign;
        }

        public void Sell(Game game, Gamer gamer)
        {
            if (_campaign.CampaignForGame == game.GameName)
            {
                Console.WriteLine(game.GameName + " oyunu kampanya miktarı uygulanarak satın alınmıştır");
            }
            else
            {
                Console.WriteLine(game.GameName + " oyunu satın alınmıştır");
            }
        }
    }
}
