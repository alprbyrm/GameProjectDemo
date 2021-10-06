using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Consrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya Eklenmistir "+ campaign.CampaignName);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silinmistir " + campaign.CampaignName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya Guncellenmistir " + campaign.CampaignName);
        }
    }
}
