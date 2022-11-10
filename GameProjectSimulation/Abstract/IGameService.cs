using GameProjectSimulation.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectSimulation.Abstract
{
    internal interface IGameService
    {
        void Add(Game game);
        void SaleGame(Gamer gamer, Game game);
        void SaleWithCampaign(Gamer gamer, Game game, Campaign campaign);
    }
}
