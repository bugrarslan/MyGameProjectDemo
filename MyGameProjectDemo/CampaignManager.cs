﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProjectDemo
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanyası eklendi");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanyası silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanyası güncellendi");
        }
    }
}
