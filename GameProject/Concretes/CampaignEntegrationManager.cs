using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concretes
{
    internal class CampaignEntegrationManager : ICampaignEntegretion
    {
        
        public int CampaignEntegretion(Campaign campaign)
        {
            if (campaign.DiscountRate == 33)
            {
                return 33;
            }
            else if(campaign.DiscountRate == 50)
            {
                return 50;
            }
            else if(campaign.DiscountRate == 75)
            {
                return 75;
            }
            else
            {
                return 0;
            }

        }
    }
}

