using GameProjectSimulation.Abstract;
using GameProjectSimulation.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectSimulation.Concrete
{
    internal class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya sisteme eklendi : " + campaign.CampaignName);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya sistemden silindi : " + campaign.CampaignName);
        }

        public void MakeDiscount(Game game, Campaign campaign)
        {
            Console.WriteLine(game.GameName + " adlı oyuna " + campaign.CampaignName + " kampanyası tanımlandı");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi : " + campaign.CampaignName);
        }
    }
}
