using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concretes
{
    class SaleManager : ISaleService
    {
        ICampaignEntegretion _campaignEntegretion;
        public SaleManager(ICampaignEntegretion campaignEntegretion)
        {
            _campaignEntegretion = campaignEntegretion;
        }
        public void Sale(User user, Sale sale, Campaign campaign)
        {
            if (_campaignEntegretion.CampaignEntegretion(campaign)==33)
            {
                sale.SalePrice -= sale.SalePrice * 0.33;
            }
            else if (_campaignEntegretion.CampaignEntegretion(campaign) == 50)
            {
                sale.SalePrice -= sale.SalePrice * 0.50;
            }
            else if(_campaignEntegretion.CampaignEntegretion(campaign) == 75)
            {
                sale.SalePrice -= sale.SalePrice * 0.75;
            }
            Console.WriteLine(user.FirstName +" "+user.LastName+" adlı kişiye "+sale.GameName+" adlı oyun "+campaign.CampaignName+ " adlı kampanya kapsamında "+ sale.SalePrice+ " ücretiyle satılmıştır.");
        }
    }
}
