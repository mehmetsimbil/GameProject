using GameProject.Entities;
using GameProject.Abstract;
using GameProject.Concretes;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            User user1 = new User();
            UserManager userManager = new UserManager(new UserValidationManager());
            user1.Id = 1;
            user1.FirstName = "Mehmet";
            user1.LastName = "Şimbil";
            user1.BirthYear = 1998;
            user1.IdentityNumber = 1111;
            userManager.Add(user1);

            Campaign campaign = new Campaign();
            campaign.CampaignName = "Yüzde 33 indirimi";
            campaign.DiscountRate = 33;

            Sale sale = new Sale();
            sale.GameName = "Knight Online";
            sale.SalePrice = 500;

            SaleManager saleManager = new SaleManager(new CampaignEntegrationManager());
            saleManager.Sale(user1, sale, campaign);
        }
       
    }
}
